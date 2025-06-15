using inventryUI.Models;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace inventryUI.Controllers
{
    public class StockController
    {
        private readonly string connectionString = "server=localhost;user=root;password=;database=inventory_db;";

        public void IncreaseStock(string productSku, int quantity)
        {
            ExecuteStockUpdate(productSku, quantity, "increase");
        }

        public void ReduceStock(string productSku, int quantity)
        {
            ExecuteStockUpdate(productSku, -quantity, "decrease");
        }

        public void ManualAdjust(string productSku, int newQuantity)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new MySqlCommand("UPDATE products SET Quantity = @newQty WHERE SKU = @sku", conn);
                cmd.Parameters.AddWithValue("@newQty", newQuantity);
                cmd.Parameters.AddWithValue("@sku", productSku);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("INSERT INTO stock_movements (product_sku, movement_type, quantity) VALUES (@sku, 'adjust', @newQty)", conn);
                cmd.Parameters.AddWithValue("@sku", productSku);
                cmd.Parameters.AddWithValue("@newQty", newQuantity);
                cmd.ExecuteNonQuery();
            }
        }

        public void ProcessSale(string productSku, int quantity)
        {
            string invoiceNumber = "INV" + DateTime.Now.Ticks.ToString();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                var saleCmd = new MySqlCommand("INSERT INTO sales (product_sku, quantity_sold, invoice_number) VALUES (@sku, @qty, @inv)", conn);
                saleCmd.Parameters.AddWithValue("@sku", productSku);
                saleCmd.Parameters.AddWithValue("@qty", quantity);
                saleCmd.Parameters.AddWithValue("@inv", invoiceNumber);
                saleCmd.ExecuteNonQuery();

                var stockCmd = new MySqlCommand("UPDATE products SET Quantity = Quantity - @qty WHERE SKU = @sku", conn);
                stockCmd.Parameters.AddWithValue("@qty", quantity);
                stockCmd.Parameters.AddWithValue("@sku", productSku);
                stockCmd.ExecuteNonQuery();
            }
        }

        public void GenerateInvoice(string invoiceNumber)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT s.id, p.ProductName, s.quantity_sold, p.Price, (s.quantity_sold * p.Price) AS total " +
                                           "FROM sales s JOIN products p ON s.product_sku = p.SKU " +
                                           "WHERE s.invoice_number = @inv", conn);
                cmd.Parameters.AddWithValue("@inv", invoiceNumber);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Implement UI or export logic here
                    }
                }
            }
        }

        public DataTable GetStockLevels()
        {
            var table = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT SKU, ProductName, Quantity FROM products";
                using (var adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }

        private void ExecuteStockUpdate(string productSku, int quantityDelta, string type)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                var updateCmd = new MySqlCommand("UPDATE products SET Quantity = Quantity + @delta WHERE SKU = @sku", conn);
                updateCmd.Parameters.AddWithValue("@delta", quantityDelta);
                updateCmd.Parameters.AddWithValue("@sku", productSku);
                updateCmd.ExecuteNonQuery();

                var movementCmd = new MySqlCommand("INSERT INTO stock_movements (product_sku, movement_type, quantity) VALUES (@sku, @type, @qty)", conn);
                movementCmd.Parameters.AddWithValue("@sku", productSku);
                movementCmd.Parameters.AddWithValue("@type", type);
                movementCmd.Parameters.AddWithValue("@qty", Math.Abs(quantityDelta));
                movementCmd.ExecuteNonQuery();
            }
        }
    }
}
