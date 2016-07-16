namespace Iris
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdReception = new System.Windows.Forms.RadioButton();
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAdmin.Location = new System.Drawing.Point(57, 119);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(73, 25);
            this.rdAdmin.TabIndex = 0;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Admin";
            this.rdAdmin.UseVisualStyleBackColor = true;
            this.rdAdmin.CheckedChanged += new System.EventHandler(this.rdAdmin_CheckedChanged);
            // 
            // rdReception
            // 
            this.rdReception.AutoSize = true;
            this.rdReception.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReception.Location = new System.Drawing.Point(206, 119);
            this.rdReception.Name = "rdReception";
            this.rdReception.Size = new System.Drawing.Size(93, 25);
            this.rdReception.TabIndex = 1;
            this.rdReception.TabStop = true;
            this.rdReception.Text = "Reception";
            this.rdReception.UseVisualStyleBackColor = true;
            this.rdReception.CheckedChanged += new System.EventHandler(this.rdReception_CheckedChanged);
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDefault.Location = new System.Drawing.Point(4, 45);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(76, 25);
            this.rdDefault.TabIndex = 2;
            this.rdDefault.TabStop = true;
            this.rdDefault.Text = "Default";
            this.rdDefault.UseVisualStyleBackColor = true;
            this.rdDefault.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 52;
            this.label1.Text = "Iris Hotel";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.rdDefault);
            this.Controls.Add(this.rdReception);
            this.Controls.Add(this.rdAdmin);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.RadioButton rdReception;
        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}