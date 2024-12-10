namespace LoginVendor
{
    partial class VendorBasicInfo
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
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CompanyBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DairyProductsGroup = new System.Windows.Forms.GroupBox();
            this.rdCream = new System.Windows.Forms.RadioButton();
            this.rdMilk = new System.Windows.Forms.RadioButton();
            this.ProductsGroup = new System.Windows.Forms.GroupBox();
            this.rdHerbs = new System.Windows.Forms.RadioButton();
            this.rdTea = new System.Windows.Forms.RadioButton();
            this.rdCoffee = new System.Windows.Forms.RadioButton();
            this.DeliveryGroup = new System.Windows.Forms.GroupBox();
            this.ckDelayed = new System.Windows.Forms.CheckBox();
            this.ckOnTime = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PaymentGroup = new System.Windows.Forms.GroupBox();
            this.ckUnpaid = new System.Windows.Forms.CheckBox();
            this.ckPaid = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DairyProductsGroup.SuspendLayout();
            this.ProductsGroup.SuspendLayout();
            this.DeliveryGroup.SuspendLayout();
            this.PaymentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(977, 596);
            this.Exit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(887, 596);
            this.Save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 30);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.CompanyBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblCell);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(415, 527);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 136);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 30);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = " ";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CompanyBox
            // 
            this.CompanyBox.Location = new System.Drawing.Point(152, 88);
            this.CompanyBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(248, 30);
            this.CompanyBox.TabIndex = 6;
            this.CompanyBox.TextChanged += new System.EventHandler(this.CompanyBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(36, 189);
            this.lblCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 25);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(40, 136);
            this.lblCell.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(46, 25);
            this.lblCell.TabIndex = 3;
            this.lblCell.Text = "Cell";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(36, 82);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(97, 25);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Company";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 40);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "• Abilene",
            "• Andover",
            "• Arkansas City",
            "• Atchison",
            "• Augusta",
            "• Baldwin City",
            "• Bel Aire",
            "• Bonner Springs",
            "• Chanute",
            "• Coffeyville",
            "• Colby",
            "• Concordia",
            "• De Soto",
            "• Derby",
            "• Dodge City",
            "• El Dorado",
            "• Emporia",
            "• Eudora",
            "• Fort Scott",
            "• Garden City",
            "• Gardner",
            "• Great Bend",
            "• Hays",
            "• Haysville",
            "• Hutchinson",
            "• Independence",
            "• Iola",
            "• Junction City",
            "• Kansas City",
            "• Lansing",
            "• Lawrence",
            "• Leavenworth",
            "• Leawood",
            "• Lenexa",
            "• Liberal",
            "• Manhattan",
            "• McPherson",
            "• Merriam",
            "• Mission",
            "• Newton",
            "• Olathe",
            "• Ottawa",
            "• Overland Park",
            "• Paola",
            "• Park City",
            "• Parsons",
            "• Pittsburg",
            "• Prairie Village",
            "• Pratt",
            "• Roeland Park",
            "• Salina",
            "• Shawnee",
            "• Spring Hill",
            "• Stilwell",
            "• Topeka",
            "• Ulysses",
            "• Valley Center",
            "• Wellington",
            "• Wichita",
            "• Winfield"});
            this.listBox1.Location = new System.Drawing.Point(152, 184);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 179);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DairyProductsGroup);
            this.groupBox2.Controls.Add(this.ProductsGroup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(522, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(347, 357);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products Information";
            // 
            // DairyProductsGroup
            // 
            this.DairyProductsGroup.Controls.Add(this.rdCream);
            this.DairyProductsGroup.Controls.Add(this.rdMilk);
            this.DairyProductsGroup.Location = new System.Drawing.Point(53, 201);
            this.DairyProductsGroup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DairyProductsGroup.Name = "DairyProductsGroup";
            this.DairyProductsGroup.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DairyProductsGroup.Size = new System.Drawing.Size(227, 136);
            this.DairyProductsGroup.TabIndex = 1;
            this.DairyProductsGroup.TabStop = false;
            this.DairyProductsGroup.Text = "Dairy Products";
            // 
            // rdCream
            // 
            this.rdCream.AutoSize = true;
            this.rdCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCream.Location = new System.Drawing.Point(65, 75);
            this.rdCream.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdCream.Name = "rdCream";
            this.rdCream.Size = new System.Drawing.Size(88, 26);
            this.rdCream.TabIndex = 1;
            this.rdCream.TabStop = true;
            this.rdCream.Text = "Cream";
            this.rdCream.UseVisualStyleBackColor = true;
            this.rdCream.CheckedChanged += new System.EventHandler(this.rdCream_CheckedChanged);
            // 
            // rdMilk
            // 
            this.rdMilk.AutoSize = true;
            this.rdMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMilk.Location = new System.Drawing.Point(65, 40);
            this.rdMilk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdMilk.Name = "rdMilk";
            this.rdMilk.Size = new System.Drawing.Size(66, 26);
            this.rdMilk.TabIndex = 0;
            this.rdMilk.TabStop = true;
            this.rdMilk.Text = "Milk";
            this.rdMilk.UseVisualStyleBackColor = true;
            this.rdMilk.CheckedChanged += new System.EventHandler(this.rdMilk_CheckedChanged);
            // 
            // ProductsGroup
            // 
            this.ProductsGroup.Controls.Add(this.rdHerbs);
            this.ProductsGroup.Controls.Add(this.rdTea);
            this.ProductsGroup.Controls.Add(this.rdCoffee);
            this.ProductsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGroup.Location = new System.Drawing.Point(53, 35);
            this.ProductsGroup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProductsGroup.Name = "ProductsGroup";
            this.ProductsGroup.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProductsGroup.Size = new System.Drawing.Size(227, 141);
            this.ProductsGroup.TabIndex = 0;
            this.ProductsGroup.TabStop = false;
            this.ProductsGroup.Text = "Products";
            // 
            // rdHerbs
            // 
            this.rdHerbs.AutoSize = true;
            this.rdHerbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHerbs.Location = new System.Drawing.Point(65, 93);
            this.rdHerbs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdHerbs.Name = "rdHerbs";
            this.rdHerbs.Size = new System.Drawing.Size(83, 26);
            this.rdHerbs.TabIndex = 2;
            this.rdHerbs.TabStop = true;
            this.rdHerbs.Text = "Herbs";
            this.rdHerbs.UseVisualStyleBackColor = true;
            this.rdHerbs.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdTea
            // 
            this.rdTea.AutoSize = true;
            this.rdTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTea.Location = new System.Drawing.Point(65, 62);
            this.rdTea.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdTea.Name = "rdTea";
            this.rdTea.Size = new System.Drawing.Size(122, 26);
            this.rdTea.TabIndex = 1;
            this.rdTea.TabStop = true;
            this.rdTea.Text = "Green Tea";
            this.rdTea.UseVisualStyleBackColor = true;
            this.rdTea.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdCoffee
            // 
            this.rdCoffee.AutoSize = true;
            this.rdCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCoffee.Location = new System.Drawing.Point(65, 30);
            this.rdCoffee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdCoffee.Name = "rdCoffee";
            this.rdCoffee.Size = new System.Drawing.Size(144, 26);
            this.rdCoffee.TabIndex = 0;
            this.rdCoffee.TabStop = true;
            this.rdCoffee.Text = "Coffee Beans";
            this.rdCoffee.UseVisualStyleBackColor = true;
            this.rdCoffee.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DeliveryGroup
            // 
            this.DeliveryGroup.Controls.Add(this.ckDelayed);
            this.DeliveryGroup.Controls.Add(this.ckOnTime);
            this.DeliveryGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryGroup.Location = new System.Drawing.Point(522, 446);
            this.DeliveryGroup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeliveryGroup.Name = "DeliveryGroup";
            this.DeliveryGroup.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeliveryGroup.Size = new System.Drawing.Size(162, 136);
            this.DeliveryGroup.TabIndex = 4;
            this.DeliveryGroup.TabStop = false;
            this.DeliveryGroup.Text = "Delivery";
            // 
            // ckDelayed
            // 
            this.ckDelayed.AutoSize = true;
            this.ckDelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDelayed.Location = new System.Drawing.Point(53, 75);
            this.ckDelayed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ckDelayed.Name = "ckDelayed";
            this.ckDelayed.Size = new System.Drawing.Size(102, 26);
            this.ckDelayed.TabIndex = 1;
            this.ckDelayed.Text = "Delayed";
            this.ckDelayed.UseVisualStyleBackColor = true;
            // 
            // ckOnTime
            // 
            this.ckOnTime.AutoSize = true;
            this.ckOnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckOnTime.Location = new System.Drawing.Point(53, 40);
            this.ckOnTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ckOnTime.Name = "ckOnTime";
            this.ckOnTime.Size = new System.Drawing.Size(105, 26);
            this.ckOnTime.TabIndex = 0;
            this.ckOnTime.Text = "On Time";
            this.ckOnTime.UseVisualStyleBackColor = true;
            // 
            // PaymentGroup
            // 
            this.PaymentGroup.Controls.Add(this.ckUnpaid);
            this.PaymentGroup.Controls.Add(this.ckPaid);
            this.PaymentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentGroup.Location = new System.Drawing.Point(704, 446);
            this.PaymentGroup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PaymentGroup.Name = "PaymentGroup";
            this.PaymentGroup.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PaymentGroup.Size = new System.Drawing.Size(162, 136);
            this.PaymentGroup.TabIndex = 5;
            this.PaymentGroup.TabStop = false;
            this.PaymentGroup.Text = "Payment";
            // 
            // ckUnpaid
            // 
            this.ckUnpaid.AutoSize = true;
            this.ckUnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckUnpaid.Location = new System.Drawing.Point(27, 75);
            this.ckUnpaid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ckUnpaid.Name = "ckUnpaid";
            this.ckUnpaid.Size = new System.Drawing.Size(93, 26);
            this.ckUnpaid.TabIndex = 1;
            this.ckUnpaid.Text = "Unpaid";
            this.ckUnpaid.UseVisualStyleBackColor = true;
            // 
            // ckPaid
            // 
            this.ckPaid.AutoSize = true;
            this.ckPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPaid.Location = new System.Drawing.Point(27, 40);
            this.ckPaid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ckPaid.Name = "ckPaid";
            this.ckPaid.Size = new System.Drawing.Size(72, 26);
            this.ckPaid.TabIndex = 0;
            this.ckPaid.Text = "Paid";
            this.ckPaid.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(799, 596);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VendorBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 647);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.PaymentGroup);
            this.Controls.Add(this.DeliveryGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "VendorBasicInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.VendorBasicInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.DairyProductsGroup.ResumeLayout(false);
            this.DairyProductsGroup.PerformLayout();
            this.ProductsGroup.ResumeLayout(false);
            this.ProductsGroup.PerformLayout();
            this.DeliveryGroup.ResumeLayout(false);
            this.DeliveryGroup.PerformLayout();
            this.PaymentGroup.ResumeLayout(false);
            this.PaymentGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox CompanyBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox ProductsGroup;
        private System.Windows.Forms.RadioButton rdHerbs;
        private System.Windows.Forms.RadioButton rdTea;
        private System.Windows.Forms.RadioButton rdCoffee;
        private System.Windows.Forms.GroupBox DairyProductsGroup;
        private System.Windows.Forms.RadioButton rdCream;
        private System.Windows.Forms.RadioButton rdMilk;
        private System.Windows.Forms.GroupBox DeliveryGroup;
        private System.Windows.Forms.CheckBox ckDelayed;
        private System.Windows.Forms.CheckBox ckOnTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox PaymentGroup;
        private System.Windows.Forms.CheckBox ckUnpaid;
        private System.Windows.Forms.CheckBox ckPaid;
        private System.Windows.Forms.Button btnBack;
    }
}