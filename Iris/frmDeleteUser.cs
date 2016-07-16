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
    public partial class frmDeleteUser : Form
    {
        private UserPerson person;
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        public void PassValue(UserPerson user)
        {
            person = user;
        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {
            lblDeleteId.Text = person.Id.ToString();
            lblDeleteUser.Text = person.User_Name;
            lblDeletePassword.Text = person.Password;
            lblDeleteMobile.Text = person.mobile;
            lblDeleteCNIC.Text = person.CNIC;
            lblDeleteEmail.Text = person.Email;
            lblDeleteRole.Text = person.Role;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Do you want to delete?", "D E L E T E", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                User.DeleteUser(person.Id);
                this.Hide();
                frmUser f=new frmUser();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser f = new frmUser();
            f.ShowDialog();
            this.Close();
        }
    }
}
