using inventryUI;
using inventryUI.Controllers;
using inventryUI.Views;
using Menu;
using System;
using System.Windows.Forms;

namespace InventoryUI
{
    static class Program
    {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                var mainForm = new AppMenuForm();
                var controller = new AppMenuController(mainForm);

            // Optional: Set user role manually for now - login isn't implemented yet
            Session.CurrentUserRole = "Admin"; 


                Application.Run(mainForm);
            }
    }
}