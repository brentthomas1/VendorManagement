using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginVendor
{
    public partial class SignUp : Form
    {
        private MySqlConnection mysqlConnection;
        private string connectionString = "server=localhost;user=root;database=vendorDB;port=3306;password=Bshow123!;";

        public SignUp()
        {
            InitializeComponent();
            mysqlConnection = new MySqlConnection(connectionString);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            // Check if the password matches the confirm password
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // Insert new user into the vendorcredentials table
            try
            {
                mysqlConnection.Open();

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM vendorcredentials WHERE Username = @username;";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, mysqlConnection))
                {
                    checkCommand.Parameters.AddWithValue("@username", textBox1.Text);
                    int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                    
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }
                }

                // Insert new user
                string insertQuery = "INSERT INTO vendorcredentials (Username, Password, Type) VALUES (@username, @password, 'Vendor');";
                using (MySqlCommand command = new MySqlCommand(insertQuery, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@username", textBox1.Text);
                    command.Parameters.AddWithValue("@password", textBox2.Text);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("User registered successfully! Please go back and log in.");
                new Login().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to register: " + ex.Message);
            }
            finally
            {
                if (mysqlConnection.State == System.Data.ConnectionState.Open)
                    mysqlConnection.Close();
            }
        }

        private void FormClosed(object sender, EventArgs e)
        {
            if (mysqlConnection != null)
            {
                mysqlConnection.Close();
                mysqlConnection.Dispose();
            }
        }

        // Keep existing UI event handlers
        private void label1_Click(object sender, EventArgs e) { }
        private void SignUp_Load(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
