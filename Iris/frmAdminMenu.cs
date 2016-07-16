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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser f=new frmUser();
            f.ShowDialog();
            this.Close();
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoom f=new frmRoom();
            f.ShowDialog();
            this.Close();
        }

        private void lblLaundryItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLaundryItem f=new frmLaundryItem();
            f.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu f=new frmMainMenu();
            f.ShowDialog();
            this.Close();
        }
    }
}
