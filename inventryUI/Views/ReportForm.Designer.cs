namespace inventryUI.Views
{
    partial class ReportForm
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
            tabReports = new TabControl();
            tabStockReport = new TabPage();
            tabOrderHistory = new TabPage();
            tabTopItems = new TabPage();
            dgvStockReport = new DataGridView();
            dgvOrderHistory = new DataGridView();
            dgvTopItems = new DataGridView();
            tabReports.SuspendLayout();
            tabStockReport.SuspendLayout();
            tabOrderHistory.SuspendLayout();
            tabTopItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopItems).BeginInit();
            SuspendLayout();
            // 
            // tabReports
            // 
            tabReports.Controls.Add(tabStockReport);
            tabReports.Controls.Add(tabOrderHistory);
            tabReports.Controls.Add(tabTopItems);
            tabReports.Location = new Point(22, 66);
            tabReports.Name = "tabReports";
            tabReports.SelectedIndex = 0;
            tabReports.Size = new Size(686, 329);
            tabReports.TabIndex = 0;
            // 
            // tabStockReport
            // 
            tabStockReport.Controls.Add(dgvStockReport);
            tabStockReport.Location = new Point(4, 29);
            tabStockReport.Name = "tabStockReport";
            tabStockReport.Padding = new Padding(3);
            tabStockReport.Size = new Size(678, 296);
            tabStockReport.TabIndex = 0;
            tabStockReport.Text = "Stock Report";
            tabStockReport.UseVisualStyleBackColor = true;
            // 
            // tabOrderHistory
            // 
            tabOrderHistory.Controls.Add(dgvOrderHistory);
            tabOrderHistory.Location = new Point(4, 29);
            tabOrderHistory.Name = "tabOrderHistory";
            tabOrderHistory.Padding = new Padding(3);
            tabOrderHistory.Size = new Size(678, 296);
            tabOrderHistory.TabIndex = 1;
            tabOrderHistory.Text = "Order History";
            tabOrderHistory.UseVisualStyleBackColor = true;
            // 
            // tabTopItems
            // 
            tabTopItems.Controls.Add(dgvTopItems);
            tabTopItems.Location = new Point(4, 29);
            tabTopItems.Name = "tabTopItems";
            tabTopItems.Size = new Size(678, 296);
            tabTopItems.TabIndex = 2;
            tabTopItems.Text = "Top Ordered Items";
            tabTopItems.UseVisualStyleBackColor = true;
            // 
            // dgvStockReport
            // 
            dgvStockReport.AllowUserToAddRows = false;
            dgvStockReport.AllowUserToDeleteRows = false;
            dgvStockReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockReport.Location = new Point(6, 6);
            dgvStockReport.Name = "dgvStockReport";
            dgvStockReport.ReadOnly = true;
            dgvStockReport.RowHeadersVisible = false;
            dgvStockReport.RowHeadersWidth = 51;
            dgvStockReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockReport.Size = new Size(666, 284);
            dgvStockReport.TabIndex = 0;
            // 
            // dgvOrderHistory
            // 
            dgvOrderHistory.AllowUserToAddRows = false;
            dgvOrderHistory.AllowUserToDeleteRows = false;
            dgvOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderHistory.Location = new Point(6, 6);
            dgvOrderHistory.Name = "dgvOrderHistory";
            dgvOrderHistory.ReadOnly = true;
            dgvOrderHistory.RowHeadersVisible = false;
            dgvOrderHistory.RowHeadersWidth = 51;
            dgvOrderHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderHistory.Size = new Size(666, 284);
            dgvOrderHistory.TabIndex = 0;
            // 
            // dgvTopItems
            // 
            dgvTopItems.AllowUserToAddRows = false;
            dgvTopItems.AllowUserToDeleteRows = false;
            dgvTopItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopItems.Location = new Point(3, 3);
            dgvTopItems.Name = "dgvTopItems";
            dgvTopItems.ReadOnly = true;
            dgvTopItems.RowHeadersVisible = false;
            dgvTopItems.RowHeadersWidth = 51;
            dgvTopItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTopItems.Size = new Size(659, 290);
            dgvTopItems.TabIndex = 0;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabReports);
            Name = "ReportForm";
            Text = "Reports";
            tabReports.ResumeLayout(false);
            tabStockReport.ResumeLayout(false);
            tabOrderHistory.ResumeLayout(false);
            tabTopItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ✅ Made public for Controller access
        public TabControl tabReports;
        public TabPage tabStockReport;
        public TabPage tabOrderHistory;
        public TabPage tabTopItems;
        public DataGridView dgvStockReport;
        public DataGridView dgvOrderHistory;
        public DataGridView dgvTopItems;
    }
}
