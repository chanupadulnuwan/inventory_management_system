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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(69, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(69, 301);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 1;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(512, 453);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(645, 453);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 46);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(773, 453);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSuppliers.BackgroundColor = SystemColors.InactiveBorder;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.GridColor = SystemColors.InactiveCaptionText;
            dgvSuppliers.Location = new Point(335, 167);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(532, 257);
            dgvSuppliers.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.Location = new Point(23, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 28);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblContact.Location = new Point(23, 153);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(129, 28);
            lblContact.TabIndex = 7;
            lblContact.Text = "Contact Info:";
            // 
            // backbtn
            // 
            backbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            backbtn.Location = new Point(773, 12);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(94, 35);
            backbtn.TabIndex = 8;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // LabelProduct
            // 
            LabelProduct.AutoSize = true;
            LabelProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LabelProduct.Location = new Point(23, 259);
            LabelProduct.Name = "LabelProduct";
            LabelProduct.Size = new Size(83, 28);
            LabelProduct.TabIndex = 9;
            LabelProduct.Text = "Product";
            // 
            // textProduct
            // 
            textProduct.Location = new Point(69, 202);
            textProduct.Name = "textProduct";
            textProduct.Size = new Size(125, 27);
            textProduct.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(554, 112);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(188, 27);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(773, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 38);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 34);
            label1.TabIndex = 13;
            label1.Text = "Supplier Management";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(898, 529);
            Controls.Add(label1);
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
        private Label label1;
    }
}
