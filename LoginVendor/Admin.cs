using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace LoginVendor
{
    public partial class Admin : Form
    {
        private MySqlConnection mysqlConnection;
        private string connectionString = "Server=localhost;Database=vendordb;Uid=vendorapp;Pwd=Vendor123!;Port=3306;SslMode=None;AllowPublicKeyRetrieval=True;";

        public Admin()
        {
            InitializeComponent();
            mysqlConnection = new MySqlConnection(connectionString);

            // Configure grids
            ConfigureGrid(gdUserData);
            ConfigureGrid(dgNewVendor);
            ConfigureGrid(dgVendorDelivery);
        }

        private void ConfigureGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.Fixed3D;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.Size = new Size(800, 400);  // Set a reasonable default size
            grid.Location = new Point(20, 100);  // Position below the buttons
            grid.ScrollBars = ScrollBars.Both;
        }

        private void LoadDataToGrid(string query, DataGridView grid)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Debug information
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show($"No data found for query:\n{query}");
                            return;
                        }

                        grid.DataSource = dt;

                        // Format the grid
                        grid.BackgroundColor = Color.White;
                        grid.BorderStyle = BorderStyle.Fixed3D;
                        grid.RowHeadersWidth = 25;
                        grid.RowTemplate.Height = 35;
                        grid.DefaultCellStyle.Padding = new Padding(5);
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                        grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                        grid.EnableHeadersVisualStyles = false;
                        grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                        grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(grid.Font, System.Drawing.FontStyle.Bold);
                        grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

                        // Set minimum column widths
                        if (grid.Columns.Contains("ID"))
                            grid.Columns["ID"].MinimumWidth = 50;
                        if (grid.Columns.Contains("Contact Name"))
                            grid.Columns["Contact Name"].MinimumWidth = 150;
                        if (grid.Columns.Contains("Company"))
                            grid.Columns["Company"].MinimumWidth = 200;
                        if (grid.Columns.Contains("Phone"))
                            grid.Columns["Phone"].MinimumWidth = 120;
                        if (grid.Columns.Contains("City"))
                            grid.Columns["City"].MinimumWidth = 100;
                        if (grid.Columns.Contains("Products"))
                            grid.Columns["Products"].MinimumWidth = 120;
                        if (grid.Columns.Contains("Dairy Products"))
                            grid.Columns["Dairy Products"].MinimumWidth = 120;
                        if (grid.Columns.Contains("Delivery Status"))
                            grid.Columns["Delivery Status"].MinimumWidth = 120;
                        if (grid.Columns.Contains("Payment Status"))
                            grid.Columns["Payment Status"].MinimumWidth = 120;

                        // Auto-size columns based on content while respecting minimum widths
                        foreach (DataGridViewColumn col in grid.Columns)
                        {
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            int width = col.Width;
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            col.Width = Math.Max(width, col.MinimumWidth);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data:\n{ex.Message}\n\nQuery:\n{query}");
            }
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vendorcredentials";
            LoadDataToGrid(query, gdUserData);

            // Visibility settings
            gdUserData.Visible = true;
            gdUserData.BringToFront();
            dgVendorDelivery.Visible = false;
            dgNewVendor.Visible = false;
        }

        private void btnViewVendorData_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
                ID as 'ID',
                Name as 'Contact Name',
                Company as 'Company',
                Cell as 'Phone',
                City as 'City',
                COALESCE(Products, 'N/A') as 'Products',
                COALESCE(Dairy_products, 'N/A') as 'Dairy Products',
                COALESCE(Delivery, 'N/A') as 'Delivery Status',
                COALESCE(Payment, 'N/A') as 'Payment Status'
            FROM vendorinfo
            ORDER BY ID";
            LoadDataToGrid(query, dgNewVendor);

            // Visibility settings
            dgNewVendor.Visible = true;
            dgNewVendor.BringToFront();
            dgVendorDelivery.Visible = false;
            gdUserData.Visible = false;
        }

        private void btnViewVendorDelivery_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
                ID as 'ID',
                Name as 'Contact Name',
                Company as 'Company',
                City as 'City',
                COALESCE(Products, 'N/A') as 'Products',
                COALESCE(Dairy_products, 'N/A') as 'Dairy Products',
                Delivery as 'Delivery Status',
                Payment as 'Payment Status'
            FROM vendorinfo
            WHERE Delivery IS NOT NULL
            ORDER BY ID";
            LoadDataToGrid(query, dgVendorDelivery);

            // Visibility settings
            dgVendorDelivery.Visible = true;
            dgVendorDelivery.BringToFront();
            gdUserData.Visible = false;
            dgNewVendor.Visible = false;
        }

        private void btnBackLogIn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnNewVendorLog_Click(object sender, EventArgs e)
        {
            var newVendorForm = new NewVendorInfo();
            newVendorForm.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // Load initial data for user grid
            btnViewUserData_Click(sender, e);

            // Make sure all buttons are visible and enabled
            if (btnViewUserData != null) btnViewUserData.Visible = btnViewUserData.Enabled = true;
            if (btnViewVendorData != null) btnViewVendorData.Visible = btnViewVendorData.Enabled = true;
            if (btnViewVendorDelivery != null) btnViewVendorDelivery.Visible = btnViewVendorDelivery.Enabled = true;
            if (btnBackLogIn != null) btnBackLogIn.Visible = btnBackLogIn.Enabled = true;
            if (btnNewVendorLog != null) btnNewVendorLog.Visible = btnNewVendorLog.Enabled = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Ensure proper form size and layout
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Add a refresh button click handler
        private void RefreshData()
        {
            if (gdUserData.Visible)
                btnViewUserData_Click(this, EventArgs.Empty);
            else if (dgNewVendor.Visible)
                btnViewVendorData_Click(this, EventArgs.Empty);
            else if (dgVendorDelivery.Visible)
                btnViewVendorDelivery_Click(this, EventArgs.Empty);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshData(); // Refresh data when form becomes active
        }

        // Keep existing UI event handlers
        private void dgNewVendor_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgVendorDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
