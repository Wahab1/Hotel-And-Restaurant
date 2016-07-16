namespace Iris
{
    partial class frmAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblLaundryItem = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(19, 221);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            // 
            // lblLaundryItem
            // 
            this.lblLaundryItem.AutoSize = true;
            this.lblLaundryItem.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaundryItem.Location = new System.Drawing.Point(71, 228);
            this.lblLaundryItem.Name = "lblLaundryItem";
            this.lblLaundryItem.Size = new System.Drawing.Size(141, 27);
            this.lblLaundryItem.TabIndex = 53;
            this.lblLaundryItem.Text = "Laundry Item";
            this.lblLaundryItem.Click += new System.EventHandler(this.lblLaundryItem_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(71, 160);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(71, 27);
            this.lblRoom.TabIndex = 52;
            this.lblRoom.Text = "Room";
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(19, 155);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(71, 89);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 27);
            this.lblUser.TabIndex = 50;
            this.lblUser.Text = "User";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 86);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Admin Right";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(325, 273);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 59);
            this.btnLogOut.TabIndex = 55;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(228, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 344);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblLaundryItem);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblLaundryItem;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}