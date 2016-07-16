using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iris
{
    public partial class frmReceptionVarification : Form
    {
        List<string> Booking=null;
        public frmReceptionVarification()
        {
            InitializeComponent();
        }

        public void ReceptionValue(List<string> reception)
        {
            Booking = reception;
        }

        private void frmReceptionVarification_Load(object sender, EventArgs e)
        {
            foreach (var item in Booking)
            {
                cmbReception.Items.Add(item);
            }
        }
        #region ReceptionVarification
        private void btnVarify_Click(object sender, EventArgs e)
        {
            int verify = 0;
            verify=Verification.verify(cmbReception.Text, txtPassword.Text);
            if (verify == 1)
            {
                this.Hide();
                frmAdminMenu f=new frmAdminMenu();
                f.ShowDialog();
                this.Close();
            }
            else if (verify == 2)
            {
                this.Hide();
                frmReceptionMenu f = new frmReceptionMenu();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Password", "E R R O R", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu f = new frmMainMenu();
            f.ShowDialog();
            this.Close();
        }
    }
}
