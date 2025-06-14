using inventryUI.Models;
using System.Xml.Linq;
using WinFormsApp1.Controllers;

namespace WinFormsApp1
{
    public partial class PurchaseOrderForm : Form
    {

        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private readonly PurchaseOrderController controller = new PurchaseOrderController();

        private void InitializeComponent()

        {
            label1 = new Label();
            nudMinThreshold = new NumericUpDown();
            labelDelivery = new Label();
            labelOrders = new Label();
            labelProduct = new Label();
            labelSupplier = new Label();
            labelQuantity = new Label();
            cmbProduct = new ComboBox();
            cmbSupplier = new ComboBox();
            txtQuantity = new TextBox();
            dtpDelivery = new DateTimePicker();
            btnDeleteOrder = new Button();
            btnUpdateStatus = new Button();
            btnAddOrder = new Button();
            dataGridOrder = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ExpectedDelivery = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnClear_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMinThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(475, 354);
            label1.Name = "label1";
            label1.Size = new Size(247, 42);
            label1.TabIndex = 1;
            label1.Text = "Min Stock Threshold";
            // 
            // nudMinThreshold
            // 
            nudMinThreshold.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudMinThreshold.Location = new Point(744, 354);
            nudMinThreshold.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMinThreshold.Name = "nudMinThreshold";
            nudMinThreshold.Size = new Size(133, 27);
            nudMinThreshold.TabIndex = 0;
            nudMinThreshold.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelDelivery
            // 
            labelDelivery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDelivery.BackColor = Color.LightGray;
            labelDelivery.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelDelivery.ForeColor = Color.Black;
            labelDelivery.Location = new Point(475, 438);
            labelDelivery.Name = "labelDelivery";
            labelDelivery.Size = new Size(192, 39);
            labelDelivery.TabIndex = 0;
            labelDelivery.Text = "Delivery Date";
            // 
            // labelOrders
            // 
            labelOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelOrders.BackColor = Color.LightGray;
            labelOrders.Font = new Font("Times New Roman", 19F, FontStyle.Bold);
            labelOrders.ForeColor = Color.Black;
            labelOrders.Location = new Point(3, 4);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(253, 52);
            labelOrders.TabIndex = 1;
            labelOrders.Text = "Purchase Orders";
            // 
            // labelProduct
            // 
            labelProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelProduct.BackColor = Color.LightGray;
            labelProduct.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelProduct.ForeColor = Color.Black;
            labelProduct.Location = new Point(32, 357);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(133, 40);
            labelProduct.TabIndex = 2;
            labelProduct.Text = "Product";
            // 
            // labelSupplier
            // 
            labelSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSupplier.BackColor = Color.LightGray;
            labelSupplier.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelSupplier.ForeColor = Color.Black;
            labelSupplier.Location = new Point(32, 441);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(133, 39);
            labelSupplier.TabIndex = 3;
            labelSupplier.Text = "Supplier";
            // 
            // labelQuantity
            // 
            labelQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelQuantity.BackColor = Color.LightGray;
            labelQuantity.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelQuantity.ForeColor = Color.Black;
            labelQuantity.Location = new Point(32, 510);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(133, 44);
            labelQuantity.TabIndex = 4;
            labelQuantity.Text = "Quantity";
            labelQuantity.Click += labelQuantity_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Ballpoint Pen", "A4 Printer Paper", "Sticky Notes", "Desk Organizer Tray", "Office Chair" });
            cmbProduct.Location = new Point(191, 357);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(223, 28);
            cmbProduct.TabIndex = 5;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Items.AddRange(new object[] { "Reynolds", "Xerox", "Post-it", "Staples", "Expo" });
            cmbSupplier.Location = new Point(191, 440);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(223, 28);
            cmbSupplier.TabIndex = 6;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(191, 510);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(223, 27);
            txtQuantity.TabIndex = 7;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // dtpDelivery
            // 
            dtpDelivery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpDelivery.Location = new Point(744, 440);
            dtpDelivery.Name = "dtpDelivery";
            dtpDelivery.Size = new Size(263, 27);
            dtpDelivery.TabIndex = 8;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteOrder.BackColor = SystemColors.ControlLight;
            btnDeleteOrder.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnDeleteOrder.Location = new Point(541, 597);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(149, 53);
            btnDeleteOrder.TabIndex = 9;
            btnDeleteOrder.Text = "DELETE";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateStatus.BackColor = SystemColors.ControlLight;
            btnUpdateStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnUpdateStatus.Location = new Point(318, 597);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(149, 53);
            btnUpdateStatus.TabIndex = 10;
            btnUpdateStatus.Text = "UPDATE";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddOrder.BackColor = SystemColors.ControlLight;
            btnAddOrder.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnAddOrder.Location = new Point(98, 597);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(149, 53);
            btnAddOrder.TabIndex = 11;
            btnAddOrder.Text = "ADD";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // dataGridOrder
            // 
            dataGridOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridOrder.BackgroundColor = Color.LightSteelBlue;
            dataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrder.Columns.AddRange(new DataGridViewColumn[] { OrderId, ProductName, SupplierName, Quantity, Status, ExpectedDelivery });
            dataGridOrder.GridColor = SystemColors.ActiveCaption;
            dataGridOrder.Location = new Point(107, 69);
            dataGridOrder.Name = "dataGridOrder";
            dataGridOrder.RowHeadersWidth = 51;
            dataGridOrder.Size = new Size(802, 238);
            dataGridOrder.TabIndex = 12;
            dataGridOrder.CellContentClick += dataGridOrder_CellContentClick;
            // 
            // OrderId
            // 
            OrderId.Frozen = true;
            OrderId.HeaderText = "ORDER ID";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Width = 125;
            // 
            // ProductName
            // 
            ProductName.Frozen = true;
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // SupplierName
            // 
            SupplierName.HeaderText = "Supplier Name";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            SupplierName.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // ExpectedDelivery
            // 
            ExpectedDelivery.HeaderText = "Expected Delivery Date";
            ExpectedDelivery.MinimumWidth = 6;
            ExpectedDelivery.Name = "ExpectedDelivery";
            ExpectedDelivery.ReadOnly = true;
            ExpectedDelivery.Width = 125;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(902, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 13;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear_Click
            // 
            btnClear_Click.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear_Click.BackColor = SystemColors.ControlLight;
            btnClear_Click.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnClear_Click.Location = new Point(744, 597);
            btnClear_Click.Name = "btnClear_Click";
            btnClear_Click.Size = new Size(149, 53);
            btnClear_Click.TabIndex = 14;
            btnClear_Click.Text = "CLEAR";
            btnClear_Click.UseVisualStyleBackColor = false;
            btnClear_Click.Click += btnClear_Click_Click;
            // 
            // PurchaseOrderForm
            // 
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = inventryUI.Views._.inventoyimg;
            ClientSize = new Size(1015, 673);
            Controls.Add(btnClear_Click);
            Controls.Add(button1);
            Controls.Add(nudMinThreshold);
            Controls.Add(label1);
            Controls.Add(dataGridOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnDeleteOrder);
            Controls.Add(dtpDelivery);
            Controls.Add(txtQuantity);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbProduct);
            Controls.Add(labelQuantity);
            Controls.Add(labelSupplier);
            Controls.Add(labelProduct);
            Controls.Add(labelOrders);
            Controls.Add(labelDelivery);
            Name = "PurchaseOrderForm";
            Load += PurchaseOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudMinThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label labelDelivery;
        private Label labelOrders;
        private Label labelProduct;
        private Label labelSupplier;
        private Label labelQuantity;
        private ComboBox cmbProduct;
        private ComboBox cmbSupplier;
        private TextBox txtQuantity;
        private DateTimePicker dtpDelivery;
        private Button btnDeleteOrder;
        private Button btnUpdateStatus;
        private Button btnAddOrder;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn ExpectedDelivery;
        private DataGridView dataGridOrder;

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string product = cmbProduct.Text;
            string supplier = cmbSupplier.Text;
            bool isQuantityValid = int.TryParse(txtQuantity.Text, out int quantity);
            DateTime deliveryDate = dtpDelivery.Value;
            int minThreshold = (int)nudMinThreshold.Value;

            if (!isQuantityValid)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ?? LOW STOCK ALERT
            if (quantity <= minThreshold)
            {
                MessageBox.Show(
                    "?? Warning: Quantity is below the minimum threshold!",
                    "Low Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            try
            {
                controller.AddOrder(product, supplier, quantity, deliveryDate);
                ReloadOrderGrid();

                txtQuantity.Clear();
                dtpDelivery.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridOrder.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);

                string newStatus = selectedRow.Cells["Status"].Value?.ToString() == "Pending" ? "Completed" : "Pending";
                controller.UpdateStatus(orderId, newStatus);
                ReloadOrderGrid();
            }
            else
            {
                MessageBox.Show("Please select an order to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            cmbProduct.Items.AddRange(new string[] { "Keyboard", "Mouse", "Monitor", "CPU" });
            cmbSupplier.Items.AddRange(new string[] { "ABC Suppliers", "Global Tech", "XYZ Traders" });
        }

        private void ReloadOrderGrid()
        {
            dataGridOrder.Rows.Clear();
            var orders = controller.GetAllOrders();
            foreach (var order in orders)
            {
                dataGridOrder.Rows.Add(order.OrderId, order.ProductName, order.SupplierName, order.Quantity, order.Status, order.ExpectedDelivery.ToShortDateString());
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridOrder.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);

                controller.DeleteOrder(orderId);
                ReloadOrderGrid();
            }
            else
            {
                MessageBox.Show("Please select an order to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RefreshGrid()
        {
            ReloadOrderGrid();
        }
        private Label label1;
        private NumericUpDown nudMinThreshold;
        private Button backbtn;
        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelQuantity_Click(object sender, EventArgs e)
        {


        }
        private Button button2;
        private Button btnClear_Click;

        private void btnClear_Click_Click(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            txtQuantity.Clear();
            dtpDelivery.Value = DateTime.Today;
            dataGridOrder.ClearSelection();
        }
    }
}
