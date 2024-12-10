using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginVendor
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            //Still need to program the other grid views
            this.vendorCredentialsTableAdapter.Fill(this.vendorLoginDataSet.VendorCredentials);

            gdUserData.DataSource = this.vendorLoginDataSet.VendorCredentials;


            // Visibility settings
            gdUserData.Visible = true;
            gdUserData.BringToFront();
            dgVendorDelivery.Visible = false;
            dgNewVendor.Visible = false;

        }

        private void btnViewVendorData_Click(object sender, EventArgs e)
        {
            this.newVendorsDBTableAdapter.Fill(this.azureVendorLogInDataSet21.NewVendorsDB);
            dgNewVendor.DataSource = this.azureVendorLogInDataSet21.NewVendorsDB;

            dgNewVendor.Visible = true;
            dgNewVendor.BringToFront();
            dgVendorDelivery.Visible = false;
            gdUserData.Visible = false;
        }

        private void btnViewVendorDelivery_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorInfoData.VendorInfo' table
            this.vendorInfoTableAdapter.Fill(this.azureVendorLogInDataSet21.VendorInfo);

            dgVendorDelivery.DataSource = this.azureVendorLogInDataSet21.VendorInfo;

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
            new NewVendorInfo().Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'azureVendorLogInDataSet21.VendorInfo' table. You can move, or remove it, as needed.
            this.vendorInfoTableAdapter.Fill(this.azureVendorLogInDataSet21.VendorInfo);//VendorInfo -YES


            // TODO: This line of code loads data into the 'azureVendorLogInDataSet21.NewVendorsDB' table. You can move, or remove it, as needed.
            this.newVendorsDBTableAdapter.Fill(this.azureVendorLogInDataSet21.NewVendorsDB); //NewVendorsDB


            // TODO: This line of code loads data into the 'vendorLoginDataSet.VendorCredentials' table. You can move, or remove it, as needed.
            this.vendorCredentialsTableAdapter.Fill(this.vendorLoginDataSet.VendorCredentials); // NOT SURE

        }

        private void dgNewVendor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgVendorDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
