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
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);

            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(123, 83);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(440, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(568, 138);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 138);
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
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
