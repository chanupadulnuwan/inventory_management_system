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

                Application.Run(mainForm);
            }
    }
}