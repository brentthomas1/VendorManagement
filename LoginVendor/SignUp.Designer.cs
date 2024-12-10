namespace LoginVendor
{
    partial class SignUp
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
            this.txtNewUsername = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.AutoSize = true;
            this.txtNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(136)))));
            this.txtNewUsername.Location = new System.Drawing.Point(162, 102);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(144, 32);
            this.txtNewUsername.TabIndex = 0;
            this.txtNewUsername.Text = "Username";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AutoSize = true;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(136)))));
            this.txtNewPassword.Location = new System.Drawing.Point(162, 228);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(138, 32);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Text = "Password";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(136)))));
            this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.White;
            this.BtnSignUp.Location = new System.Drawing.Point(168, 568);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(288, 52);
            this.BtnSignUp.TabIndex = 2;
            this.BtnSignUp.Text = "SIGN UP";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 29);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 402);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 29);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtConfirmPasswords
            // 
            this.txtConfirmPasswords.AutoSize = true;
            this.txtConfirmPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(136)))));
            this.txtConfirmPasswords.Location = new System.Drawing.Point(162, 349);
            this.txtConfirmPasswords.Name = "txtConfirmPasswords";
            this.txtConfirmPasswords.Size = new System.Drawing.Size(244, 32);
            this.txtConfirmPasswords.TabIndex = 6;
            this.txtConfirmPasswords.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(188, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Already Have an Account?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(222, 658);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Click here to log in";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(593, 792);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPasswords);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNewUsername;
        private System.Windows.Forms.Label txtNewPassword;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtConfirmPasswords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}