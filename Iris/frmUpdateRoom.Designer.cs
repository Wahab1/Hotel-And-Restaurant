namespace Iris
{
    partial class frmUpdateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateRoom));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomRent = new System.Windows.Forms.TextBox();
            this.lblErrorRoomRent = new System.Windows.Forms.Label();
            this.lblErrorRoomType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(24, 61);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "RoomType";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.cmbRoomType.Location = new System.Drawing.Point(163, 66);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(122, 27);
            this.cmbRoomType.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "RoomRent";
            // 
            // txtRoomRent
            // 
            this.txtRoomRent.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRent.Location = new System.Drawing.Point(162, 122);
            this.txtRoomRent.Name = "txtRoomRent";
            this.txtRoomRent.Size = new System.Drawing.Size(95, 27);
            this.txtRoomRent.TabIndex = 1;
            // 
            // lblErrorRoomRent
            // 
            this.lblErrorRoomRent.AutoSize = true;
            this.lblErrorRoomRent.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRoomRent.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRoomRent.Location = new System.Drawing.Point(263, 125);
            this.lblErrorRoomRent.Name = "lblErrorRoomRent";
            this.lblErrorRoomRent.Size = new System.Drawing.Size(0, 21);
            this.lblErrorRoomRent.TabIndex = 81;
            // 
            // lblErrorRoomType
            // 
            this.lblErrorRoomType.AutoSize = true;
            this.lblErrorRoomType.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRoomType.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRoomType.Location = new System.Drawing.Point(292, 66);
            this.lblErrorRoomType.Name = "lblErrorRoomType";
            this.lblErrorRoomType.Size = new System.Drawing.Size(0, 21);
            this.lblErrorRoomType.TabIndex = 80;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(20, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 21);
            this.lblId.TabIndex = 82;
            this.lblId.Text = "User_Name";
            this.lblId.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(174, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 59);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 84;
            this.label1.Text = "Update Room";
            // 
            // frmUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblErrorRoomRent);
            this.Controls.Add(this.lblErrorRoomType);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoomRent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.pictureBox6);
            this.MaximizeBox = false;
            this.Name = "frmUpdateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRoom";
            this.Load += new System.EventHandler(this.frmUpdateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomRent;
        private System.Windows.Forms.Label lblErrorRoomRent;
        private System.Windows.Forms.Label lblErrorRoomType;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}