namespace inventryUI.Views

{
    partial class SupplierForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtContact = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvSuppliers = new DataGridView();
            lblName = new Label();
            lblContact = new Label();
            backbtn = new Button();
            LabelProduct = new Label();
            textProduct = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(123, 83);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 1;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(397, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(532, 138);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(669, 138);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(256, 173);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(532, 257);
            dgvSuppliers.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(23, 90);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(93, 20);
            lblContact.TabIndex = 7;
            lblContact.Text = "Contact Info:";
            // 
            // backbtn
            // 
            backbtn.Location = new Point(694, 21);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(94, 29);
            backbtn.TabIndex = 8;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // LabelProduct
            // 
            LabelProduct.AutoSize = true;
            LabelProduct.Location = new Point(23, 138);
            LabelProduct.Name = "LabelProduct";
            LabelProduct.Size = new Size(60, 20);
            LabelProduct.TabIndex = 9;
            LabelProduct.Text = "Product";
            // 
            // textProduct
            // 
            textProduct.Location = new Point(123, 135);
            textProduct.Name = "textProduct";
            textProduct.Size = new Size(125, 27);
            textProduct.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(512, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(669, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(textProduct);
            Controls.Add(LabelProduct);
            Controls.Add(backbtn);
            Controls.Add(lblContact);
            Controls.Add(lblName);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Name = "SupplierForm";
            Text = "Supplier Management";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtContact;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvSuppliers;
        private Label lblName;
        private Label lblContact;
        private Button backbtn;
        private Label LabelProduct;
        private TextBox textProduct;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
