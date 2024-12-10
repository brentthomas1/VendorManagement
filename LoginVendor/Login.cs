using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LoginVendor
{
    public partial class Login : Form
    {
        private MySqlConnection mysqlConnection;
        private string connectionString = "server=localhost;user=root;database=vendorDB;port=3306;password=Bshow123!;";

        public Login()
        {
            InitializeComponent();
            mysqlConnection = new MySqlConnection(connectionString);
        }

        private bool ValidateUser(string username, string passwords)
        {
            try
            {
                mysqlConnection.Open();
                string query = "SELECT COUNT(*) AS UserCount FROM VendorCredentials WHERE Username = @username AND Password = @password";
                MySqlCommand command = new MySqlCommand(query, mysqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", passwords);

                int userCount = Convert.ToInt32(command.ExecuteScalar());
                return userCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return false;
            }
            finally
            {
                if (mysqlConnection.State == System.Data.ConnectionState.Open)
                    mysqlConnection.Close();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please Select a valid user type.");
                comboBoxType.Focus();
                return;
            }

            if (ValidateUser(txtUsername.Text, txtPassword.Text))
            {
                try
                {
                    mysqlConnection.Open();
                    string userTypeQuery = "SELECT Type FROM VendorCredentials WHERE Username = @Username";
                    MySqlCommand command = new MySqlCommand(userTypeQuery, mysqlConnection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);

                    object result = command.ExecuteScalar();
                    string sqlType = result != null ? result.ToString() : string.Empty;

                    string userSelectedType = comboBoxType.Text;

                    if (userSelectedType == sqlType)
                    {
                        if (userSelectedType == "Admin")
                        {
                            new Admin().Show();
                            this.Hide();
                        }
                        else if (userSelectedType == "Vendor")
                        {
                            new VendorBasicInfo().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User type is incorrect! Please select the correct user type.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    if (mysqlConnection.State == System.Data.ConnectionState.Open)
                        mysqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
