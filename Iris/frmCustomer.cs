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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        #region Load
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            DataSet ds = Customer.GetCustomer();
            dgvCustomer.DataSource = ds.Tables["Customer"].DefaultView;
            dgvCustomer.Columns[0].Visible = false;
            dgvCustomer.ReadOnly = true;
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Validation
            CustomerPerson customer=new CustomerPerson();
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
                Int32 number = 0;
                bool checknumber = int.TryParse(txtnumber.Text, out number);
                if (checknumber)
                {

                    customer.Mobile = string.Concat(cmbsno.Text, " ", number.ToString());
                    lblErrorMobile.Text = "";
                }
                else
                {
                    lblErrorMobile.Text = "Invalid Number";
                    cmbsno.SelectedIndex = -1;
                    txtnumber.Text = "";
                }
            }
            if (txtfcnci.Text == "" || txtmcnic.Text == "" || txtlcnic.Text == "")
            {
                lblErrorCNIC.Text = "CNIC is required.";
            }
            else
            {
                Int32 fcnic = 0, lcnic = 0, mcnic=0;
                bool checkfcnic, checkmcnic, checklcnic;
                checkfcnic = int.TryParse(txtfcnci.Text,out fcnic);
                checkmcnic = int.TryParse(txtmcnic.Text, out mcnic);
                checklcnic = int.TryParse(txtlcnic.Text, out lcnic);
                if (checkfcnic && checkmcnic && checklcnic)
                {
                    customer.CNIC = string.Concat(fcnic.ToString() + "-" + mcnic.ToString()
                                                  , "-", lcnic.ToString());
                    lblErrorCNIC.Text = "";
                }
                else
                {
                    lblErrorCNIC.Text = "Invalid CNIC ";

                    txtfcnci.Text = "";
                    txtmcnic.Text = "";
                    txtlcnic.Text = "";
                }
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
                txtEmail.Text = "";
            }
            #endregion
            #region Save
            if (txtCustomerName.Text != "" && txtnumber.Text != "" && txtCity.Text != ""
                && txtAddress.Text != "" && cmbsno.SelectedIndex != -1 && txtEmail.Text != ""
                && txtfcnci.Text != "" && txtmcnic.Text != "" && txtlcnic.Text != "")
            {
                Customer.AddCustomer(customer);
                MessageBox.Show("Data has been save..", "S A V E", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds = Customer.GetCustomer();
                dgvCustomer.DataSource = ds.Tables["Customer"].DefaultView;
                dgvCustomer.Columns[0].Visible = false;
                dgvCustomer.ReadOnly = true;
                txtCustomerName.Text = "";
                txtfcnci.Text = "";
                txtmcnic.Text = "";
                txtlcnic.Text = "";
                cmbsno.SelectedIndex = -1;
                txtnumber.Text = "";
                txtEmail.Text = "";
                txtCity.Text = "";
                txtAddress.Text = "";
            }
            #endregion
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.Rows.Count > 1)
            {

                CustomerPerson customer = new CustomerPerson();
                customer.Id = (int)dgvCustomer.SelectedRows[0].Cells[0].Value;
                customer.CustomerName = (string)dgvCustomer.SelectedRows[0].Cells[1].Value;
                customer.CNIC = (string)dgvCustomer.SelectedRows[0].Cells[2].Value;
                customer.Mobile = (string)dgvCustomer.SelectedRows[0].Cells[3].Value;
                customer.Email = (string)dgvCustomer.SelectedRows[0].Cells[4].Value;
                customer.Address = (string)dgvCustomer.SelectedRows[0].Cells[5].Value;
                customer.City = (string)dgvCustomer.SelectedRows[0].Cells[6].Value;
                this.Hide();
                frmOption f = new frmOption();
                f.PassValue(customer);
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnSave_Leave(object sender, EventArgs e)
        {
            txtCustomerName.Focus();
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
