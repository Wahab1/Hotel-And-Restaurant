namespace Iris
{
    partial class frmLaundryItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaundryItem));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLaundryRate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorItemName = new System.Windows.Forms.Label();
            this.lblErrorLaundryRate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLaundry = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChangeRate = new System.Windows.Forms.ComboBox();
            this.txtChangeRate = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaundry)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 193);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 69;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "Laundry Rate";
            // 
            // txtLaundryRate
            // 
            this.txtLaundryRate.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaundryRate.Location = new System.Drawing.Point(166, 196);
            this.txtLaundryRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtLaundryRate.MaxLength = 30;
            this.txtLaundryRate.Name = "txtLaundryRate";
            this.txtLaundryRate.Size = new System.Drawing.Size(65, 26);
            this.txtLaundryRate.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(158, 144);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.MaxLength = 30;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(112, 26);
            this.txtItemName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Rs";
            // 
            // lblErrorItemName
            // 
            this.lblErrorItemName.AutoSize = true;
            this.lblErrorItemName.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorItemName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorItemName.Location = new System.Drawing.Point(277, 149);
            this.lblErrorItemName.Name = "lblErrorItemName";
            this.lblErrorItemName.Size = new System.Drawing.Size(0, 21);
            this.lblErrorItemName.TabIndex = 78;
            // 
            // lblErrorLaundryRate
            // 
            this.lblErrorLaundryRate.AutoSize = true;
            this.lblErrorLaundryRate.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLaundryRate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLaundryRate.Location = new System.Drawing.Point(277, 199);
            this.lblErrorLaundryRate.Name = "lblErrorLaundryRate";
            this.lblErrorLaundryRate.Size = new System.Drawing.Size(0, 21);
            this.lblErrorLaundryRate.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLaundry);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 115);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // dgvLaundry
            // 
            this.dgvLaundry.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaundry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaundry.Location = new System.Drawing.Point(0, 6);
            this.dgvLaundry.MultiSelect = false;
            this.dgvLaundry.Name = "dgvLaundry";
            this.dgvLaundry.ReadOnly = true;
            this.dgvLaundry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaundry.Size = new System.Drawing.Size(246, 109);
            this.dgvLaundry.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(304, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 59);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 86;
            this.label3.Text = "Change Rate";
            // 
            // cmbChangeRate
            // 
            this.cmbChangeRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChangeRate.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChangeRate.FormattingEnabled = true;
            this.cmbChangeRate.Location = new System.Drawing.Point(304, 36);
            this.cmbChangeRate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChangeRate.Name = "cmbChangeRate";
            this.cmbChangeRate.Size = new System.Drawing.Size(70, 27);
            this.cmbChangeRate.TabIndex = 87;
            // 
            // txtChangeRate
            // 
            this.txtChangeRate.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeRate.Location = new System.Drawing.Point(382, 37);
            this.txtChangeRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtChangeRate.MaxLength = 30;
            this.txtChangeRate.Name = "txtChangeRate";
            this.txtChangeRate.Size = new System.Drawing.Size(50, 26);
            this.txtChangeRate.TabIndex = 88;
            this.txtChangeRate.Text = "0";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.White;
            this.btnChange.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.Location = new System.Drawing.Point(321, 70);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(111, 59);
            this.btnChange.TabIndex = 89;
            this.btnChange.Text = "Change";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 31);
            this.label5.TabIndex = 90;
            this.label5.Text = "Add New Item";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(304, 288);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 59);
            this.btnMenu.TabIndex = 111;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmLaundryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 356);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtChangeRate);
            this.Controls.Add(this.cmbChangeRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblErrorLaundryRate);
            this.Controls.Add(this.lblErrorItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLaundryRate);
            this.MaximizeBox = false;
            this.Name = "frmLaundryItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLaundryItem";
            this.Load += new System.EventHandler(this.frmLaundryItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaundry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLaundryRate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorItemName;
        private System.Windows.Forms.Label lblErrorLaundryRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLaundry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChangeRate;
        private System.Windows.Forms.TextBox txtChangeRate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMenu;
    }
}