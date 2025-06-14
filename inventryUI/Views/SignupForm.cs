using inventryUI.Controllers;
using inventryUI.Models;
using System;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class SignupForm : Form
    {
        private readonly UserController _controller;

        public SignupForm()
        {
            InitializeComponent();
            _controller = new UserController(this);

            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "User", "Supplier" });
            cmbRole.SelectedIndex = 0;

            btnSignup.Click += BtnSignup_Click;
            btnBackToLogin.Click += BtnBackToLogin_Click;
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string fullName = txtFullName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string role = cmbRole.SelectedItem?.ToString()?.Trim();

                if (string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(fullName) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = new User
                {
                    Username = username,
                    FullName = fullName,
                    Password = password,
                    Role = role
                };

                bool success = _controller.AddUser(user);

                if (success)
                {
                    MessageBox.Show("Signup successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset fields
                    txtUsername.Clear();
                    txtFullName.Clear();
                    txtPassword.Clear();
                    cmbRole.SelectedIndex = 0;

                    this.Hide();
                    new LoginForm().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error during signup:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        public void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}
