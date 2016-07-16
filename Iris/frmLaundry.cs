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
    public partial class frmLaundry : Form
    {
        public frmLaundry()
        {
            InitializeComponent();
        }

        private void frmLaundry_Load(object sender, EventArgs e)
        {
            DataSet ds = Laundry.GetLaundryRecord();
            dgvLaundry.DataSource = ds.Tables["Laundry"].DefaultView;
            dgvLaundry.Columns[0].Visible = false;
            List<string> list = Laundry.LaundryItem();
            foreach (var item in list)
            {
                cmbItemType.Items.Add(item);
            }
            //List<string>customer =BookingRoom.GetCustomer();
            List<string> customer = BookingRoom.RemoveCustomer();
            foreach (var item in customer)
            {
                cmbCustomer.Items.Add(item);
            }
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRate.Text=Laundry.ItemRate(cmbItemType.Text).ToString();

        }
        #region txtQuanityLeave
        private void txtquantity_Leave(object sender, EventArgs e)
        {
            int quantity = 0;
            bool ret = int.TryParse(txtquantity.Text, out quantity);
            if (ret)
            {
                txtamount.Text = (Convert.ToInt32(txtRate.Text) *
                    Convert.ToInt32(txtquantity.Text)).ToString();
            }
            else
            {
                txtquantity.Text = "0";
                txtamount.Text = (Convert.ToInt32(txtRate.Text) *
                   Convert.ToInt32(txtquantity.Text)).ToString();
            }
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            LaundryMember laundry=new LaundryMember();
            #region Validation
            if (txtItemDescription.Text == "")
            {
                lblErrorItemDescription.Text = "Description is required";

            }
            else
            {
                laundry.ItemDescription = txtItemDescription.Text;
                lblErrorItemDescription.Text = "";
            }
            if (cmbItemType.SelectedIndex==-1)
            {
                lblErrorItemType.Text = "ItemType is required";

            }
            else
            {
                laundry.ItemNameId = Laundry.ItemId(cmbItemType.Text);
                lblErrorItemType.Text = "";
            }
            if (txtquantity.Text == "" || txtquantity.Text == "0")
            {
                lblErrorQuantity.Text = "Quantity is required";

            }
            else
            {
                laundry.ItemPrice = Convert.ToInt32(txtamount.Text);
                laundry.Quantity = Convert.ToInt32(txtquantity.Text);
                lblErrorQuantity.Text = "";
            }
            if (cmbCustomer.SelectedIndex==-1)
            {
                lblErrorCustomer.Text = "Customer is required";

            }
            else
            {
                laundry.CustomerId = BookingRoom.GetCustomerId(cmbCustomer.Text);
                lblErrorCustomer.Text = "";
            }
            #endregion
            #region Save

            int quantity = 0;
            bool quantityConversion = int.TryParse(txtquantity.Text, out quantity);
            if (quantityConversion)
                lblErrorQuantity.Text = "*";
            else
                lblErrorQuantity.Text = "";
            if (txtItemDescription.Text != "" && cmbItemType.SelectedIndex != -1
                && quantityConversion &&
                cmbCustomer.SelectedIndex != -1)
            {
                    Laundry.AddLaunderyRecord(laundry);
                MessageBox.Show("Data has been saved", "S A V E",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemDescription.Text = "";
                cmbItemType.SelectedIndex = -1;
                txtRate.Text = "";
                txtquantity.Text = "0";
                txtamount.Text = "0";
                cmbCustomer.SelectedIndex = -1;
                DataSet ds = Laundry.GetLaundryRecord();
                dgvLaundry.DataSource = ds.Tables["Laundry"].DefaultView;
                dgvLaundry.Columns[0].Visible = false;
                
            }
            #endregion
        }

        private void btnSave_Leave(object sender, EventArgs e)
        {
            txtItemDescription.Focus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReceptionMenu f = new frmReceptionMenu();
            f.ShowDialog();
            this.Close();
        }
    }
}
