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
            dgvStockReport = new DataGridView();
            tabOrderHistory = new TabPage();
            dgvOrderHistory = new DataGridView();
            tabTopItems = new TabPage();
            dgvTopItems = new DataGridView();
            btnBack = new Button();
            tabReports.SuspendLayout();
            tabStockReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).BeginInit();
            tabOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).BeginInit();
            tabTopItems.SuspendLayout();
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
            // dgvStockReport
            // 
            dgvStockReport.AllowUserToAddRows = false;
            dgvStockReport.AllowUserToDeleteRows = false;
            dgvStockReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockReport.BackgroundColor = SystemColors.ActiveCaption;
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
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(692, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 38);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(798, 450);
            Controls.Add(btnBack);
            Controls.Add(tabReports);
            Name = "ReportForm";
            Text = "Reports";
            tabReports.ResumeLayout(false);
            tabStockReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).EndInit();
            tabOrderHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).EndInit();
            tabTopItems.ResumeLayout(false);
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
        private Button btnBack;
    }
}
