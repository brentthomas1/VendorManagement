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

            // Format the grid for better readability
            dgNewVendor.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            foreach (DataGridViewColumn col in dgNewVendor.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

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

            // Format the grid for better readability
            dgVendorDelivery.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            foreach (DataGridViewColumn col in dgVendorDelivery.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

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
