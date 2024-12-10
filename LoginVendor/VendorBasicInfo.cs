using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LoginVendor
{
    public partial class VendorBasicInfo : Form
    {
        private MySqlConnection mysqlConnection;
        private string connectionString = "server=localhost;user=root;database=vendorDB;port=3306;password=(Bshow123!);";

        public VendorBasicInfo()
        {
            InitializeComponent();
            mysqlConnection = new MySqlConnection(connectionString);
        }

        private void VendorBasicInfo_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) //This is the Exit button
        {
            Application.Exit();
        }

        // Function to retrieve the next ID from the database
        private int GetNextId(MySqlConnection connection)
        {
            // Ensure connection is open before calling this function
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string query = "SELECT COALESCE(MAX(ID), 0) + 1 FROM vendorinfo";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            int nextId = Convert.ToInt32(cmd.ExecuteScalar());
            return nextId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(CompanyBox.Text) || 
                string.IsNullOrWhiteSpace(textBox3.Text) || listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields (Name, Company, Cell, and City).");
                return;
            }

            string sqlCommandText = @"INSERT INTO vendorinfo (ID, Name, Company, Cell, City, Products, Dairy_products, Delivery, Payment)
                                    VALUES (@ID, @Name, @Company, @Cell, @City, @Products, @Dairy_products, @Delivery, @Payment)";

            try
            {
                mysqlConnection.Open();

                // Get the next ID
                int nextId = GetNextId(mysqlConnection);

                using (MySqlCommand command = new MySqlCommand(sqlCommandText, mysqlConnection))
                {
                    // Set parameters
                    command.Parameters.AddWithValue("@ID", nextId);
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@Company", CompanyBox.Text);
                    command.Parameters.AddWithValue("@Cell", textBox3.Text);
                    command.Parameters.AddWithValue("@City", listBox1.GetItemText(listBox1.SelectedItem));

                    // Product: Coffee, Tea, or Herbs
                    string product = rdCoffee.Checked ? "Coffee Beans" :
                                   rdTea.Checked ? "Green Tea" :
                                   rdHerbs.Checked ? "Herbs" : "";
                    command.Parameters.AddWithValue("@Products", product);

                    // Dairy product: Milk or Cream
                    string dairyProduct = rdMilk.Checked ? "Milk" :
                                        rdCream.Checked ? "Cream" : "";
                    command.Parameters.AddWithValue("@Dairy_products", dairyProduct);

                    // Delivery status
                    string deliveryStatus = ckOnTime.Checked ? "on time" : "delayed";
                    command.Parameters.AddWithValue("@Delivery", deliveryStatus);

                    // Payment status
                    string paymentStatus = ckPaid.Checked ? "paid" : "unpaid";
                    command.Parameters.AddWithValue("@Payment", paymentStatus);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Vendor information saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save to database: " + ex.Message);
            }
            finally
            {
                if (mysqlConnection.State == ConnectionState.Open)
                    mysqlConnection.Close();
            }
        }

        // Keep existing UI event handlers
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { } //This is the Coffee button
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { } //This is the Herbs button
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { } //This is the Green Tea button
        private void rdCream_CheckedChanged(object sender, EventArgs e) { }
        private void rdMilk_CheckedChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { } //This is the Name Textbox
        private void textBox3_TextChanged(object sender, EventArgs e) { } //This is the Cell Textbox
        private void CompanyBox_TextChanged(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
