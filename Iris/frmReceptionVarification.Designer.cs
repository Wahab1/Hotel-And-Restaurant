namespace Iris
{
    partial class frmReceptionVarification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceptionVarification));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnVarify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbReception = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Reception";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(145, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(137, 27);
            this.txtPassword.TabIndex = 41;
            // 
            // btnVarify
            // 
            this.btnVarify.BackColor = System.Drawing.Color.White;
            this.btnVarify.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVarify.Image = ((System.Drawing.Image)(resources.GetObject("btnVarify.Image")));
            this.btnVarify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVarify.Location = new System.Drawing.Point(81, 239);
            this.btnVarify.Name = "btnVarify";
            this.btnVarify.Size = new System.Drawing.Size(111, 59);
            this.btnVarify.TabIndex = 52;
            this.btnVarify.Text = "Log In";
            this.btnVarify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVarify.UseVisualStyleBackColor = false;
            this.btnVarify.Click += new System.EventHandler(this.btnVarify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 27);
            this.label3.TabIndex = 53;
            this.label3.Text = "Reception Varification";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(220, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 59);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Menu";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbReception
            // 
            this.cmbReception.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReception.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReception.FormattingEnabled = true;
            this.cmbReception.Location = new System.Drawing.Point(146, 123);
            this.cmbReception.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReception.Name = "cmbReception";
            this.cmbReception.Size = new System.Drawing.Size(136, 27);
            this.cmbReception.TabIndex = 55;
            // 
            // frmReceptionVarification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 310);
            this.Controls.Add(this.cmbReception);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVarify);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "frmReceptionVarification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionVarification";
            this.Load += new System.EventHandler(this.frmReceptionVarification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnVarify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbReception;
    }
}