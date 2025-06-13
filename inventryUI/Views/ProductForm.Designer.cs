namespace inventryUI.Views
{
    partial class ProductForm
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
            lblName = new Label();
            txtName = new TextBox();
            txtSKU = new TextBox();
            txtQty = new TextBox();
            txtPrice = new TextBox();
            lblSKU = new Label();
            lblQty = new Label();
            lblPrice = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Product Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(60, 169);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(125, 27);
            txtSKU.TabIndex = 3;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(60, 252);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(125, 27);
            txtQty.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(60, 327);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Location = new Point(25, 130);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(36, 20);
            lblSKU.TabIndex = 6;
            lblSKU.Text = "SKU";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(25, 210);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(65, 20);
            lblQty.TabIndex = 7;
            lblQty.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(34, 291);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(218, 382);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(337, 382);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit Product";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(437, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(311, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(269, 27);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(486, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(280, 178);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(300, 188);
            dgvProducts.TabIndex = 14;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lblPrice);
            Controls.Add(lblQty);
            Controls.Add(lblSKU);
            Controls.Add(txtPrice);
            Controls.Add(txtQty);
            Controls.Add(txtSKU);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ✅ Now public for MVC controller access
        public Label label1;
        public Label lblName;
        public TextBox txtName;
        public TextBox txtSKU;
        public TextBox txtQty;
        public TextBox txtPrice;
        public Label lblSKU;
        public Label lblQty;
        public Label lblPrice;
        public Button btnAdd;
        public Button btnEdit;
        public Button btnDelete;
        public TextBox txtSearch;
        public Button btnSearch;
        public DataGridView dgvProducts;

    }
}
