using System;
using System.Windows.Forms;
using inventryUI.Controllers;

namespace inventryUI.Views
{
    public partial class ReportForm : Form
    {
        private ReportController _controller;

        public ReportForm()
        {
            InitializeComponent();
            _controller = new ReportController(this);
        }
    }
}
