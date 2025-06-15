using System.Windows.Forms;
using inventryUI;
using inventryUI.Views;
using Menu;
using WinFormsApp1;

namespace inventryUI.Controllers
{
    public class AppMenuController
    {
        private readonly AppMenuForm _view;

        public AppMenuController(AppMenuForm view)
        {
            _view = view;
        }

        public void OpenProductForm()
        {
            if (Session.CurrentUserRole == "Admin" || Session.CurrentUserRole == "User")
            {
                var form = new ProductForm(_view);
                _view.Hide();
                form.ShowDialog();
                _view.Show();
            }
            else
            {
                ShowRestrictedMessage("Product Management");
            }
        }

        public void OpenReportForm()
        {
            var form = new ReportForm(_view); // ✅ Accessible to all roles
            _view.Hide();
            form.ShowDialog();
            _view.Show();
        }

        public void OpenSupplierForm()
        {
            if (Session.CurrentUserRole == "Admin" || Session.CurrentUserRole == "Supplier")
            {
                var form = new SupplierForm(_view);
                _view.Hide();
                form.ShowDialog();
                _view.Show();
            }
            else
            {
                ShowRestrictedMessage("Supplier Management");
            }
        }

        public void OpenPurchaseOrderForm()
        {
            if (Session.CurrentUserRole == "Admin" || Session.CurrentUserRole == "User")
            {
                var form = new PurchaseOrderForm();
                form.ShowDialog();
            }
            else
            {
                ShowRestrictedMessage("Purchase Orders");
            }
        }

        public void OpenStockForm()
        {
            if (Session.CurrentUserRole == "Admin" || Session.CurrentUserRole == "User")
            {
                var form = new StockForm(_view);
                _view.Hide();
                form.ShowDialog();
                _view.Show();
            }
            else
            {
                ShowRestrictedMessage("Stock Tracking");
            }
        }

        private void ShowRestrictedMessage(string moduleName)
        {
            MessageBox.Show(
                $"You do not have permission to access the {moduleName} module.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}
