namespace inventryUI.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        internal TextBox txtUsername;
        internal TextBox txtPassword;
        internal Button btnLogin;
        private Label label3;
        private Button btnSignup;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(217, 207);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(224, 272);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(365, 207);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(365, 276);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(541, 343);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 41);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(454, 628);
            label3.Name = "label3";
            label3.Size = new Size(223, 28);
            label3.TabIndex = 0;
            label3.Text = "Don't have an account?";
            label3.Click += label3_Click;
            // 
            // btnSignup
            // 
            btnSignup.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSignup.Location = new Point(699, 618);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(178, 49);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Sign Up";
            btnSignup.Click += btnSignup_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(902, 689);
            Controls.Add(btnSignup);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}