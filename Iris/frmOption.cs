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
    public partial class frmOption : Form
    {
        public frmOption()
        {
            InitializeComponent();
        }
        CustomerPerson customer = new CustomerPerson();
        public void PassValue(CustomerPerson cust)
        {
            customer = cust;
        }

        private void rdUpdate_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerUpdate f=new frmCustomerUpdate();
            f.PassValue(customer);
            f.ShowDialog();
            this.Close();
        }

        private void rdDelete_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerDelete f = new frmCustomerDelete();
            f.PassValue(customer);
            f.ShowDialog();
            this.Close();
        }
    }

}
