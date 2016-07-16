namespace Iris
{
    partial class frmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtRoomRent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.lblErrorRoomType = new System.Windows.Forms.Label();
            this.lblErrorRoomRent = new System.Windows.Forms.Label();
            this.lblErrorOwner = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "RoomNo#";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(153, 183);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.Size = new System.Drawing.Size(74, 27);
            this.txtRoomNumber.TabIndex = 4;
            // 
            // txtRoomRent
            // 
            this.txtRoomRent.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRent.Location = new System.Drawing.Point(153, 248);
            this.txtRoomRent.Name = "txtRoomRent";
            this.txtRoomRent.ReadOnly = true;
            this.txtRoomRent.Size = new System.Drawing.Size(95, 27);
            this.txtRoomRent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "RoomRent";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.cmbRoomType.Location = new System.Drawing.Point(153, 118);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(122, 27);
            this.cmbRoomType.TabIndex = 0;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 113);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "RoomType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "Admin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // cmbOwner
            // 
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(153, 315);
            this.cmbOwner.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(122, 27);
            this.cmbOwner.TabIndex = 2;
            // 
            // lblErrorRoomType
            // 
            this.lblErrorRoomType.AutoSize = true;
            this.lblErrorRoomType.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRoomType.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRoomType.Location = new System.Drawing.Point(294, 121);
            this.lblErrorRoomType.Name = "lblErrorRoomType";
            this.lblErrorRoomType.Size = new System.Drawing.Size(0, 21);
            this.lblErrorRoomType.TabIndex = 78;
            // 
            // lblErrorRoomRent
            // 
            this.lblErrorRoomRent.AutoSize = true;
            this.lblErrorRoomRent.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRoomRent.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRoomRent.Location = new System.Drawing.Point(257, 249);
            this.lblErrorRoomRent.Name = "lblErrorRoomRent";
            this.lblErrorRoomRent.Size = new System.Drawing.Size(0, 21);
            this.lblErrorRoomRent.TabIndex = 79;
            // 
            // lblErrorOwner
            // 
            this.lblErrorOwner.AutoSize = true;
            this.lblErrorOwner.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOwner.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOwner.Location = new System.Drawing.Point(294, 318);
            this.lblErrorOwner.Name = "lblErrorOwner";
            this.lblErrorOwner.Size = new System.Drawing.Size(0, 21);
            this.lblErrorOwner.TabIndex = 80;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(70, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 59);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRoom);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 142);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // dgvRoom
            // 
            this.dgvRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(0, 6);
            this.dgvRoom.MultiSelect = false;
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(443, 136);
            this.dgvRoom.TabIndex = 0;
            this.dgvRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 31);
            this.label4.TabIndex = 84;
            this.label4.Text = "Add New Room";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(233, 361);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 59);
            this.btnMenu.TabIndex = 112;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 592);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblErrorOwner);
            this.Controls.Add(this.lblErrorRoomRent);
            this.Controls.Add(this.lblErrorRoomType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoomRent);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cmbRoomType);
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtRoomRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Label lblErrorRoomType;
        private System.Windows.Forms.Label lblErrorRoomRent;
        private System.Windows.Forms.Label lblErrorOwner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenu;
    }
}