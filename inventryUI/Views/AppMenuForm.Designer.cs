using inventryUI.Views;

namespace Menu
{
    partial class AppMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            lblUserRole = new Label();
            btnManageProducts = new Button();
            btnUser = new Button();
            btnSuppliers = new Button();
            btnPurchases = new Button();
            btnStockTracking = new Button();
            btnReports = new Button();
            btnBackup = new Button();
            btnLogout = new Button();
            btnNotification = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 13);
            label1.Name = "label1";
            label1.Size = new Size(216, 39);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            label1.Click += label1_Click;
            // 
            // lblUserRole
            // 
            lblUserRole.Location = new Point(0, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(100, 23);
            lblUserRole.TabIndex = 10;
            // 
            // btnManageProducts
            // 
            btnManageProducts.Location = new Point(304, 108);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(174, 29);
            btnManageProducts.TabIndex = 2;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(592, 46);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(174, 29);
            btnUser.TabIndex = 0;
            btnUser.Text = "User Profile";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUserProfile_Click; // ✅ Corrected event binding
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(304, 154);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(174, 29);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnPurchases
            // 
            btnPurchases.Location = new Point(304, 202);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(174, 29);
            btnPurchases.TabIndex = 4;
            btnPurchases.Text = "Purchases and Orders";
            btnPurchases.UseVisualStyleBackColor = true;
            btnPurchases.Click += btnPurchases_Click;
            // 
            // btnStockTracking
            // 
            btnStockTracking.Location = new Point(304, 251);
            btnStockTracking.Name = "btnStockTracking";
            btnStockTracking.Size = new Size(174, 29);
            btnStockTracking.TabIndex = 5;
            btnStockTracking.Text = "Stock Tracking";
            btnStockTracking.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(304, 305);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(174, 29);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(304, 352);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(174, 29);
            btnBackup.TabIndex = 7;
            btnBackup.Text = "Backup and Settings";
            btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(672, 385);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnNotification
            // 
            btnNotification.Location = new Point(12, 46);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(174, 29);
            btnNotification.TabIndex = 9;
            btnNotification.Text = "🔔 Notifications";
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // AppMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNotification);
            Controls.Add(btnLogout);
            Controls.Add(btnBackup);
            Controls.Add(btnReports);
            Controls.Add(btnStockTracking);
            Controls.Add(btnPurchases);
            Controls.Add(btnSuppliers);
            Controls.Add(btnManageProducts);
            Controls.Add(btnUser);
            Controls.Add(lblUserRole);
            Controls.Add(label1);
            Name = "AppMenuForm";
            Text = "Application Menu";
            Load += AppMenuForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show(); // ✅ Working User Profile form
        }

        #endregion

        public Label label1;
        public Label lblUserRole;
        public Button btnManageProducts;
        public Button btnSuppliers;
        public Button btnPurchases;
        public Button btnStockTracking;
        public Button btnReports;
        public Button btnBackup;
        public Button btnLogout;
        public Button btnNotification;
        public Button btnUser;
    }
}
