using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Iris
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            List<string> Role = User.RoleLoad();
            foreach (var item in Role)
            {
                cmbRole.Items.Add(item);
            }
            DataSet ds = User.UserLoad();
            dgvUser.DataSource = ds.Tables["User"].DefaultView;
            dgvUser.Columns[0].Visible = false;
            dgvUser.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserPerson user=new UserPerson();
            if (txtUserName.Text.Trim() == "")
            {
                lblErrorUserName.Text = "User_Name is required.";
            }
            else
            {
                user.User_Name = txtUserName.Text.Trim();
                lblErrorUserName.Text = "";
            }
            if (txtPassword.Text == "")
            {
                lblErrorPassword.Text = "Password is required";
            }
            else
            {
                user.Password = txtPassword.Text;
                lblErrorPassword.Text = "";
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

                    user.mobile = string.Concat(cmbsno.Text, " ", number.ToString());
                    lblErrorMobile.Text = "";
                }
                else
                {
                    lblErrorMobile.Text = "Invalid Number";
                    cmbsno.SelectedIndex = -1;
                    txtnumber.Text = "";
                }
            }
            if (txtfcnci.Text == "" || txtmcnic.Text == "" || txtlcnic.Text=="")
            {
                lblErrorCNIC.Text = "CNIC is required.";
            }
            else
            {
                Int32 fcnic = 0, lcnic = 0, mcnic = 0;
                bool checkfcnic, checkmcnic, checklcnic;
                checkfcnic = int.TryParse(txtfcnci.Text, out fcnic);
                checkmcnic = int.TryParse(txtmcnic.Text, out mcnic);
                checklcnic = int.TryParse(txtlcnic.Text, out lcnic);
                if (checkfcnic && checkmcnic && checklcnic)
                {
                    user.CNIC = string.Concat(fcnic.ToString() + "-" + mcnic.ToString()
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
                user.Email = add.Address;
                lblErrorEmail.Text = "";
            }
            catch
            {
                lblErrorEmail.Text = "Email is required.";
                txtEmail.Text = "";
            }
            if (cmbRole.SelectedIndex == -1)
            {
                lblErrorRole.Text = "Role is required";
            }
            else
            {
                user.RoleId = User.RoleId(cmbRole.Text);
                lblErrorRole.Text = "";
            }

            if (txtUserName.Text.Trim() != "" && txtPassword.Text != "" &&
                cmbsno.SelectedIndex != -1 && txtnumber.Text != "" &&
                txtfcnci.Text != "" && txtmcnic.Text != "" && txtlcnic.Text != "" &&
                txtEmail.Text != "" && cmbRole.SelectedIndex != -1)
            {
                User.AddUser(user);
                MessageBox.Show("New User has been added", "S A V E",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtfcnci.Text = "";
                txtmcnic.Text = "";
                txtlcnic.Text = "";
                cmbsno.SelectedIndex = -1;
                txtnumber.Text = "";
                txtEmail.Text = "";
                cmbRole.SelectedIndex = -1;
            }
            DataSet ds = User.UserLoad();
            dgvUser.DataSource = ds.Tables["User"].DefaultView;
            dgvUser.Columns[0].Visible = false;
            dgvUser.ReadOnly = true;

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.Rows.Count>1)
            {

                UserPerson user = new UserPerson();
                user.Id = (int) dgvUser.SelectedRows[0].Cells[0].Value;
                user.User_Name = (string) dgvUser.SelectedRows[0].Cells[1].Value;
                user.Password = (string) dgvUser.SelectedRows[0].Cells[2].Value;
                user.mobile = (string) dgvUser.SelectedRows[0].Cells[3].Value;
                user.CNIC = (string) dgvUser.SelectedRows[0].Cells[4].Value;
                user.Email = (string) dgvUser.SelectedRows[0].Cells[5].Value;
                user.Role = (string) dgvUser.SelectedRows[0].Cells[6].Value;
                this.Hide();
                frmDeleteUser f = new frmDeleteUser();
                f.PassValue(user);
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnSave_Leave(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminMenu f=new frmAdminMenu();
            f.ShowDialog();
            this.Close();
        }
    }
}
