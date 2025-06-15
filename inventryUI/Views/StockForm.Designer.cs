using System;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class StockForm : Form
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
            lblTitle = new Label();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnIncrease = new Button();
            btnReduce = new Button();
            btnManualAdjust = new Button();
            btnProcessSale = new Button();
            btnGenerateInvoice = new Button();
            dgvStock = new DataGridView();
            btnViewStock = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(280, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Management and Tracking";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblProductId.Location = new Point(50, 88);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(114, 28);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(150, 88);
            txtProductId.Margin = new Padding(3, 4, 3, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 27);
            txtProductId.TabIndex = 2;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuantity.Location = new Point(280, 88);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 28);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(350, 88);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 27);
            txtQuantity.TabIndex = 4;
            // 
            // btnIncrease
            // 
            btnIncrease.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnIncrease.Location = new Point(29, 227);
            btnIncrease.Margin = new Padding(3, 4, 3, 4);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(135, 44);
            btnIncrease.TabIndex = 7;
            btnIncrease.Text = "Increase Stock";
            // 
            // btnReduce
            // 
            btnReduce.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnReduce.Location = new Point(29, 299);
            btnReduce.Margin = new Padding(3, 4, 3, 4);
            btnReduce.Name = "btnReduce";
            btnReduce.Size = new Size(135, 46);
            btnReduce.TabIndex = 8;
            btnReduce.Text = "Reduce Stock";
            // 
            // btnManualAdjust
            // 
            btnManualAdjust.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnManualAdjust.Location = new Point(29, 372);
            btnManualAdjust.Margin = new Padding(3, 4, 3, 4);
            btnManualAdjust.Name = "btnManualAdjust";
            btnManualAdjust.Size = new Size(135, 44);
            btnManualAdjust.TabIndex = 9;
            btnManualAdjust.Text = "Manual Adjust";
            // 
            // btnProcessSale
            // 
            btnProcessSale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnProcessSale.Location = new Point(192, 143);
            btnProcessSale.Margin = new Padding(3, 4, 3, 4);
            btnProcessSale.Name = "btnProcessSale";
            btnProcessSale.Size = new Size(143, 49);
            btnProcessSale.TabIndex = 10;
            btnProcessSale.Text = "Process Sale";
            // 
            // btnGenerateInvoice
            // 
            btnGenerateInvoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGenerateInvoice.Location = new Point(29, 436);
            btnGenerateInvoice.Margin = new Padding(3, 4, 3, 4);
            btnGenerateInvoice.Name = "btnGenerateInvoice";
            btnGenerateInvoice.Size = new Size(135, 45);
            btnGenerateInvoice.TabIndex = 11;
            btnGenerateInvoice.Text = "Generate Invoice";
            // 
            // dgvStock
            // 
            dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = SystemColors.Menu;
            dgvStock.ColumnHeadersHeight = 29;
            dgvStock.Location = new Point(192, 200);
            dgvStock.Margin = new Padding(3, 4, 3, 4);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(700, 375);
            dgvStock.TabIndex = 13;
            // 
            // btnViewStock
            // 
            btnViewStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewStock.BackColor = Color.AliceBlue;
            btnViewStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnViewStock.Location = new Point(740, 150);
            btnViewStock.Name = "btnViewStock";
            btnViewStock.Size = new Size(152, 43);
            btnViewStock.TabIndex = 14;
            btnViewStock.Text = "View Stock";
            btnViewStock.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.AliceBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.Location = new Point(798, 59);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(939, 588);
            Controls.Add(btnBack);
            Controls.Add(btnViewStock);
            Controls.Add(lblTitle);
            Controls.Add(lblProductId);
            Controls.Add(txtProductId);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(btnIncrease);
            Controls.Add(btnReduce);
            Controls.Add(btnManualAdjust);
            Controls.Add(btnProcessSale);
            Controls.Add(btnGenerateInvoice);
            Controls.Add(dgvStock);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StockForm";
            Text = "Stock Management";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnManualAdjust;
        private System.Windows.Forms.Button btnProcessSale;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.DataGridView dgvStock;
        private Button btnViewStock;
        private System.Windows.Forms.Button btnBack;

    }
}
