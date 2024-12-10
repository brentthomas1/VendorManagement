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

            // Set form properties
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Position the grids
            gdUserData.Location = new Point(432, 78);
            dgNewVendor.Location = new Point(432, 78);
            dgVendorDelivery.Location = new Point(432, 78);
            
            gdUserData.Size = new Size(700, 500);
            dgNewVendor.Size = new Size(700, 500);
            dgVendorDelivery.Size = new Size(700, 500);
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
            grid.ScrollBars = ScrollBars.Both;
            grid.AutoGenerateColumns = true;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Visible = false;
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

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found.");
                            return;
                        }

                        grid.DataSource = dt;
                        grid.Visible = true;

                        // Format the grid
                        grid.RowHeadersWidth = 25;
                        grid.RowTemplate.Height = 35;
                        grid.DefaultCellStyle.Padding = new Padding(5);
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                        grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                        grid.EnableHeadersVisualStyles = false;
                        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
                        grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                        // Auto-size columns
                        foreach (DataGridViewColumn col in grid.Columns)
                        {
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            string query = "SELECT Username, Password, Type FROM vendorcredentials ORDER BY Username";
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
        }
    }
}
