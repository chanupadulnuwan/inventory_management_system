using inventryUI.Controllers;
using Menu;
using System;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class StockForm : Form
    {
        private readonly AppMenuForm _mainMenu;
        private StockController _controller;

        public StockForm(AppMenuForm mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            this.Load += StockForm_Load;
            this.FormClosed += StockForm_FormClosed;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            _controller = new StockController();

            btnIncrease.Click += BtnIncrease_Click;
            btnReduce.Click += BtnReduce_Click;
            btnManualAdjust.Click += BtnManualAdjust_Click;
            btnViewStock.Click += BtnViewStock_Click;
            btnProcessSale.Click += BtnProcessSale_Click;
            btnGenerateInvoice.Click += BtnGenerateInvoice_Click;
            btnBack.Click += BtnBack_Click;

            LoadStockData();
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            if (TryGetInput(out string sku, out int qty))
            {
                _controller.IncreaseStock(sku, qty);
                MessageBox.Show("Stock increased successfully.");
                LoadStockData();
            }
        }

        private void BtnReduce_Click(object sender, EventArgs e)
        {
            if (TryGetInput(out string sku, out int qty))
            {
                _controller.ReduceStock(sku, qty);
                MessageBox.Show("Stock reduced successfully.");
                LoadStockData();
            }
        }

        private void BtnManualAdjust_Click(object sender, EventArgs e)
        {
            if (TryGetInput(out string sku, out int qty))
            {
                _controller.ManualAdjust(sku, qty);
                MessageBox.Show("Stock manually adjusted.");
                LoadStockData();
            }
        }

        private void BtnViewStock_Click(object sender, EventArgs e)
        {
            LoadStockData();
        }

        private void BtnProcessSale_Click(object sender, EventArgs e)
        {
            if (TryGetInput(out string sku, out int qty))
            {
                _controller.ProcessSale(sku, qty);
                MessageBox.Show("Sale processed.");
                LoadStockData();
            }
        }

        private void BtnGenerateInvoice_Click(object sender, EventArgs e)
        {
            string invoiceNumber = Microsoft.VisualBasic.Interaction.InputBox("Enter Invoice Number:", "Invoice Lookup", "");
            if (!string.IsNullOrWhiteSpace(invoiceNumber))
            {
                _controller.GenerateInvoice(invoiceNumber);
                MessageBox.Show("Invoice generated.");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private bool TryGetInput(out string sku, out int qty)
        {
            sku = txtProductId.Text.Trim();
            return int.TryParse(txtQuantity.Text.Trim(), out qty);
        }

        private void LoadStockData()
        {
            dgvStock.DataSource = _controller.GetStockLevels();
        }
    }
}
