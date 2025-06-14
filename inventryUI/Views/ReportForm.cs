using System;
using System.Windows.Forms;
using inventryUI.Controllers;
using Menu; // Needed to access AppMenuForm

namespace inventryUI.Views
{
    public partial class ReportForm : Form
    {
        private ReportController _controller;

        public ReportForm()
        {
            InitializeComponent();
            _controller = new ReportController(this);

            btnBack.Click += btnBack_Click; // Add event binding for Back button
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Or use this.Close();
            AppMenuForm menu = new AppMenuForm();
            menu.Show();
        }
    }
}
