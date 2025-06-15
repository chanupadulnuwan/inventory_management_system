namespace inventryUI.Views
{
    partial class SupplierForm
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
            txtName = new TextBox();
            txtContact = new TextBox();
            textProduct = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvSuppliers = new DataGridView();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(850, 40);
            label1.TabIndex = 0;
            label1.Text = "Supplier Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 1;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(40, 100);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(220, 27);
            txtContact.TabIndex = 2;
            // 
            // textProduct
            // 
            textProduct.Location = new Point(40, 140);
            textProduct.Name = "textProduct";
            textProduct.PlaceholderText = "Product";
            textProduct.Size = new Size(220, 27);
            textProduct.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(300, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name or product";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(40, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(160, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(100, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(620, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 27);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = SystemColors.InactiveCaption;
            dgvSuppliers.ColumnHeadersHeight = 29;
            dgvSuppliers.Location = new Point(300, 100);
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(442, 250);
            dgvSuppliers.TabIndex = 9;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(40, 280);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(220, 30);
            backbtn.TabIndex = 10;
            backbtn.Text = "Back";
            // 
            // SupplierForm
            // 
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(850, 506);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtContact);
            Controls.Add(textProduct);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(dgvSuppliers);
            Controls.Add(backbtn);
            Name = "SupplierForm";
            Text = "Supplier Management";
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox textProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView dgvSuppliers;
    }
}
