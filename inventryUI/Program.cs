using inventryUI;
using inventryUI.Views;
using System;
using System.Windows.Forms;

namespace inventryUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test database connection
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed:\n{ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Launch login form
            Application.Run(new LoginForm());

            // Optional fallback (will not be reached after Application.Run)
            // Session.CurrentUserRole = "Admin";
        }
    }
}
