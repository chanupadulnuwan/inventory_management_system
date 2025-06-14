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
            btnBack = new Button(); // ✅ Initialize it here
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();

            // label1
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 25);
            label1.Name = "label1";
            label1.Size = new Size(326, 34);
            label1.TabIndex = 0;
            label1.Text = "Product Management ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;

            // lblName
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(25, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(143, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Product Name";

            // txtName
            txtName.Location = new Point(60, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 27);
            txtName.TabIndex = 2;

            // txtSKU
            txtSKU.Location = new Point(60, 169);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(157, 27);
            txtSKU.TabIndex = 3;

            // txtQty
            txtQty.Location = new Point(60, 252);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(157, 27);
            txtQty.TabIndex = 4;

            // txtPrice
            txtPrice.Location = new Point(60, 327);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(157, 27);
            txtPrice.TabIndex = 5;

            // lblSKU
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU.Location = new Point(34, 133);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(49, 28);
            lblSKU.TabIndex = 6;
            lblSKU.Text = "SKU";

            // lblQty
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(25, 210);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(90, 28);
            lblQty.TabIndex = 7;
            lblQty.Text = "Quantity";

            // lblPrice
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(34, 291);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";

            // btnAdd
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = SystemColors.GradientInactiveCaption;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(294, 403);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 44);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;

            // btnEdit
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = SystemColors.GradientInactiveCaption;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(413, 403);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 44);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit Product";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;

            // btnDelete
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = SystemColors.GradientInactiveCaption;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(545, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 44);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = false;

            // txtSearch
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(399, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(330, 27);
            txtSearch.TabIndex = 12;

            // btnSearch
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = SystemColors.GradientInactiveCaption;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(599, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 39);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;

            // dgvProducts
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.InactiveBorder;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.GridColor = SystemColors.HighlightText;
            dgvProducts.Location = new Point(294, 178);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(435, 203);
            dgvProducts.TabIndex = 14;

            // btnBack
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.Azure;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(726, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 44);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;

            // ProductForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(842, 472);
            Controls.Add(btnBack);
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

        // Public for controller access
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
        public Button btnBack; // ✅ Kept from AppMenu branch
    }
}
