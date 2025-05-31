using inventryUI;
using Menu; // Namespace for AppMenuForm
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

            // Optional: Set user role manually for now if login isn't implemented yet
            Session.CurrentUserRole = "Admin"; // or "User"

            Application.Run(new AppMenuForm());
        }
    }
}
