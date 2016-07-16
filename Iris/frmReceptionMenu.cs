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
    public partial class frmReceptionMenu : Form
    {
        public frmReceptionMenu()
        {
            InitializeComponent();
        }

        private void lblBookingRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingRoom f=new frmBookingRoom();
            f.ShowDialog();
            this.Close();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer f=new frmCustomer();
            f.ShowDialog();
            this.Close();
        }

        private void lblLaundry_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLaundry f=new frmLaundry();
            f.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu f = new frmMainMenu();
            f.ShowDialog();
            this.Close();
        }

        private void lblRecipes_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmRecipes f = new frmRecipes();
            f.ShowDialog();
            this.Close();
        }
    }
}
