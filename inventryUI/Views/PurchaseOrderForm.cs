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
            ((System.ComponentModel.ISupportInitialize)nudMinThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(41, 198);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 1;
            label1.Text = "Min Stock Threshold:";
            // 
            // nudMinThreshold
            // 
            nudMinThreshold.Location = new Point(226, 191);
            nudMinThreshold.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMinThreshold.Name = "nudMinThreshold";
            nudMinThreshold.Size = new Size(120, 27);
            nudMinThreshold.TabIndex = 0;
            nudMinThreshold.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelDelivery
            // 
            labelDelivery.AutoSize = true;
            labelDelivery.Location = new Point(42, 248);
            labelDelivery.Name = "labelDelivery";
            labelDelivery.Size = new Size(63, 20);
            labelDelivery.TabIndex = 0;
            labelDelivery.Text = "Delivery";
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Location = new Point(57, 341);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(53, 20);
            labelOrders.TabIndex = 1;
            labelOrders.Text = "Orders";
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(41, 31);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(60, 20);
            labelProduct.TabIndex = 2;
            labelProduct.Text = "Product";
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new Point(41, 89);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(64, 20);
            labelSupplier.TabIndex = 3;
            labelSupplier.Text = "Supplier";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(41, 141);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(65, 20);
            labelQuantity.TabIndex = 4;
            labelQuantity.Text = "Quantity";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Ballpoint Pen", "A4 Printer Paper", "Sticky Notes", "Desk Organizer Tray", "Office Chair" });
            cmbProduct.Location = new Point(221, 23);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 5;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Items.AddRange(new object[] { "Reynolds", "Xerox", "Post-it", "Staples", "Expo" });
            cmbSupplier.Location = new Point(221, 81);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(151, 28);
            cmbSupplier.TabIndex = 6;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(221, 138);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 7;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // dtpDelivery
            // 
            dtpDelivery.Location = new Point(221, 243);
            dtpDelivery.Name = "dtpDelivery";
            dtpDelivery.Size = new Size(250, 27);
            dtpDelivery.TabIndex = 8;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(562, 621);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(94, 29);
            btnDeleteOrder.TabIndex = 9;
            btnDeleteOrder.Text = "DELETE";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(381, 621);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(94, 29);
            btnUpdateStatus.TabIndex = 10;
            btnUpdateStatus.Text = "UPDATE";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(149, 621);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(94, 29);
            btnAddOrder.TabIndex = 11;
            btnAddOrder.Text = "ADD";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // dataGridOrder
            // 
            dataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrder.Columns.AddRange(new DataGridViewColumn[] { OrderId, ProductName, SupplierName, Quantity, Status, ExpectedDelivery });
            dataGridOrder.Location = new Point(101, 375);
            dataGridOrder.Name = "dataGridOrder";
            dataGridOrder.RowHeadersWidth = 51;
            dataGridOrder.Size = new Size(802, 188);
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
            // PurchaseOrderForm
            // 
            ClientSize = new Size(1008, 661);
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

    }
}
