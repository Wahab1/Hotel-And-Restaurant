namespace Iris
{
    partial class frmLaundry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaundry));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblErrorItemDescription = new System.Windows.Forms.Label();
            this.lblErrorItemType = new System.Windows.Forms.Label();
            this.lblErrorQuantity = new System.Windows.Forms.Label();
            this.lblErrorCustomer = new System.Windows.Forms.Label();
            this.lblErrorReception = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLaundry = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaundry)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "Item Description";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(189, 100);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemDescription.MaxLength = 100;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(118, 26);
            this.txtItemDescription.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Item Type";
            // 
            // cmbItemType
            // 
            this.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemType.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(189, 159);
            this.cmbItemType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(99, 27);
            this.cmbItemType.TabIndex = 1;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 89;
            this.label3.Text = "Rate";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(153, 244);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.MaxLength = 30;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(56, 26);
            this.txtquantity.TabIndex = 2;
            this.txtquantity.Text = "0";
            this.txtquantity.Leave += new System.EventHandler(this.txtquantity_Leave);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(68, 244);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.MaxLength = 30;
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(65, 26);
            this.txtRate.TabIndex = 91;
            this.txtRate.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Quantity";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(232, 243);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtamount.MaxLength = 30;
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(56, 26);
            this.txtamount.TabIndex = 93;
            this.txtamount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 94;
            this.label5.Text = "Amount";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 305);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 96;
            this.label6.Text = "Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(153, 309);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(143, 27);
            this.cmbCustomer.TabIndex = 3;
            // 
            // lblErrorItemDescription
            // 
            this.lblErrorItemDescription.AutoSize = true;
            this.lblErrorItemDescription.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorItemDescription.ForeColor = System.Drawing.Color.Red;
            this.lblErrorItemDescription.Location = new System.Drawing.Point(314, 107);
            this.lblErrorItemDescription.Name = "lblErrorItemDescription";
            this.lblErrorItemDescription.Size = new System.Drawing.Size(0, 21);
            this.lblErrorItemDescription.TabIndex = 101;
            // 
            // lblErrorItemType
            // 
            this.lblErrorItemType.AutoSize = true;
            this.lblErrorItemType.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorItemType.ForeColor = System.Drawing.Color.Red;
            this.lblErrorItemType.Location = new System.Drawing.Point(314, 161);
            this.lblErrorItemType.Name = "lblErrorItemType";
            this.lblErrorItemType.Size = new System.Drawing.Size(0, 21);
            this.lblErrorItemType.TabIndex = 102;
            // 
            // lblErrorQuantity
            // 
            this.lblErrorQuantity.AutoSize = true;
            this.lblErrorQuantity.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorQuantity.Location = new System.Drawing.Point(295, 243);
            this.lblErrorQuantity.Name = "lblErrorQuantity";
            this.lblErrorQuantity.Size = new System.Drawing.Size(0, 21);
            this.lblErrorQuantity.TabIndex = 103;
            // 
            // lblErrorCustomer
            // 
            this.lblErrorCustomer.AutoSize = true;
            this.lblErrorCustomer.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCustomer.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCustomer.Location = new System.Drawing.Point(325, 307);
            this.lblErrorCustomer.Name = "lblErrorCustomer";
            this.lblErrorCustomer.Size = new System.Drawing.Size(0, 21);
            this.lblErrorCustomer.TabIndex = 104;
            // 
            // lblErrorReception
            // 
            this.lblErrorReception.AutoSize = true;
            this.lblErrorReception.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorReception.ForeColor = System.Drawing.Color.Red;
            this.lblErrorReception.Location = new System.Drawing.Point(314, 377);
            this.lblErrorReception.Name = "lblErrorReception";
            this.lblErrorReception.Size = new System.Drawing.Size(0, 21);
            this.lblErrorReception.TabIndex = 105;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(355, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 59);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 232);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 107;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLaundry);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 141);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            // 
            // dgvLaundry
            // 
            this.dgvLaundry.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaundry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaundry.Location = new System.Drawing.Point(0, 18);
            this.dgvLaundry.MultiSelect = false;
            this.dgvLaundry.Name = "dgvLaundry";
            this.dgvLaundry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaundry.Size = new System.Drawing.Size(334, 117);
            this.dgvLaundry.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 31);
            this.label8.TabIndex = 109;
            this.label8.Text = "Laundry Record";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(355, 433);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 59);
            this.btnMenu.TabIndex = 110;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 504);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblErrorReception);
            this.Controls.Add(this.lblErrorCustomer);
            this.Controls.Add(this.lblErrorQuantity);
            this.Controls.Add(this.lblErrorItemType);
            this.Controls.Add(this.lblErrorItemDescription);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemDescription);
            this.MaximizeBox = false;
            this.Name = "frmLaundry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLaundry";
            this.Load += new System.EventHandler(this.frmLaundry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaundry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblErrorItemDescription;
        private System.Windows.Forms.Label lblErrorItemType;
        private System.Windows.Forms.Label lblErrorQuantity;
        private System.Windows.Forms.Label lblErrorCustomer;
        private System.Windows.Forms.Label lblErrorReception;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLaundry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMenu;
    }
}