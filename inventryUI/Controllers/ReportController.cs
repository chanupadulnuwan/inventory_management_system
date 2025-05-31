using System;
using System.Collections.Generic;
using System.Windows.Forms;
using inventryUI.Views;

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
                // Dummy Data – Replace with DB logic in future
                var stockReport = new List<dynamic>
                {
                    new { Product = "Item A", Quantity = 20 },
                    new { Product = "Item B", Quantity = 5 }
                };

                var orderHistory = new List<dynamic>
                {
                    new { OrderID = "ORD001", Date = DateTime.Today, Item = "Item A", Qty = 2 },
                    new { OrderID = "ORD002", Date = DateTime.Today.AddDays(-1), Item = "Item B", Qty = 3 }
                };

                var topItems = new List<dynamic>
                {
                    new { Product = "Item A", OrderedCount = 10 },
                    new { Product = "Item B", OrderedCount = 7 }
                };

                _view.dgvStockReport.DataSource = stockReport;
                _view.dgvOrderHistory.DataSource = orderHistory;
                _view.dgvTopItems.DataSource = topItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
