using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Iris
{
    public partial class frmCustomerUpdate : Form
    {
        CustomerPerson customer=new CustomerPerson();
        public frmCustomerUpdate()
        {
            InitializeComponent();
        }

        public void PassValue(CustomerPerson cust)
        {
            customer = cust;
        }

        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        {
            lblId.Text = customer.Id.ToString();
            txtCustomerName.Text = customer.CustomerName;
            txtfcnci.Text = customer.CNIC.Substring(0, 5);
            txtmcnic.Text = customer.CNIC.Substring(6, 7);
            txtlcnic.Text = customer.CNIC.Substring(8, 1);
            cmbsno.Text = customer.Mobile.Substring(0, 4);
            txtEmail.Text = customer.Email;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtnumber.Text = customer.Mobile.Substring(5, 7);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            CustomerPerson customer = new CustomerPerson();
            if (txtCustomerName.Text.Trim() == "")
            {
                lblErrorCustomerName.Text = "Customer_Name is required.";
            }
            else
            {
                customer.CustomerName = txtCustomerName.Text.Trim();
                lblErrorCustomerName.Text = "";
            }
            if (txtCity.Text == "")
            {
                lblErrorCity.Text = "City is required";
            }
            else
            {
                customer.City = txtCity.Text;
                lblErrorCity.Text = "";
            }
            if (txtAddress.Text == "")
            {
                lblErrorAddress.Text = "Address is required";
            }
            else
            {
                customer.Address = txtAddress.Text;
                lblErrorAddress.Text = "";
            }
            if (cmbsno.SelectedIndex == -1 || txtnumber.Text == "")
            {
                lblErrorMobile.Text = "Mobile is required.";
            }
            else
            {
                customer.Mobile = string.Concat(cmbsno.Text, " ", txtnumber.Text);
                lblErrorMobile.Text = "";
            }
            if (txtfcnci.Text == "" || txtmcnic.Text == "" || txtlcnic.Text == "")
            {
                lblErrorCNIC.Text = "CNIC is required.";
            }
            else
            {
                customer.CNIC = string.Concat(txtfcnci.Text + "-" + txtmcnic.Text
                    , "-", txtlcnic.Text);
                lblErrorCNIC.Text = "";
            }

            try
            {
                MailAddress add = new MailAddress(txtEmail.Text);
                customer.Email = add.Address;
                lblErrorEmail.Text = "";
            }
            catch
            {
                lblErrorEmail.Text = "Email is required.";
            }
            #endregion

            if (txtCustomerName.Text != "" && txtnumber.Text != "" && txtCity.Text != ""
                && txtAddress.Text != "" && cmbsno.SelectedIndex != -1 && txtEmail.Text != ""
                && txtfcnci.Text != "" && txtmcnic.Text != "" && txtlcnic.Text != "")
            {
                Customer.UpdateCustomer(customer, lblId.Text);
                MessageBox.Show("Data has been updated", "U P D A T E", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCustomer f=new frmCustomer();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReceptionMenu f=new frmReceptionMenu();
            f.ShowDialog();
            this.Close();
        }

    }
}
