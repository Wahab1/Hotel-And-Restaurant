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
    public partial class frmRecipes : Form
    {
        List<RecipesMember> recipes=new List<RecipesMember>();
        public frmRecipes()
        {
            InitializeComponent();
        }

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Iris", new Font("Goudy Old Style", 62, FontStyle.Italic), Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString("Hotel And Resturant", new Font("Goudy Old Style", 50, FontStyle.Italic), Brushes.Black, new Point(120, 125));
            e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                               new Point(0, 200));
            e.Graphics.DrawString("Item_Name", new Font("Goudy Old Style", 22, FontStyle.Italic), Brushes.Black,
                                  new Point(50, 250));
            e.Graphics.DrawString("Item_Price", new Font("Goudy Old Style", 22, FontStyle.Italic), Brushes.Black,
                                  new Point(350, 250));
            e.Graphics.DrawString("Item_Quantity", new Font("Goudy Old Style", 22, FontStyle.Italic), Brushes.Black,
                                  new Point(650, 250));
            e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                 new Point(0, 275));
            int i = 325;
            int j = 1;
            foreach (var res in recipes)
            {
                e.Graphics.DrawString(j + "- " + res.Name, new Font("Goudy Old Style", 22, FontStyle.Italic), Brushes.Black,
                                      new Point(50, i));
                e.Graphics.DrawString(res.Price, new Font("Goudy Old Style", 22, FontStyle.Italic), Brushes.Black,
                                      new Point(375, i));
                e.Graphics.DrawString(res.Quantity, new Font("Goudy Old Style", 22, FontStyle.Italic), Brushes.Black,
                                      new Point(660, i));
                e.Graphics.DrawString(res.Unit, new Font("Goudy Old Style", 22, FontStyle.Italic), Brushes.Black,
                                     new Point(710, i));
                i += 50;
                j += 1;
            }
            e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                new Point(0, 750));
            e.Graphics.DrawString("Total Amount:", new Font("Goudy Old Style", 28, FontStyle.Italic), Brushes.Black,
                                 new Point(400, 800));
            e.Graphics.DrawString(txttAmount.Text + " Rs", new Font("Goudy Old Style", 28, FontStyle.Italic), Brushes.Black,
                                new Point(650, 800));

            e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                  new Point(0, 850));
            e.Graphics.DrawString("Designed And Programmed By       ", new Font("Goudy Old Style", 26, FontStyle.Italic), Brushes.Black, new Point(100, 875));
            e.Graphics.DrawString(" Waqar Ahmad Ghori        ", new Font("Goudy Old Style", 26, FontStyle.Italic), Brushes.Black, new Point(500, 925));
            e.Graphics.DrawString("BS-11-43", new Font("Goudy Old Style", 26, FontStyle.Italic), Brushes.Black, new Point(510, 975));
            e.Graphics.DrawString("Bahauddin Zakariya University,Multan", new Font("Goudy Old Style", 26, FontStyle.Italic), Brushes.Black, new Point(310, 1025));
            recipes.Clear();
        }

        private void btntamount_Click(object sender, EventArgs e)
        {
            double total = 0.0;
            if (chkck.Checked && txtqck.Text != "")
            {
                total += Convert.ToDouble(lblpck.Text) * Convert.ToDouble(txtqck.Text);
                recipes.Add(new RecipesMember(){ Name = lblck.Text, Price = lblpck.Text, Quantity = txtqck.Text, Unit = "Kilogram" });
            }
            if (chkmk.Checked && txtqmk.Text != "")
            {
                total += Convert.ToDouble(lblpmk.Text) * Convert.ToDouble(txtqmk.Text);
                recipes.Add(new RecipesMember() { Name = lblmk.Text, Price = lblpmk.Text, Quantity = txtqmk.Text, Unit = "Kilogram" });
            }
            if (chkbk.Checked && txtqbk.Text != "")
            {
                total += Convert.ToDouble(lblpbk.Text) * Convert.ToDouble(txtqbk.Text);
                recipes.Add(new RecipesMember() { Name = lblbk.Text, Price = lblpbk.Text, Quantity = txtqbk.Text, Unit = "Kilogram" });
            }
            if (chkff.Checked && txtqff.Text != "")
            {
                total += Convert.ToDouble(lblpff.Text) * Convert.ToDouble(txtqff.Text);
                recipes.Add(new RecipesMember() { Name = lblff.Text, Price = lblpff.Text, Quantity = txtqff.Text, Unit = "Kilogram" });
            }
            if (chkb.Checked && txtqb.Text != "")
            {
                total += Convert.ToDouble(lblpb.Text) * Convert.ToDouble(txtqb.Text);
                recipes.Add(new RecipesMember() { Name = lblb.Text, Price = lblpb.Text, Quantity = txtqb.Text, Unit = "Plate" });
            }
            if (chkd.Checked && txtqd.Text != "")
            {
                total += Convert.ToDouble(lblpd.Text) * Convert.ToDouble(txtqd.Text);
                recipes.Add(new RecipesMember() { Name = lbld.Text, Price = lblpd.Text, Quantity = txtqd.Text, Unit = "Letter" });
            }
            if (chkv.Checked && txtqv.Text != "")
            {
                total += Convert.ToDouble(lblpv.Text) * Convert.ToDouble(txtqv.Text);
                recipes.Add(new RecipesMember() { Name = lblv.Text, Price = lblpv.Text, Quantity = txtqv.Text, Unit = "Plate" });
            }
            if (chkds.Checked && txtqds.Text != "")
            {
                total += Convert.ToDouble(lblpds.Text) * Convert.ToDouble(txtqds.Text);
                recipes.Add(new RecipesMember() { Name = lblds.Text, Price = lblpds.Text, Quantity = txtqds.Text, Unit = "Cup" });
            }
            if (chkj.Checked && txtqj.Text != "")
            {
                total += Convert.ToDouble(lblpj.Text) * Convert.ToDouble(txtqj.Text);
                recipes.Add(new RecipesMember() { Name = lblj.Text, Price = lblpj.Text, Quantity = txtqj.Text, Unit = "Glass" });
            }
            txttAmount.Text = total.ToString();
            chkck.CheckState = CheckState.Unchecked;
            chkmk.CheckState = CheckState.Unchecked;
            chkbk.CheckState = CheckState.Unchecked;
            chkff.CheckState = CheckState.Unchecked;
            chkb.CheckState = CheckState.Unchecked;
            chkd.CheckState = CheckState.Unchecked;
            chkv.CheckState = CheckState.Unchecked;
            chkds.CheckState = CheckState.Unchecked;
            chkj.CheckState = CheckState.Unchecked;
            txtqck.Text = "1";
            txtqmk.Text = "1";
            txtqbk.Text = "1";
            txtqff.Text = "1";
            txtqb.Text = "1";
            txtqd.Text = "1";
            txtqv.Text = "1";
            txtqds.Text = "1";
            txtqj.Text = "1";
        }

        private void ppd_Load(object sender, EventArgs e)
        {
            
        }

        private void btnvo_Click(object sender, EventArgs e)
        {
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void frmRecipes_Load(object sender, EventArgs e)
        {
            //List<string> customer = BookingRoom.GetCustomer();
            List<string> customer = BookingRoom.RemoveCustomer();
            foreach (var item in customer)
            {
                cmbCustomer.Items.Add(item);
            }
            #region RecipesRate
            List<RecipesMember> recipes = Recipies.Recipes();
            foreach (var item in recipes)
            {
                if (item.Name == "Beef_Karhai")
                    lblpbk.Text = item.ItemRate.ToString();
                else if (item.Name == "Biryani")
                    lblpb.Text = item.ItemRate.ToString();
                else if (item.Name == "Chiken_Karhai")
                    lblpck.Text = item.ItemRate.ToString();
                else if (item.Name == "Dessert")
                    lblpds.Text = item.ItemRate.ToString();
                else if (item.Name == "Drink")
                    lblpd.Text = item.ItemRate.ToString();
                else if (item.Name == "Fry_Fish")
                    lblpff.Text = item.ItemRate.ToString();
                else if (item.Name == "Mutton_Karhai")
                    lblpmk.Text= item.ItemRate.ToString();
                else if (item.Name == "Juice")
                    lblpj.Text = item.ItemRate.ToString();
                else if (item.Name == "Vegetable")
                    lblpv.Text = item.ItemRate.ToString();

            }
        }
            #endregion

        private void btnchange_Click(object sender, EventArgs e)
        {
            int price = 0;
            bool check = int.TryParse(txtip.Text, out price);
            if (check && cmbin.SelectedIndex != -1)
            {
                Recipies.ChangeRate(cmbin.Text, price);
                MessageBox.Show("Price has been changed", "C H A N G E", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
                frmRecipes f = new frmRecipes();
                f.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Invalid Input", "E R R O R", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex != -1 && txttAmount.Text != "0")
            {
                int custId = BookingRoom.GetCustomerId(cmbCustomer.Text);
                Recipies.AddResturantRecord(custId, dtpDate.Value, Convert.ToInt32(txttAmount.Text));
                MessageBox.Show("Data Has been Saved", "S A V E ",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCustomer.SelectedIndex = -1;
                txttAmount.Text = "0";
                cmbCustomer.Focus();
            }
            else
            {
                MessageBox.Show("Invalid Input", "E R R O R", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }

        }

        private void btno_Click(object sender, EventArgs e)
        {
            ppd.Document = pd;
            pd.Print();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReceptionMenu f=new frmReceptionMenu();
            f.ShowDialog();
            this.Close();
        }

    }
}
