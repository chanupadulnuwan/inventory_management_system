using inventryUI.Controllers;
using Menu;
using System;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class StockForm : Form
    {
        private AppMenuForm _mainMenu;
        private StockController _controller;

        public StockForm(AppMenuForm mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            this.Load += StockForm_Load;
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
            btnBack.Click += btnBack_Click;
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProductId.Text) && int.TryParse(txtQuantity.Text, out int qty))
            {
                _controller.IncreaseStock(txtProductId.Text.Trim(), qty);
                MessageBox.Show("Stock increased successfully.");
                LoadStockData();
            }
        }

        private void BtnReduce_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProductId.Text) && int.TryParse(txtQuantity.Text, out int qty))
            {
                _controller.ReduceStock(txtProductId.Text.Trim(), qty);
                MessageBox.Show("Stock reduced successfully.");
                LoadStockData();
            }
        }

        private void BtnManualAdjust_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProductId.Text) && int.TryParse(txtQuantity.Text, out int newQty))
            {
                _controller.ManualAdjust(txtProductId.Text.Trim(), newQty);
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
            if (!string.IsNullOrWhiteSpace(txtProductId.Text) && int.TryParse(txtQuantity.Text, out int qty))
            {
                _controller.ProcessSale(txtProductId.Text.Trim(), qty);
                MessageBox.Show("Sale processed.");
                LoadStockData();
            }
        }

        private void BtnGenerateInvoice_Click(object sender, EventArgs e)
        {
            string invoiceNumber = Microsoft.VisualBasic.Interaction.InputBox("Enter Invoice Number:", "Invoice Lookup", "");
            if (!string.IsNullOrEmpty(invoiceNumber))
            {
                _controller.GenerateInvoice(invoiceNumber);
                MessageBox.Show("Invoice details fetched.");
            }
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            _mainMenu.Show(); // Show the AppMenu again
            this.Close();     // Close the StockForm
        }

        private void LoadStockData()
        {
            dgvStock.DataSource = _controller.GetStockLevels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // You can remove this if unused
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
