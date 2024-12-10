namespace LoginVendor
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnViewUserData = new System.Windows.Forms.Button();
            this.btnViewVendorData = new System.Windows.Forms.Button();
            this.btnViewVendorDelivery = new System.Windows.Forms.Button();
            this.btnBackLogIn = new System.Windows.Forms.Button();
            this.btnNewVendorLog = new System.Windows.Forms.Button();
            this.gdUserData = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorCredentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorLoginDataSet = new LoginVendor.VendorLoginDataSet();
            this.vendorCredentialsTableAdapter = new LoginVendor.VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter();
            this.azureVendorLogInDataSet21 = new LoginVendor.AzureVendorLogInDataSet2();
            this.dgNewVendor = new System.Windows.Forms.DataGridView();
            this.newVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCJobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCComAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.newVendorsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorLoginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorCredentialsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorsDBTableAdapter = new LoginVendor.AzureVendorLogInDataSet2TableAdapters.NewVendorsDBTableAdapter();
            this.dgVendorDelivery = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dairyproductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoTableAdapter = new LoginVendor.AzureVendorLogInDataSet2TableAdapters.VendorInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gdUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureVendorLogInDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorsDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewUserData
            // 
            this.btnViewUserData.Location = new System.Drawing.Point(84, 78);
            this.btnViewUserData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewUserData.Name = "btnViewUserData";
            this.btnViewUserData.Size = new System.Drawing.Size(280, 57);
            this.btnViewUserData.TabIndex = 0;
            this.btnViewUserData.Text = "View User Data";
            this.btnViewUserData.UseVisualStyleBackColor = true;
            this.btnViewUserData.Click += new System.EventHandler(this.btnViewUserData_Click);
            // 
            // btnViewVendorData
            // 
            this.btnViewVendorData.Location = new System.Drawing.Point(84, 403);
            this.btnViewVendorData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewVendorData.Name = "btnViewVendorData";
            this.btnViewVendorData.Size = new System.Drawing.Size(280, 57);
            this.btnViewVendorData.TabIndex = 1;
            this.btnViewVendorData.Text = "View Vendor Data";
            this.btnViewVendorData.UseVisualStyleBackColor = true;
            this.btnViewVendorData.Click += new System.EventHandler(this.btnViewVendorData_Click);
            // 
            // btnViewVendorDelivery
            // 
            this.btnViewVendorDelivery.Location = new System.Drawing.Point(84, 235);
            this.btnViewVendorDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewVendorDelivery.Name = "btnViewVendorDelivery";
            this.btnViewVendorDelivery.Size = new System.Drawing.Size(280, 57);
            this.btnViewVendorDelivery.TabIndex = 2;
            this.btnViewVendorDelivery.Text = "View Vendor Delivery";
            this.btnViewVendorDelivery.UseVisualStyleBackColor = true;
            this.btnViewVendorDelivery.Click += new System.EventHandler(this.btnViewVendorDelivery_Click);
            // 
            // btnBackLogIn
            // 
            this.btnBackLogIn.Location = new System.Drawing.Point(84, 600);
            this.btnBackLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackLogIn.Name = "btnBackLogIn";
            this.btnBackLogIn.Size = new System.Drawing.Size(280, 58);
            this.btnBackLogIn.TabIndex = 3;
            this.btnBackLogIn.Text = "Back";
            this.btnBackLogIn.UseVisualStyleBackColor = true;
            this.btnBackLogIn.Click += new System.EventHandler(this.btnBackLogIn_Click);
            // 
            // btnNewVendorLog
            // 
            this.btnNewVendorLog.Location = new System.Drawing.Point(888, 600);
            this.btnNewVendorLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewVendorLog.Name = "btnNewVendorLog";
            this.btnNewVendorLog.Size = new System.Drawing.Size(280, 58);
            this.btnNewVendorLog.TabIndex = 4;
            this.btnNewVendorLog.Text = "New Vendor Log";
            this.btnNewVendorLog.UseVisualStyleBackColor = true;
            this.btnNewVendorLog.Click += new System.EventHandler(this.btnNewVendorLog_Click);
            // 
            // gdUserData
            // 
            this.gdUserData.AutoGenerateColumns = false;
            this.gdUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.gdUserData.DataSource = this.vendorCredentialsBindingSource;
            this.gdUserData.Location = new System.Drawing.Point(432, 78);
            this.gdUserData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdUserData.Name = "gdUserData";
            this.gdUserData.RowHeadersWidth = 62;
            this.gdUserData.Size = new System.Drawing.Size(758, 489);
            this.gdUserData.TabIndex = 5;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorCredentialsBindingSource
            // 
            this.vendorCredentialsBindingSource.DataMember = "VendorCredentials";
            this.vendorCredentialsBindingSource.DataSource = this.vendorLoginDataSet;
            // 
            // vendorLoginDataSet
            // 
            this.vendorLoginDataSet.DataSetName = "VendorLoginDataSet";
            this.vendorLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorCredentialsTableAdapter
            // 
            this.vendorCredentialsTableAdapter.ClearBeforeFill = true;
            // 
            // azureVendorLogInDataSet21
            // 
            this.azureVendorLogInDataSet21.DataSetName = "AzureVendorLogInDataSet2";
            this.azureVendorLogInDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgNewVendor
            // 
            this.dgNewVendor.AutoGenerateColumns = false;
            this.dgNewVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNewVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newVIDDataGridViewTextBoxColumn,
            this.pOCNameDataGridViewTextBoxColumn,
            this.pOCJobTitleDataGridViewTextBoxColumn,
            this.pOCEmailDataGridViewTextBoxColumn,
            this.pOCPhoneDataGridViewTextBoxColumn,
            this.pOCCompanyDataGridViewTextBoxColumn,
            this.pOCComAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dgNewVendor.DataSource = this.newVendorsDBBindingSource;
            this.dgNewVendor.Location = new System.Drawing.Point(432, 78);
            this.dgNewVendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgNewVendor.Name = "dgNewVendor";
            this.dgNewVendor.RowHeadersWidth = 62;
            this.dgNewVendor.Size = new System.Drawing.Size(758, 489);
            this.dgNewVendor.TabIndex = 6;
            this.dgNewVendor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNewVendor_CellContentClick);
            // 
            // newVIDDataGridViewTextBoxColumn
            // 
            this.newVIDDataGridViewTextBoxColumn.DataPropertyName = "New_VID";
            this.newVIDDataGridViewTextBoxColumn.HeaderText = "New_VID";
            this.newVIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.newVIDDataGridViewTextBoxColumn.Name = "newVIDDataGridViewTextBoxColumn";
            this.newVIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCNameDataGridViewTextBoxColumn
            // 
            this.pOCNameDataGridViewTextBoxColumn.DataPropertyName = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.HeaderText = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCNameDataGridViewTextBoxColumn.Name = "pOCNameDataGridViewTextBoxColumn";
            this.pOCNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCJobTitleDataGridViewTextBoxColumn
            // 
            this.pOCJobTitleDataGridViewTextBoxColumn.DataPropertyName = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.HeaderText = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCJobTitleDataGridViewTextBoxColumn.Name = "pOCJobTitleDataGridViewTextBoxColumn";
            this.pOCJobTitleDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCEmailDataGridViewTextBoxColumn
            // 
            this.pOCEmailDataGridViewTextBoxColumn.DataPropertyName = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.HeaderText = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCEmailDataGridViewTextBoxColumn.Name = "pOCEmailDataGridViewTextBoxColumn";
            this.pOCEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCPhoneDataGridViewTextBoxColumn
            // 
            this.pOCPhoneDataGridViewTextBoxColumn.DataPropertyName = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.HeaderText = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCPhoneDataGridViewTextBoxColumn.Name = "pOCPhoneDataGridViewTextBoxColumn";
            this.pOCPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCCompanyDataGridViewTextBoxColumn
            // 
            this.pOCCompanyDataGridViewTextBoxColumn.DataPropertyName = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.HeaderText = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCCompanyDataGridViewTextBoxColumn.Name = "pOCCompanyDataGridViewTextBoxColumn";
            this.pOCCompanyDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCComAddressDataGridViewTextBoxColumn
            // 
            this.pOCComAddressDataGridViewTextBoxColumn.DataPropertyName = "POC_ComAddress";
            this.pOCComAddressDataGridViewTextBoxColumn.HeaderText = "POC_ComAddress";
            this.pOCComAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCComAddressDataGridViewTextBoxColumn.Name = "pOCComAddressDataGridViewTextBoxColumn";
            this.pOCComAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.MinimumWidth = 8;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.Width = 150;
            // 
            // newVendorsDBBindingSource
            // 
            this.newVendorsDBBindingSource.DataMember = "NewVendorsDB";
            this.newVendorsDBBindingSource.DataSource = this.azureVendorLogInDataSet21;
            // 
            // vendorLoginDataSetBindingSource
            // 
            this.vendorLoginDataSetBindingSource.DataSource = this.vendorLoginDataSet;
            this.vendorLoginDataSetBindingSource.Position = 0;
            // 
            // vendorCredentialsBindingSource1
            // 
            this.vendorCredentialsBindingSource1.DataMember = "VendorCredentials";
            this.vendorCredentialsBindingSource1.DataSource = this.vendorLoginDataSetBindingSource;
            // 
            // newVendorsDBTableAdapter
            // 
            this.newVendorsDBTableAdapter.ClearBeforeFill = true;
            // 
            // dgVendorDelivery
            // 
            this.dgVendorDelivery.AutoGenerateColumns = false;
            this.dgVendorDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendorDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.cellDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn1,
            this.productsDataGridViewTextBoxColumn,
            this.dairyproductsDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn});
            this.dgVendorDelivery.DataSource = this.vendorInfoBindingSource;
            this.dgVendorDelivery.Location = new System.Drawing.Point(432, 78);
            this.dgVendorDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgVendorDelivery.Name = "dgVendorDelivery";
            this.dgVendorDelivery.RowHeadersWidth = 62;
            this.dgVendorDelivery.Size = new System.Drawing.Size(758, 489);
            this.dgVendorDelivery.TabIndex = 7;
            this.dgVendorDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendorDelivery_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.Width = 150;
            // 
            // cellDataGridViewTextBoxColumn
            // 
            this.cellDataGridViewTextBoxColumn.DataPropertyName = "Cell";
            this.cellDataGridViewTextBoxColumn.HeaderText = "Cell";
            this.cellDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cellDataGridViewTextBoxColumn.Name = "cellDataGridViewTextBoxColumn";
            this.cellDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.Width = 150;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "Products";
            this.productsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            this.productsDataGridViewTextBoxColumn.Width = 150;
            // 
            // dairyproductsDataGridViewTextBoxColumn
            // 
            this.dairyproductsDataGridViewTextBoxColumn.DataPropertyName = "Dairy_products";
            this.dairyproductsDataGridViewTextBoxColumn.HeaderText = "Dairy_products";
            this.dairyproductsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dairyproductsDataGridViewTextBoxColumn.Name = "dairyproductsDataGridViewTextBoxColumn";
            this.dairyproductsDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            this.deliveryDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorInfoBindingSource
            // 
            this.vendorInfoBindingSource.DataMember = "VendorInfo";
            this.vendorInfoBindingSource.DataSource = this.azureVendorLogInDataSet21;
            // 
            // vendorInfoTableAdapter
            // 
            this.vendorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 734);
            this.Controls.Add(this.dgVendorDelivery);
            this.Controls.Add(this.dgNewVendor);
            this.Controls.Add(this.gdUserData);
            this.Controls.Add(this.btnNewVendorLog);
            this.Controls.Add(this.btnBackLogIn);
            this.Controls.Add(this.btnViewVendorDelivery);
            this.Controls.Add(this.btnViewVendorData);
            this.Controls.Add(this.btnViewUserData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureVendorLogInDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorsDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewUserData;
        private System.Windows.Forms.Button btnViewVendorData;
        private System.Windows.Forms.Button btnViewVendorDelivery;
        private System.Windows.Forms.Button btnBackLogIn;
        private System.Windows.Forms.Button btnNewVendorLog;
        private System.Windows.Forms.DataGridView gdUserData;
        private VendorLoginDataSet vendorLoginDataSet;
        private System.Windows.Forms.BindingSource vendorCredentialsBindingSource;
        private VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter vendorCredentialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private AzureVendorLogInDataSet2 azureVendorLogInDataSet21;
        private System.Windows.Forms.DataGridView dgNewVendor;
        private System.Windows.Forms.BindingSource vendorCredentialsBindingSource1;
        private System.Windows.Forms.BindingSource vendorLoginDataSetBindingSource;
        private System.Windows.Forms.BindingSource newVendorsDBBindingSource;
        private AzureVendorLogInDataSet2TableAdapters.NewVendorsDBTableAdapter newVendorsDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn newVIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCJobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCComAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridView dgVendorDelivery;
        private System.Windows.Forms.BindingSource vendorInfoBindingSource;
        private AzureVendorLogInDataSet2TableAdapters.VendorInfoTableAdapter vendorInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dairyproductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
    }
}