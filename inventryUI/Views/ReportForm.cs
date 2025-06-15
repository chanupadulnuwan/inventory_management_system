using System;
using System.Windows.Forms;
using inventryUI.Controllers;
using Menu; // For AppMenuForm reference

namespace inventryUI.Views
{
    public partial class ReportForm : Form
    {
        private readonly ReportController _controller;
        private readonly AppMenuForm _mainMenu;

        // DataGridViews (should match controller expectations)
        public DataGridView dgvStockReport { get; private set; }
        public DataGridView dgvOrderHistory { get; private set; }
        public DataGridView dgvTopItems { get; private set; }

        private Button btnBack;
        private TabControl tabControl;

        public ReportForm(AppMenuForm mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
            _controller = new ReportController(this);

            // Setup form properties
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 600);
            this.Text = "Reports & Analytics";

            // Initialize UI
            InitializeUI();

            // Events
            this.FormClosed += ReportForm_FormClosed;
            btnBack.Click += btnBack_Click;
        }

        private void InitializeUI()
        {
            // Back Button
            btnBack = new Button
            {
                Text = "Back",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(70, 30)
            };
            this.Controls.Add(btnBack);

            // Tab Control
            tabControl = new TabControl
            {
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(760, 500)
            };

            // Stock Report Tab
            var tabStock = new TabPage("Stock Report");
            dgvStockReport = new DataGridView { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            tabStock.Controls.Add(dgvStockReport);

            // Order History Tab
            var tabOrders = new TabPage("Order History");
            dgvOrderHistory = new DataGridView { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            tabOrders.Controls.Add(dgvOrderHistory);

            // Top Items Tab
            var tabTopItems = new TabPage("Top Ordered Items");
            dgvTopItems = new DataGridView { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            tabTopItems.Controls.Add(dgvTopItems);

            // Add tabs to control
            tabControl.TabPages.Add(tabStock);
            tabControl.TabPages.Add(tabOrders);
            tabControl.TabPages.Add(tabTopItems);

            // Add to form
            this.Controls.Add(tabControl);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu?.Show();
        }

        private void InitializeComponent()
        {

        }
    }
}
