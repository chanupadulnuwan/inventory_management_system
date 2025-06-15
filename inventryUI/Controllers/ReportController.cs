using System;
using System.Data;
using System.Windows.Forms;
using inventryUI.Views;
using MySql.Data.MySqlClient;

namespace inventryUI.Controllers
{
    public class ReportController
    {
        private readonly ReportForm _view;

        public ReportController(ReportForm view)
        {
            _view = view;
            _view.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            try
            {
                _view.dgvStockReport.DataSource = GetStockReport();
                _view.dgvOrderHistory.DataSource = GetOrderHistory();
                _view.dgvTopItems.DataSource = GetTopOrderedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"❌ Error loading report data:\n{ex.Message}",
                    "Load Failure",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public DataTable GetStockReport()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT SKU, ProductName, Quantity, Price FROM products";
                var adapter = new MySqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetOrderHistory()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        id AS OrderID, 
                        product_sku AS SKU, 
                        quantity_sold AS Quantity, 
                        sale_date AS Date 
                    FROM sales 
                    ORDER BY sale_date DESC";

                var adapter = new MySqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetTopOrderedItems()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = @"
                        SELECT 
                            p.ProductName, 
                            SUM(s.quantity_sold) AS OrderedCount
                        FROM sales s
                        JOIN products p ON s.product_sku = p.SKU
                        GROUP BY s.product_sku
                        ORDER BY OrderedCount DESC
                        LIMIT 5";

                    var adapter = new MySqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load top ordered items:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable(); // ✅ Ensure it always returns
            }
        }
    }
}
