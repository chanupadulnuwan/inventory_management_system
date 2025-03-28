using System;
using System.Windows.Forms;
using InventoryManagementSystem.Views;
using InventoryManagementSystem.Presenters;

namespace InventoryManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize View
            IProductView productView = new ProductForm();

            // Initialize Presenter (Pass the view to the presenter)
            _ = new ProductPresenter(productView);

            // Run the application
            Application.Run((Form)productView);
        }
    }
}
