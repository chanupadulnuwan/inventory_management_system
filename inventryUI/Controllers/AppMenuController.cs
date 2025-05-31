using inventryUI.Views;
using Menu;
using System.Windows.Forms;

namespace inventryUI.Controllers
{
    public class AppMenuController
    {
        private readonly AppMenuForm _view;

        public AppMenuController(AppMenuForm view)
        {
            _view = view;

            // Wire up events directly from the form
            _view.btnManageProducts.Click += (s, e) => OpenProductForm();
            _view.btnReports.Click += (s, e) => OpenReportForm();
            _view.btnPurchases.Click += (s, e) => ShowNotImplemented("Purchases");
            _view.btnSuppliers.Click += (s, e) => ShowNotImplemented("Suppliers");
            _view.btnBackup.Click += (s, e) => ShowNotImplemented("Backup");
            _view.btnStockTracking.Click += (s, e) => ShowNotImplemented("Stock Tracking");
        }

        private void OpenProductForm()
        {
            var productForm = new ProductForm();
            productForm.ShowDialog(_view);
        }

        private void OpenReportForm()
        {
            var reportForm = new ReportForm();
            reportForm.ShowDialog(_view);
        }

        private void ShowNotImplemented(string featureName)
        {
            MessageBox.Show($"{featureName} feature not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
