using inventryUI.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using inventryUI; // for DBConnection

namespace WinFormsApp1.Controllers
{
    public class PurchaseOrderController
    {
        // ✅ Add Order to MySQL
        public void AddOrder(string productName, string supplierName, int quantity, DateTime expectedDelivery)
        {
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(supplierName) || quantity <= 0)
            {
                MessageBox.Show("Please fill all fields properly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO purchase_orders 
                                    (ProductName, SupplierName, Quantity, Status, ExpectedDelivery) 
                                    VALUES (@product, @supplier, @quantity, 'Pending', @delivery)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@product", productName);
                        cmd.Parameters.AddWithValue("@supplier", supplierName);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@delivery", expectedDelivery);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("✅ Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Get All Orders from MySQL
        public List<PurchaseOrder> GetAllOrders()
        {
            List<PurchaseOrder> orders = new List<PurchaseOrder>();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM purchase_orders";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new PurchaseOrder
                            {
                                OrderId = reader.GetInt32("OrderId"),
                                ProductName = reader.GetString("ProductName"),
                                SupplierName = reader.GetString("SupplierName"),
                                Quantity = reader.GetInt32("Quantity"),
                                Status = reader.GetString("Status"),
                                ExpectedDelivery = reader.GetDateTime("ExpectedDelivery")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load orders: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return orders;
        }

        // ✅ Update Order Status
        public void UpdateStatus(int orderId, string newStatus)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE purchase_orders SET Status = @status WHERE OrderId = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", orderId);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show($"✅ Order #{orderId} marked as '{newStatus}'.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("⚠️ Order not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to update order: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Delete Order from MySQL
        public void DeleteOrder(int orderId)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM purchase_orders WHERE OrderId = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", orderId);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show($"🗑️ Order #{orderId} deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("⚠️ Order not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to delete order: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
