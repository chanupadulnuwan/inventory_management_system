namespace inventryUI.Views
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblUsername;
        private Label lblFullName;
        private Label lblPassword;

        public TextBox txtUsername;  // Changed from private → public
        public TextBox txtFullName;  // Changed from private → public
        public TextBox txtPassword;  // Changed from private → public

        private Button btnEdit;
        private Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new Label();
            this.lblFullName = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtFullName = new TextBox();
            this.txtPassword = new TextBox();
            this.btnEdit = new Button();
            this.btnDelete = new Button();

            this.SuspendLayout();

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(100, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(78, 20);
            lblUsername.Text = "Username";

            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(100, 120);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(76, 20);
            lblFullName.Text = "Full Name";

            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(100, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(70, 20);
            lblPassword.Text = "Password";

            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(200, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(300, 27);

            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(200, 117);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(300, 27);

            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(200, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(300, 27);
            txtPassword.UseSystemPasswordChar = true;

            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(200, 240);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(120, 40);
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = true;

            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(380, 240);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(120, 40);
            btnDelete.Text = "Delete Account";
            btnDelete.UseVisualStyleBackColor = true;

            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(lblUsername);
            this.Controls.Add(lblFullName);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtFullName);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnDelete);
            this.Name = "UserForm";
            this.Text = "User Profile";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
