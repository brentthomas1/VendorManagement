using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

namespace LoginVendor
{
    public partial class SignUp : Form
    {
        //Create Access Application
        private Access.Application acApp;

        //If on VM 
        private String dbPath = @"C:\\Users\\VirtualM\\OneDrive\\Documents\\KSU\\Senior\\Fall 2024\\MIS 555\\Database";
        //If on Laptop
        //private String dbPath = @"C:\\Users\\erodr\\OneDrive\\Documents\\KSU\\Senior\\Fall 2024\\MIS 555\\Database\\Database1.accdb";

        public SignUp()
        {
            InitializeComponent();
            //acApp = new Access.Application();
           // acApp.OpenCurrentDatabase(dbPath, false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();    
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            // Check does the password match with the confirm password
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Insert new user into the database
            try
            {
                // Build a simple SQL command to insert the data
                var username = textBox1.Text;
                var password = textBox2.Text;

                string query = $"INSERT INTO Users (Username, Password) VALUES ('{username}', '{password}')";
                acApp.DoCmd.RunSQL(query);

                MessageBox.Show("User registered successfully! Please go back and log in.");
                new Login().Show();
                this.Close();
            }
            // Message for any errors that were caught
            catch (Exception ex)
            {
                MessageBox.Show("Failed to register: " + ex.Message);
            }
        }

        private void FormClosed(object sender, EventArgs e)
        {
            //Close Access
            if(acApp != null)
            {
                acApp.Quit();
                acApp = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSignUp_Click_1(object sender, EventArgs e)
        {
            // Check if the password matches the confirm password
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Insert new user into the VendorCredentials table in the database
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-49PLJPG\\SQLEXPRESS;Initial Catalog=VendorLogIn;Integrated Security=True"))
                {
                    sqlConnection.Open();

                    // Build a parameterized SQL command to insert the data into VendorCredentials table
                    var username = textBox1.Text;
                    var password = textBox2.Text;

                    string query = "INSERT INTO dbo.VendorCredentials (Username, Password) VALUES (@username, @password)";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Execute the command
                        command.ExecuteNonQuery();
                    }

                    // Close the connection
                    sqlConnection.Close();

                    MessageBox.Show("User registered successfully! Please go back and log in.");
                    new Login().Show();
                    this.Close();
                }
            }
            // Message for any errors that were caught
            catch (Exception ex)
            {
                MessageBox.Show("Failed to register: " + ex.Message);
            }
        }



    }
}
