using System;
using System.Windows.Forms;
using inventryUI.Views;
using inventryUI.Presenters;

namespace InventoryUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate View and Presenter
            IProductView view = new ProductForm();
            var presenter = new ProductPresenter(view);

            // Run the form
            Application.Run((Form)view);
        }
    }
}
