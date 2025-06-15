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
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 21);
            label1.Name = "label1";
            label1.Size = new Size(284, 52);
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
            btnManageProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnManageProducts.Location = new Point(350, 192);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(253, 40);
            btnManageProducts.TabIndex = 2;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUser.Location = new Point(27, 43);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(114, 39);
            btnUser.TabIndex = 0;
            btnUser.Text = "Profile";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSuppliers.Location = new Point(350, 252);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(253, 46);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnPurchases
            // 
            btnPurchases.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPurchases.Location = new Point(350, 470);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(253, 50);
            btnPurchases.TabIndex = 4;
            btnPurchases.Text = "Purchases and Orders";
            btnPurchases.UseVisualStyleBackColor = true;
            // 
            // btnStockTracking
            // 
            btnStockTracking.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnStockTracking.Location = new Point(350, 324);
            btnStockTracking.Name = "btnStockTracking";
            btnStockTracking.Size = new Size(253, 49);
            btnStockTracking.TabIndex = 5;
            btnStockTracking.Text = "Stock Tracking";
            btnStockTracking.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnReports.Location = new Point(350, 395);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(253, 45);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogout.Location = new Point(27, 576);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 53);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // AppMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(987, 677);
            Controls.Add(btnLogout);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label lblUserRole;
        public Button btnManageProducts;
        public Button btnSuppliers;
        public Button btnPurchases;
        public Button btnStockTracking;
        public Button btnReports;
        public Button btnLogout;
        public Button btnUser;
    }
}
