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
    public partial class frmUpdateRoom : Form
    {
        RoomMember room=new RoomMember();
        public frmUpdateRoom()
        {
            InitializeComponent();
        }

        public void PassValue(RoomMember roomMember)
        {
            room = roomMember;
        }

        private void frmUpdateRoom_Load(object sender, EventArgs e)
        {
            lblId.Text = room.Id.ToString();
            txtRoomRent.Text = room.RoomRent.ToString();
            cmbRoomType.Text = room.RoomType;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            room.Id = Convert.ToInt32(lblId.Text);
            if (cmbRoomType.SelectedIndex == -1)
            {
                lblErrorRoomType.Text = "RoomType is required ";
            }
            else
            {
                room.RoomType = cmbRoomType.Text;
                lblErrorRoomType.Text = "";
            }
            if (txtRoomRent.Text == "")
            {
                lblErrorRoomRent.Text = "RoomRent is required ";
            }
            else
            {
                int rent = 0;
                bool conversion = int.TryParse(txtRoomRent.Text, out rent);
                if (conversion)
                {
                    room.RoomRent = rent;
                    lblErrorRoomRent.Text = "";
                }
                else
                {
                    lblErrorRoomRent.Text = "Invalid Input";
                    txtRoomRent.Text = room.RoomRent.ToString();
                }
                Room.UpdateRoom(room);
                MessageBox.Show("Data has Updated", "U P D A T E",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmRoom f=new frmRoom();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
