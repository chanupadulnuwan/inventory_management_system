using inventryUI.Controllers;
using Menu;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a temporary controller (no view needed for login check)
            var controller = new UserController(viewSign: null);

            bool loginSuccess = controller.LoginValid(username, password);

            if (loginSuccess)
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Hide login form first

                var appMenu = new AppMenuForm();
                appMenu.StartPosition = FormStartPosition.CenterScreen;
                appMenu.Size = new Size(800, 600);
                appMenu.ShowDialog(); // Wait until app menu is closed

                this.Close(); // Properly close login after main app ends
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();

            var signupForm = new SignupForm();
            signupForm.StartPosition = FormStartPosition.CenterScreen;
            signupForm.Size = new Size(800, 600);
            signupForm.ShowDialog();

            this.Show(); // Show login again if signup form closes
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
