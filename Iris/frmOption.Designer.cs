namespace Iris
{
    partial class frmOption
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
            this.label2 = new System.Windows.Forms.Label();
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.rdUpdate = new System.Windows.Forms.RadioButton();
            this.rdDelete = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Select Option";
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDefault.Location = new System.Drawing.Point(105, 181);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(76, 25);
            this.rdDefault.TabIndex = 54;
            this.rdDefault.TabStop = true;
            this.rdDefault.Text = "Default";
            this.rdDefault.UseVisualStyleBackColor = true;
            // 
            // rdUpdate
            // 
            this.rdUpdate.AutoSize = true;
            this.rdUpdate.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUpdate.Location = new System.Drawing.Point(39, 112);
            this.rdUpdate.Name = "rdUpdate";
            this.rdUpdate.Size = new System.Drawing.Size(75, 25);
            this.rdUpdate.TabIndex = 55;
            this.rdUpdate.TabStop = true;
            this.rdUpdate.Text = "Update";
            this.rdUpdate.UseVisualStyleBackColor = true;
            this.rdUpdate.CheckedChanged += new System.EventHandler(this.rdUpdate_CheckedChanged);
            // 
            // rdDelete
            // 
            this.rdDelete.AutoSize = true;
            this.rdDelete.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDelete.Location = new System.Drawing.Point(162, 112);
            this.rdDelete.Name = "rdDelete";
            this.rdDelete.Size = new System.Drawing.Size(70, 25);
            this.rdDelete.TabIndex = 56;
            this.rdDelete.TabStop = true;
            this.rdDelete.Text = "Delete";
            this.rdDelete.UseVisualStyleBackColor = true;
            this.rdDelete.CheckedChanged += new System.EventHandler(this.rdDelete_CheckedChanged);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.rdDelete);
            this.Controls.Add(this.rdUpdate);
            this.Controls.Add(this.rdDefault);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.RadioButton rdUpdate;
        private System.Windows.Forms.RadioButton rdDelete;
    }
}