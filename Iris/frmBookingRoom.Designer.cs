namespace Iris
{
    partial class frmBookingRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingRoom));
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBooking = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblErrorCustomer = new System.Windows.Forms.Label();
            this.lblErrorRoom = new System.Windows.Forms.Label();
            this.lblErrorReception = new System.Windows.Forms.Label();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.btnPreview = new System.Windows.Forms.Button();
            this.ppd = new System.Windows.Forms.PrintPreviewDialog();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.lbldashes = new System.Windows.Forms.Label();
            this.brnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(143, 106);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(161, 27);
            this.cmbCustomer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Customer";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNumber.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(144, 157);
            this.cmbRoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(80, 27);
            this.cmbRoomNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Room No#";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 216);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "Date";
            // 
            // dtpBooking
            // 
            this.dtpBooking.Location = new System.Drawing.Point(1, 11);
            this.dtpBooking.Name = "dtpBooking";
            this.dtpBooking.Size = new System.Drawing.Size(242, 27);
            this.dtpBooking.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpBooking);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(131, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 41);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(380, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 59);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Leave);
            // 
            // lblErrorCustomer
            // 
            this.lblErrorCustomer.AutoSize = true;
            this.lblErrorCustomer.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCustomer.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCustomer.Location = new System.Drawing.Point(311, 109);
            this.lblErrorCustomer.Name = "lblErrorCustomer";
            this.lblErrorCustomer.Size = new System.Drawing.Size(0, 21);
            this.lblErrorCustomer.TabIndex = 76;
            // 
            // lblErrorRoom
            // 
            this.lblErrorRoom.AutoSize = true;
            this.lblErrorRoom.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRoom.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRoom.Location = new System.Drawing.Point(231, 163);
            this.lblErrorRoom.Name = "lblErrorRoom";
            this.lblErrorRoom.Size = new System.Drawing.Size(0, 21);
            this.lblErrorRoom.TabIndex = 77;
            // 
            // lblErrorReception
            // 
            this.lblErrorReception.AutoSize = true;
            this.lblErrorReception.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorReception.ForeColor = System.Drawing.Color.Red;
            this.lblErrorReception.Location = new System.Drawing.Point(313, 213);
            this.lblErrorReception.Name = "lblErrorReception";
            this.lblErrorReception.Size = new System.Drawing.Size(0, 21);
            this.lblErrorReception.TabIndex = 78;
            // 
            // dgvBooking
            // 
            this.dgvBooking.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(-4, 14);
            this.dgvBooking.MultiSelect = false;
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(374, 140);
            this.dgvBooking.TabIndex = 79;
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBooking);
            this.groupBox2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 160);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 85;
            this.label5.Text = "Room Booking";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(380, 234);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 59);
            this.btnMenu.TabIndex = 86;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 87;
            this.label6.Text = "Reporting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpSearch);
            this.groupBox3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(254, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 41);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            // 
            // dtpSearch
            // 
            this.dtpSearch.Location = new System.Drawing.Point(-1, 12);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(242, 27);
            this.dtpSearch.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.White;
            this.btnPreview.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(380, 300);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(111, 59);
            this.btnPreview.TabIndex = 89;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // ppd
            // 
            this.ppd.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd.Enabled = true;
            this.ppd.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd.Icon")));
            this.ppd.Name = "ppd";
            this.ppd.Visible = false;
            this.ppd.Load += new System.EventHandler(this.ppd_Load);
            // 
            // pd
            // 
            this.pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_PrintPage);
            // 
            // lbldashes
            // 
            this.lbldashes.AutoSize = true;
            this.lbldashes.Location = new System.Drawing.Point(-4, 503);
            this.lbldashes.Name = "lbldashes";
            this.lbldashes.Size = new System.Drawing.Size(790, 13);
            this.lbldashes.TabIndex = 90;
            this.lbldashes.Text = resources.GetString("lbldashes.Text");
            this.lbldashes.Visible = false;
            // 
            // brnPrint
            // 
            this.brnPrint.BackColor = System.Drawing.Color.White;
            this.brnPrint.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnPrint.Image = ((System.Drawing.Image)(resources.GetObject("brnPrint.Image")));
            this.brnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnPrint.Location = new System.Drawing.Point(380, 369);
            this.brnPrint.Name = "brnPrint";
            this.brnPrint.Size = new System.Drawing.Size(111, 59);
            this.brnPrint.TabIndex = 91;
            this.brnPrint.Text = "Print";
            this.brnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnPrint.UseVisualStyleBackColor = false;
            this.brnPrint.Click += new System.EventHandler(this.brnPrint_Click);
            // 
            // frmBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 427);
            this.Controls.Add(this.brnPrint);
            this.Controls.Add(this.lbldashes);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblErrorReception);
            this.Controls.Add(this.lblErrorRoom);
            this.Controls.Add(this.lblErrorCustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoomNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cmbCustomer);
            this.MaximizeBox = false;
            this.Name = "frmBookingRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingRoom";
            this.Load += new System.EventHandler(this.frmBookingRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBooking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblErrorCustomer;
        private System.Windows.Forms.Label lblErrorRoom;
        private System.Windows.Forms.Label lblErrorReception;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PrintPreviewDialog ppd;
        private System.Drawing.Printing.PrintDocument pd;
        private System.Windows.Forms.Label lbldashes;
        private System.Windows.Forms.Button brnPrint;
    }
}