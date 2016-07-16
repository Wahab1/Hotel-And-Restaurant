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
    public partial class frmLaundryItem : Form
    {
        public frmLaundryItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LaundryMember laundry=new LaundryMember();
            if (txtItemName.Text == "")
            {
                lblErrorItemName.Text = "ItemName is required";
            }
            else
            {
                laundry.ItemName = txtItemName.Text;
                lblErrorItemName.Text = "";
            }
            if (txtLaundryRate.Text == "")
            {
                lblErrorLaundryRate.Text = "Rate is required";
            }
            else
            {
            int price = 0;
            bool ret = int.TryParse(txtLaundryRate.Text,out price);
                if (ret)
                {
                    laundry.ItemPrice = price;
                    lblErrorLaundryRate.Text = "";
                }
                else
                {
                    lblErrorLaundryRate.Text = "Invalid Input";
                    txtLaundryRate.Text = "";
                }
            }
            if (txtItemName.Text != "" && txtLaundryRate.Text != "")
            {
                Laundry.AddItem(laundry);
                MessageBox.Show("Data has been saved", "S A V E", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds = Laundry.GetLaudryItem();
                dgvLaundry.DataSource = ds.Tables["LaundryItem"].DefaultView;
                dgvLaundry.Columns[0].Visible = false;
                txtItemName.Text = "";
                txtLaundryRate.Text = "";
                cmbChangeRate.Items.Clear();
                List<string> list = Laundry.LaundryItem();
                foreach (var item in list)
                {
                    cmbChangeRate.Items.Add(item);
                }
            }

        }

        private void frmLaundryItem_Load(object sender, EventArgs e)
        {
            DataSet ds = Laundry.GetLaudryItem();
            dgvLaundry.DataSource = ds.Tables["LaundryItem"].DefaultView;
            dgvLaundry.Columns[0].Visible = false;

            List<string> list = Laundry.LaundryItem();
            foreach (var item in list)
            {
                cmbChangeRate.Items.Add(item);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            LaundryMember laundry=new LaundryMember();
            int rate = 0;
            bool ret = int.TryParse(txtChangeRate.Text, out rate);
            if (ret)
            {
                laundry.ItemPrice = rate;
            }
            else
            {
                cmbChangeRate.Text = "0";
            }
            laundry.ItemName = cmbChangeRate.Text;
            if (cmbChangeRate.SelectedIndex != -1 && cmbChangeRate.Text != "0"
                && cmbChangeRate.Text != ""&&ret)
            {
                Laundry.UpdateRate(laundry);
                DataSet ds = Laundry.GetLaudryItem();
                dgvLaundry.DataSource = ds.Tables["LaundryItem"].DefaultView;
                dgvLaundry.Columns[0].Visible = false;
                cmbChangeRate.SelectedIndex = -1;
                txtChangeRate.Text = "0";
                
            }
        }

        private void btnSave_Leave(object sender, EventArgs e)
        {
            txtItemName.Focus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminMenu f = new frmAdminMenu();
            f.ShowDialog();
            this.Hide();
        }
    }
}
