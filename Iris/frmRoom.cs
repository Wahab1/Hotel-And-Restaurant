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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            txtRoomNumber.Text = Room.RoomNumber().ToString();
            List<string> list = Room.Owner();
            foreach (var item in list)
            {
                cmbOwner.Items.Add(item);
            }
            DataSet ds = Room.DataLoad();
            dgvRoom.DataSource = ds.Tables["Room"];
            dgvRoom.Columns[0].Visible = false;
            dgvRoom.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Validation
            RoomMember room=new RoomMember();
            room.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
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
                    txtRoomRent.Text = "";
                }
            }
            if (cmbOwner.SelectedIndex == -1)
            {
                lblErrorOwner.Text = "Owner is required ";
            }
            else
            {
                room.OwnerId = Room.OwnerId(cmbOwner.Text);
                lblErrorOwner.Text = "";
            }
            #endregion
            #region Save
            if (cmbRoomType.SelectedIndex != -1 && txtRoomRent.Text != ""
                && txtRoomNumber.Text != "" && cmbOwner.SelectedIndex != -1)
            {
                Room.AddRoom(room);
                MessageBox.Show("Data has been Added", "S A V E",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds = Room.DataLoad();
                dgvRoom.DataSource = ds.Tables["Room"];
                dgvRoom.Columns[0].Visible = false;
                dgvRoom.ReadOnly = true;
                cmbOwner.SelectedIndex = -1;
                cmbRoomType.SelectedIndex = -1;
                txtRoomRent.Text = "";
                txtRoomNumber.Text = Room.RoomNumber().ToString();
            }
            #endregion
        }
        #region CellClick
        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomMember room=new RoomMember();
           room.Id=(int)dgvRoom.SelectedRows[0].Cells[0].Value;
           room.RoomType = (string)dgvRoom.SelectedRows[0].Cells[3].Value;
           room.RoomRent = (int)dgvRoom.SelectedRows[0].Cells[2].Value;
            this.Hide();
            frmUpdateRoom f=new frmUpdateRoom();
            f.PassValue(room);
            f.ShowDialog();
            this.Close();
        }
        #endregion

        private void btnSave_Leave(object sender, EventArgs e)
        {
            cmbRoomType.Focus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminMenu f=new frmAdminMenu();
            f.ShowDialog();
            this.Close();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomType.Text == "Single")
                txtRoomRent.Text = "3000";
            else if(cmbRoomType.Text == "Double")
                txtRoomRent.Text = "5000";
        }
    }
}
