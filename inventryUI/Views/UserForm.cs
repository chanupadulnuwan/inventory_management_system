using inventryUI.Controllers;
using System;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class UserForm : Form
    {
        private UserController _controller;

        public UserForm()
        {
            InitializeComponent();
            _controller = new UserController(this);

            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click += BtnEdit_Click;

            _controller.LoadUserProfile(); // Auto load on open
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int currentUserID = Session.CurrentUserId;

            if (currentUserID != 0)
            {
                DialogResult confirm = ShowMessage(
                    "Are you sure you want to delete your account? This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    bool success = _controller.DeleteUser(currentUserID);
                    if (success)
                    {
                        ShowMessage("Account deleted. Application will close.", "Success", MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
            else
            {
                ShowMessage("No user ID found to delete.", "Error", MessageBoxIcon.Warning);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int currentUserID = Session.CurrentUserId;

            if (currentUserID != 0)
            {
                bool success = _controller.UpdateUser(
                    currentUserID,
                    txtUsername.Text.Trim(),
                    txtFullName.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (success)
                {
                    ShowMessage("Profile updated successfully.", "Success", MessageBoxIcon.Information);
                }
            }
            else
            {
                ShowMessage("No user ID found to update.", "Error", MessageBoxIcon.Warning);
            }
        }

        public DialogResult ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }

        public void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}
