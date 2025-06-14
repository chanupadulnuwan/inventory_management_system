namespace inventryUI.Views
{
    partial class SignupForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            cmbRole = new ComboBox();
            btnSignup = new Button();
            lblBackToLogin = new Label();
            btnBackToLogin = new Button();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(253, 54);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.Text = "Username";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(253, 97);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.Text = "Password";

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(253, 140);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.Text = "Full Name";

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(253, 183);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.Text = "Role";

            // txtUsername
            txtUsername.Location = new Point(340, 51);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 27);

            // txtPassword
            txtPassword.Location = new Point(340, 94);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 27);
            txtPassword.UseSystemPasswordChar = true;

            // txtFullName
            txtFullName.Location = new Point(340, 137);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(270, 27);

            // cmbRole
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Location = new Point(340, 180);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(270, 28);
            cmbRole.Items.AddRange(new object[] { "User", "Supplier" });

            // btnSignup
            btnSignup.Location = new Point(371, 226);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(94, 29);
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += new System.EventHandler(this.BtnSignup_Click);

            // lblBackToLogin
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Location = new Point(165, 280);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(163, 20);
            lblBackToLogin.Text = "Already have an account?";

            // btnBackToLogin
            btnBackToLogin.Location = new Point(340, 275);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(130, 29);
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += new System.EventHandler(this.BtnBackToLogin_Click);

            // SignupForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackToLogin);
            Controls.Add(lblBackToLogin);
            Controls.Add(btnSignup);
            Controls.Add(cmbRole);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public TextBox txtUsername;
        public TextBox txtPassword;
        public TextBox txtFullName;
        public ComboBox cmbRole;
        public Button btnSignup;
        public Label lblBackToLogin;
        public Button btnBackToLogin;
    }
}
