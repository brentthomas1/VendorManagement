using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; // Adding a Sql Connection

namespace LoginVendor
{
    public partial class VendorBasicInfo : Form
    {
        //When using VM
        private SqlConnection sqlConnection;
        private String connectionString = @"Data Source=vendor-mgnt.database.windows.net;Initial Catalog=VendorLogIn;Persist Security Info=True;User ID=Ernesto;Password=Password1!;TrustServerCertificate=True
                                            Integrated Security = True; TrustServerCertificate=True"; // SQL Connection String
        public VendorBasicInfo()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
        }

        private void VendorBasicInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //This is the Exit button
        {
            Application.Exit();
        }


        // Function to retrieve the next ID from the database
        // Function to retrieve the next ID from the database
        private int GetNextId(SqlConnection sqlConnection)
        {
            // Ensure connection is open before calling this function
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            string query = "SELECT ISNULL(MAX(ID), 0) + 1 FROM VendorInfo";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            int nextId = Convert.ToInt32(cmd.ExecuteScalar());

            // Do not close the connection here; it will remain open for further operations
            return nextId;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string sqlCommandText = @"INSERT INTO VendorInfo (ID, Name, Company, Cell, City, Products, Dairy_products, Delivery, Payment)
                              VALUES (@ID, @Name, @Company, @Cell, @City, @Products, @Dairy_products, @Delivery, @Payment)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // Get the next ID
                    long nextId = GetNextId(sqlConnection); // No need to re-open the connection here

                    using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                    {
                        // Set parameters
                        sqlCommand.Parameters.AddWithValue("@ID", nextId);
                        sqlCommand.Parameters.AddWithValue("@Name", textBox1.Text); // From your Excel code
                        sqlCommand.Parameters.AddWithValue("@Company", CompanyBox.Text);
                        sqlCommand.Parameters.AddWithValue("@Cell", textBox3.Text);
                        sqlCommand.Parameters.AddWithValue("@City", listBox1.GetItemText(listBox1.SelectedItem));

                        // Product: Coffee, Tea, or Herbs
                        string product = rdCoffee.Checked ? "Coffee Beans" :
                                         rdTea.Checked ? "Green Tea" :
                                         rdHerbs.Checked ? "Herbs" : "";
                        sqlCommand.Parameters.AddWithValue("@Products", product);

                        // Dairy product: Milk or Cream
                        string dairyProduct = rdMilk.Checked ? "Milk" :
                                              rdCream.Checked ? "Cream" : "";
                        sqlCommand.Parameters.AddWithValue("@Dairy_products", dairyProduct);

                        // Delivery status
                        string deliveryStatus = ckOnTime.Checked ? "on time" : "delayed";
                        sqlCommand.Parameters.AddWithValue("@Delivery", deliveryStatus);

                        // Payment status
                        string paymentStatus = ckPaid.Checked ? "paid" : "unpaid";
                        sqlCommand.Parameters.AddWithValue("@Payment", paymentStatus);

                        sqlCommand.ExecuteNonQuery(); // Execute the SQL command

                        MessageBox.Show("Vendor information saved successfully!");
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save to database: " + ex.Message);
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e) //This is the Coffee button
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //This is the Herbs button
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //This is the Green Tea button
        {

        }

        private void rdCream_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdMilk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //This is the Name Textbox
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) //This is the Cell Textbox
        {

        }

        private void CompanyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
