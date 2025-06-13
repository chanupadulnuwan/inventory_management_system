using inventryUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1.Controllers
{
    public class PurchaseOrderController
    {
        private List<PurchaseOrder> orders = new List<PurchaseOrder>();
        private int nextId = 1;

        public void AddOrder(string productName, string supplierName, int quantity, DateTime expectedDelivery)
        {
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(supplierName) || quantity <= 0)
            {
                MessageBox.Show("Invalid order details. Please fill all fields properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newOrder = new PurchaseOrder
            {
                OrderId = nextId++,
                ProductName = productName,
                SupplierName = supplierName,
                Quantity = quantity,
                Status = "Pending",
                ExpectedDelivery = expectedDelivery
            };

            orders.Add(newOrder);

            MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Return all orderws
        public List<PurchaseOrder> GetAllOrders()
        {
            return orders;
        }

        //Update order status
        public void UpdateStatus(int orderId, string newStatus)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                order.Status = newStatus;
                MessageBox.Show($"Order #{orderId} marked as '{newStatus}'.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Order not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                orders.Remove(order);
                MessageBox.Show($"Order #{orderId} deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Order not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
