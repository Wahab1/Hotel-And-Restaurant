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
    public partial class frmCustomerDelete : Form
    {
        public frmCustomerDelete()
        {
            InitializeComponent();
        }
        CustomerPerson customer = new CustomerPerson();
        public void PassValue(CustomerPerson cust)
        {
            customer = cust;
        }

        private void frmCustomerDelete_Load(object sender, EventArgs e)
        {
            lblId.Text = customer.Id.ToString();
            lblCustomerName.Text = customer.CustomerName;
            lblCNIC.Text = customer.CNIC;
            lblEmail.Text = customer.Email;
            lblMobile.Text = customer.Mobile;
            lblCity.Text = customer.City;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete?", "D E L E T E", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Customer.DeleteCustomer(lblId.Text);
                this.Hide();
                frmCustomer f=new frmCustomer();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer f=new frmCustomer();
            f.ShowDialog();
            this.Close();
        }
    }
}
