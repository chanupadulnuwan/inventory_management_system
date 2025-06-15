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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(294, 179);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(294, 233);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(294, 282);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 8;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(326, 329);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 7;
            label4.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(431, 179);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(431, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(431, 283);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(270, 27);
            txtFullName.TabIndex = 4;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "User", "Supplier" });
            cmbRole.Location = new Point(431, 329);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(270, 28);
            cmbRole.TabIndex = 3;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.GradientInactiveCaption;
            btnSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSignup.Location = new Point(451, 404);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(114, 42);
            btnSignup.TabIndex = 2;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += BtnSignup_Click;
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBackToLogin.Location = new Point(501, 610);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(242, 28);
            lblBackToLogin.TabIndex = 1;
            lblBackToLogin.Text = "Already have an account?";
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBackToLogin.BackColor = SystemColors.GradientInactiveCaption;
            btnBackToLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBackToLogin.Location = new Point(762, 603);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(190, 42);
            btnBackToLogin.TabIndex = 0;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += BtnBackToLogin_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(995, 702);
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
