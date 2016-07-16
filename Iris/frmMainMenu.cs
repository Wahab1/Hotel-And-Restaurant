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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            frmReceptionVarification f = new frmReceptionVarification();
            f.ReceptionValue(BookingRoom.GetAdmin());
            f.ShowDialog();
            this.Close();
            
        }

        private void rdReception_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            frmReceptionVarification f = new frmReceptionVarification();
            f.ReceptionValue(BookingRoom.GetReception());
            f.ShowDialog();
            this.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            rdDefault.Checked = true;
        }
    }
}
