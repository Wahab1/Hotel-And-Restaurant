namespace Iris
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorMobile = new System.Windows.Forms.Label();
            this.lblErrorCNIC = new System.Windows.Forms.Label();
            this.lblErrorCity = new System.Windows.Forms.Label();
            this.lblErrorCustomerName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.cmbsno = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlcnic = new System.Windows.Forms.TextBox();
            this.txtmcnic = new System.Windows.Forms.TextBox();
            this.txtfcnci = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblErrorAddress = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(157, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "AddCustomer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 170);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(6, 13);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(388, 151);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(346, 272);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 21);
            this.lblErrorEmail.TabIndex = 56;
            // 
            // lblErrorMobile
            // 
            this.lblErrorMobile.AutoSize = true;
            this.lblErrorMobile.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMobile.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMobile.Location = new System.Drawing.Point(379, 210);
            this.lblErrorMobile.Name = "lblErrorMobile";
            this.lblErrorMobile.Size = new System.Drawing.Size(0, 21);
            this.lblErrorMobile.TabIndex = 55;
            // 
            // lblErrorCNIC
            // 
            this.lblErrorCNIC.AutoSize = true;
            this.lblErrorCNIC.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCNIC.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCNIC.Location = new System.Drawing.Point(401, 151);
            this.lblErrorCNIC.Name = "lblErrorCNIC";
            this.lblErrorCNIC.Size = new System.Drawing.Size(0, 21);
            this.lblErrorCNIC.TabIndex = 54;
            // 
            // lblErrorCity
            // 
            this.lblErrorCity.AutoSize = true;
            this.lblErrorCity.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCity.Location = new System.Drawing.Point(344, 332);
            this.lblErrorCity.Name = "lblErrorCity";
            this.lblErrorCity.Size = new System.Drawing.Size(0, 21);
            this.lblErrorCity.TabIndex = 53;
            // 
            // lblErrorCustomerName
            // 
            this.lblErrorCustomerName.AutoSize = true;
            this.lblErrorCustomerName.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCustomerName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCustomerName.Location = new System.Drawing.Point(347, 90);
            this.lblErrorCustomerName.Name = "lblErrorCustomerName";
            this.lblErrorCustomerName.Size = new System.Drawing.Size(0, 21);
            this.lblErrorCustomerName.TabIndex = 52;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(434, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 59);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(27, 270);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(172, 271);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(27, 209);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mobile";
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(268, 209);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumber.MaxLength = 7;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(102, 26);
            this.txtnumber.TabIndex = 5;
            // 
            // cmbsno
            // 
            this.cmbsno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsno.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsno.FormattingEnabled = true;
            this.cmbsno.Items.AddRange(new object[] {
            "0300",
            "0301",
            "0302",
            "0303",
            "0333",
            "0332",
            "0334",
            "0312",
            "0313",
            "0314",
            "0345",
            "0346"});
            this.cmbsno.Location = new System.Drawing.Point(172, 209);
            this.cmbsno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbsno.Name = "cmbsno";
            this.cmbsno.Size = new System.Drawing.Size(76, 27);
            this.cmbsno.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "CNIC";
            // 
            // txtlcnic
            // 
            this.txtlcnic.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlcnic.Location = new System.Drawing.Point(351, 148);
            this.txtlcnic.Margin = new System.Windows.Forms.Padding(4);
            this.txtlcnic.MaxLength = 1;
            this.txtlcnic.Name = "txtlcnic";
            this.txtlcnic.Size = new System.Drawing.Size(37, 27);
            this.txtlcnic.TabIndex = 3;
            // 
            // txtmcnic
            // 
            this.txtmcnic.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmcnic.Location = new System.Drawing.Point(247, 147);
            this.txtmcnic.Margin = new System.Windows.Forms.Padding(4);
            this.txtmcnic.MaxLength = 7;
            this.txtmcnic.Name = "txtmcnic";
            this.txtmcnic.Size = new System.Drawing.Size(87, 27);
            this.txtmcnic.TabIndex = 2;
            // 
            // txtfcnci
            // 
            this.txtfcnci.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfcnci.Location = new System.Drawing.Point(172, 147);
            this.txtfcnci.Margin = new System.Windows.Forms.Padding(4);
            this.txtfcnci.MaxLength = 5;
            this.txtfcnci.Name = "txtfcnci";
            this.txtfcnci.Size = new System.Drawing.Size(59, 27);
            this.txtfcnci.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(174, 329);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(137, 27);
            this.txtCity.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "City";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 323);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(174, 84);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(137, 27);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(79, 76);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(73, 42);
            this.lblusername.TabIndex = 31;
            this.lblusername.Text = "Customer\r\n   Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(27, 387);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 60;
            this.pictureBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(172, 387);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 63);
            this.txtAddress.TabIndex = 9;
            // 
            // lblErrorAddress
            // 
            this.lblErrorAddress.AutoSize = true;
            this.lblErrorAddress.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAddress.Location = new System.Drawing.Point(332, 405);
            this.lblErrorAddress.Name = "lblErrorAddress";
            this.lblErrorAddress.Size = new System.Drawing.Size(0, 21);
            this.lblErrorAddress.TabIndex = 63;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(430, 539);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 59);
            this.btnMenu.TabIndex = 87;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 631);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblErrorAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorMobile);
            this.Controls.Add(this.lblErrorCNIC);
            this.Controls.Add(this.lblErrorCity);
            this.Controls.Add(this.lblErrorCustomerName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.cmbsno);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlcnic);
            this.Controls.Add(this.txtmcnic);
            this.Controls.Add(this.txtfcnci);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "*";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorMobile;
        private System.Windows.Forms.Label lblErrorCNIC;
        private System.Windows.Forms.Label lblErrorCity;
        private System.Windows.Forms.Label lblErrorCustomerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.ComboBox cmbsno;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlcnic;
        private System.Windows.Forms.TextBox txtmcnic;
        private System.Windows.Forms.TextBox txtfcnci;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblErrorAddress;
        private System.Windows.Forms.Button btnMenu;
    }
}