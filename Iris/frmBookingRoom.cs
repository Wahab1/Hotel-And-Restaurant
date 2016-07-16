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
    public partial class frmBookingRoom : Form
    {
        public frmBookingRoom()
        {
            InitializeComponent();
        }

        private void frmBookingRoom_Load(object sender, EventArgs e)
        {
            DataSet ds = BookingRoom.DatLoad();
            dgvBooking.DataSource = ds.Tables["Booking"].DefaultView;
            dgvBooking.Columns[0].Visible = false;
            List<string> Customer = BookingRoom.GetCustomer();
            List<int> RoomNumber = BookingRoom.GetRoomNumber();
            foreach (var item in Customer)
            {
                cmbCustomer.Items.Add(item);
            }
            foreach (var item in RoomNumber)
            {
                cmbRoomNumber.Items.Add(item);
            }
            List<string>customerRemove=BookingRoom.RemoveCustomer();
            foreach (var item in customerRemove)
            {
                cmbCustomer.Items.Remove(item);
            }

            List<int> RoomRemove = BookingRoom.RemoveRoomNumber();
            foreach (var item in RoomRemove)
            {
             cmbRoomNumber.Items.Remove(item);   
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BookingRoomMember book=new BookingRoomMember();
            if (cmbCustomer.SelectedIndex == -1)
            {
                lblErrorCustomer.Text = "Customer is required";
            }
            else
            {
                book.CustomerId = BookingRoom.GetCustomerId(cmbCustomer.Text);
                lblErrorCustomer.Text = "";
            }
            if (cmbRoomNumber.SelectedIndex == -1)
            {
                lblErrorRoom.Text = "RoomNumber is required";
            }
            else
            {
                book.RoomId = BookingRoom.GetRoomId(cmbRoomNumber.Text);
                lblErrorRoom.Text = "";
            }
            book.Date = dtpBooking.Value;
            if (cmbCustomer.SelectedIndex != -1 && cmbRoomNumber.SelectedIndex != -1)
            {
                BookingRoom.AddBookingRoom(book);
                MessageBox.Show("Data has been Saved", "S A V E",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds = BookingRoom.DatLoad();
                dgvBooking.DataSource = ds.Tables["Booking"].DefaultView;
                dgvBooking.Columns[0].Visible = false;
                cmbCustomer.SelectedIndex = -1;
                cmbRoomNumber.SelectedIndex = -1;

            }
        }

        private void btnSave_Leave(object sender, EventArgs e)
        {
            cmbCustomer.Focus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReceptionMenu f = new frmReceptionMenu();
            f.ShowDialog();
            this.Close();
        }

        private void ppd_Load(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ppd.Document = pd;
            ppd.ShowDialog();

        }

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Iris", new Font("Goudy Old Style", 62, FontStyle.Italic), Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString("Hotel And Resturant", new Font("Goudy Old Style", 50, FontStyle.Italic), Brushes.Black, new Point(120, 125));
            e.Graphics.DrawString(dtpSearch.Value.ToShortDateString(), new Font("Goudy Old Style", 20, FontStyle.Italic),
                Brushes.Black, new Point(670, 170));
            e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                  new Point(0, 200));
            e.Graphics.DrawString("Customer Name", new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                  new Point(0, 250));
            e.Graphics.DrawString(" CNIC", new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                  new Point(200, 250));
            e.Graphics.DrawString("Room No#", new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                  new Point(325, 250));
            e.Graphics.DrawString("Room Rent", new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                 new Point(450, 250));
            e.Graphics.DrawString("Laundry Bill", new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                new Point(560, 250));
            e.Graphics.DrawString("Resturant Bill", new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                new Point(700, 250));
            
            e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 14, FontStyle.Italic), Brushes.Black,
                                 new Point(0, 275));

            List<BookingRoomMember> list = BookingRoom.Preview(dtpSearch.Value);
            int j = 325;
            foreach (var item in list)
            {
                e.Graphics.DrawString(item.CustomerName, new Font("Goudy Old Style",18, FontStyle.Italic), Brushes.Black,
                               new Point(0, j-25));
                e.Graphics.DrawString(item.CustomerCNIC, new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                      new Point(125, j));
                e.Graphics.DrawString(item.RoomNo.ToString(), new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                      new Point(375, j));
                e.Graphics.DrawString(item.RoomRent.ToString(), new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                     new Point(475, j));
                e.Graphics.DrawString(item.LaundryBill.ToString(), new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                     new Point(580, j));
                e.Graphics.DrawString(item.ResturantBill.ToString(), new Font("Goudy Old Style", 18, FontStyle.Italic), Brushes.Black,
                                     new Point(720, j));
                j += 75;

            }
            e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                 new Point(0, 975));
            e.Graphics.DrawString("Designed And Programmed By       ", new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black, new Point(100, 1000));
            e.Graphics.DrawString(" Waqar Ahmad Ghori        ", new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black, new Point(500, 1025));
            e.Graphics.DrawString("BS-11-43", new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black, new Point(510, 1050));
            e.Graphics.DrawString("Bahauddin Zakariya University,Multan", new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black, new Point(310, 1075));
            
        }

        private void brnPrint_Click(object sender, EventArgs e)
        {
            pd.Print();
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
