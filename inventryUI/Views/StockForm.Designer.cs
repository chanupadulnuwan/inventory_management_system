namespace inventryUI.Views
{
    partial class StockForm
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
            txtProductId = new TextBox();
            txtQuantity = new TextBox();
            dgvStock = new DataGridView();
            btnIncrease = new Button();
            btnReduce = new Button();
            btnManualAdjust = new Button();
            btnViewStock = new Button();
            btnProcessSale = new Button();
            btnGenerateInvoice = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(850, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Management";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(50, 60);
            txtProductId.Name = "txtProductId";
            txtProductId.PlaceholderText = "Product SKU";
            txtProductId.Size = new Size(200, 27);
            txtProductId.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(50, 100);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Quantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 2;
            // 
            // dgvStock
            // 
            dgvStock.BackgroundColor = SystemColors.InactiveCaption;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(300, 60);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(437, 340);
            dgvStock.TabIndex = 3;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(50, 150);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(100, 30);
            btnIncrease.TabIndex = 4;
            btnIncrease.Text = "Increase";
            // 
            // btnReduce
            // 
            btnReduce.Location = new Point(160, 150);
            btnReduce.Name = "btnReduce";
            btnReduce.Size = new Size(100, 30);
            btnReduce.TabIndex = 5;
            btnReduce.Text = "Reduce";
            // 
            // btnManualAdjust
            // 
            btnManualAdjust.Location = new Point(50, 190);
            btnManualAdjust.Name = "btnManualAdjust";
            btnManualAdjust.Size = new Size(100, 30);
            btnManualAdjust.TabIndex = 6;
            btnManualAdjust.Text = "Adjust";
            // 
            // btnViewStock
            // 
            btnViewStock.Location = new Point(160, 190);
            btnViewStock.Name = "btnViewStock";
            btnViewStock.Size = new Size(100, 30);
            btnViewStock.TabIndex = 7;
            btnViewStock.Text = "View Stock";
            // 
            // btnProcessSale
            // 
            btnProcessSale.Location = new Point(50, 230);
            btnProcessSale.Name = "btnProcessSale";
            btnProcessSale.Size = new Size(100, 30);
            btnProcessSale.TabIndex = 8;
            btnProcessSale.Text = "Process Sale";
            // 
            // btnGenerateInvoice
            // 
            btnGenerateInvoice.Location = new Point(160, 230);
            btnGenerateInvoice.Name = "btnGenerateInvoice";
            btnGenerateInvoice.Size = new Size(100, 30);
            btnGenerateInvoice.TabIndex = 9;
            btnGenerateInvoice.Text = "Invoice";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(50, 270);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(210, 30);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            // 
            // StockForm
            // 
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(850, 480);
            Controls.Add(lblTitle);
            Controls.Add(txtProductId);
            Controls.Add(txtQuantity);
            Controls.Add(dgvStock);
            Controls.Add(btnIncrease);
            Controls.Add(btnReduce);
            Controls.Add(btnManualAdjust);
            Controls.Add(btnViewStock);
            Controls.Add(btnProcessSale);
            Controls.Add(btnGenerateInvoice);
            Controls.Add(btnBack);
            Name = "StockForm";
            Text = "Stock Management";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnManualAdjust;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnProcessSale;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.Button btnBack;
    }
}
