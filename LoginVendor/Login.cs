using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginVendor
{
    public partial class Login : Form
    {
        private MySqlConnection mysqlConnection;
        private string connectionString = "Server=localhost;Database=vendordb;Uid=vendorapp;Pwd=Vendor123!;Port=3306;SslMode=None;AllowPublicKeyRetrieval=True;";

        public Login()
        {
            InitializeComponent();
            mysqlConnection = new MySqlConnection(connectionString);

            // Configure form
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;

            // Style textboxes
            ConfigureTextBox(txtUsername, "Username");
            ConfigureTextBox(txtPassword, "Password");
            txtPassword.PasswordChar = '•';

            // Style buttons
            ConfigureButton(button1);  // Sign In button
            ConfigureButton(ExitLabel);  // Exit button
            ConfigureButton(btnShow);  // Show password button
            ConfigureButton(btnHide);  // Hide password button

            // Configure labels
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // Configure combo box
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Items.Clear();
            comboBoxType.Items.AddRange(new object[] { "Admin", "Vendor" });
        }

        private void ConfigureTextBox(TextBox textBox, string placeholder)
        {
            textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;
            textBox.BorderStyle = BorderStyle.None;
            
            // Add padding
            Padding padding = new Padding(10, 5, 10, 5);
            textBox.Margin = padding;

            // Add events for placeholder behavior
            textBox.GotFocus += (s, e) => {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (placeholder == "Password")
                        textBox.PasswordChar = '•';
                }
            };

            textBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                    if (placeholder == "Password")
                        textBox.PasswordChar = '\0';
                }
            };
        }

        private void ConfigureButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.FromArgb(81, 40, 136);  // Purple color
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            
            // Add hover effect
            button.MouseEnter += (s, e) => {
                button.BackColor = Color.FromArgb(101, 60, 156);  // Lighter purple on hover
            };
            
            button.MouseLeave += (s, e) => {
                button.BackColor = Color.FromArgb(81, 40, 136);  // Original purple
            };
        }

        private bool ValidateUser(string username, string password)
        {
            try
            {
                mysqlConnection.Open();
                string query = "SELECT COUNT(*) FROM vendorcredentials WHERE Username = @username AND Password = @password";
                MySqlCommand command = new MySqlCommand(query, mysqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (mysqlConnection.State == System.Data.ConnectionState.Open)
                    mysqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Don't try to login with placeholder text
            if (username == "Username" || password == "Password")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select a user type.");
                return;
            }

            if (ValidateUser(username, password))
            {
                try
                {
                    mysqlConnection.Open();
                    string query = "SELECT Type FROM vendorcredentials WHERE Username = @username AND Password = @password";
                    MySqlCommand command = new MySqlCommand(query, mysqlConnection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string userType = result.ToString();
                        string selectedType = comboBoxType.SelectedItem.ToString();

                        if (userType.Equals(selectedType, StringComparison.OrdinalIgnoreCase))
                        {
                            if (userType.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                new Admin().Show();
                                this.Hide();
                            }
                            else if (userType.Equals("Vendor", StringComparison.OrdinalIgnoreCase))
                            {
                                new VendorBasicInfo().Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selected user type does not match your account type.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (mysqlConnection.State == System.Data.ConnectionState.Open)
                        mysqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            txtPassword.PasswordChar = '\0';
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            comboBoxType.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
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
                txtPassword.PasswordChar = '•';
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (mysqlConnection != null)
            {
                mysqlConnection.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty handler for label1 click
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Empty handler for panel1 paint
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Empty handler for panel2 paint
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            // Empty handler for username text changed
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Empty handler for password text changed
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty handler for combo box selection change
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Empty handler for label4 click
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Empty handler for picture box 1 click
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Empty handler for picture box 2 click
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Empty handler for picture box 3 click
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty handler for form load
        }
    }
}
