using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
                        grid.DataSource = dt;

                        // Format the grid
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        grid.ScrollBars = ScrollBars.Both;
                        grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

                        // Ensure grid size doesn't exceed form
                        grid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        grid.Dock = DockStyle.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
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
                ID,
                Name as 'Contact Name',
                Company,
                Cell as 'Phone',
                City,
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
                ID,
                Name as 'Contact Name',
                Company,
                City,
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
            // Load initial data for all grids
            btnViewUserData_Click(sender, e);
            btnViewVendorData_Click(sender, e);
            btnViewVendorDelivery_Click(sender, e);

            // Set initial visibility
            gdUserData.Visible = true;
            gdUserData.BringToFront();
            dgVendorDelivery.Visible = false;
            dgNewVendor.Visible = false;
        }

        // Keep existing UI event handlers
        private void dgNewVendor_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgVendorDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
