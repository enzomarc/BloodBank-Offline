using System;
using System.Windows.Forms;
using BB_App.Models;
using static BB_App.Models.Commons;
using static BB_App.Models.Bloods;
using static BB_App.Models.BloodSale;

namespace BB_App.Views.Bloods
{
    public partial class Blood_Sale_Form : UserControl
    {
        public Blood_Sale_Form()
        {
            InitializeComponent();
        }

        #region UI Methods

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.Delete_Hover_18px;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.Delete_18px;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.Image = Properties.Resources.Left_Hover_16px;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.Image = Properties.Resources.Left_15px;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ((Main)ParentForm).LoadForm(new BloodDashboard());
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            bloodGD.Text = e.ClickedItem.Text;
            numberUnits.Maximum = getUnits(Unformat(e.ClickedItem.Text).ToLower());
        }

        private void unitsPrice_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = TotalPrice((int)numberUnits.Value, (int)unitsPrice.Value).ToString() + @" Frcs";
        }

        #endregion UI Methods

        private void saleBtn_Click(object sender, EventArgs e)
        {
            if (bloodGD.Text != "Blood Group" && dateTime.Value != null && numberUnits.Value > 0)
            {
                var price = Convert.ToInt32(priceLabel.Text.Split(' ')[0]);
                BloodSale.saleBlood(Unformat(bloodGD.Text).ToUpper(), dateTime.Value, (int)numberUnits.Value, price);
                MessageBox.Show("Blood successfully saled.", "Blood Sale", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ((Main)ParentForm).LoadForm(new BloodDashboard());
            }
            else
            {
                MessageBox.Show("Error occured. Please check all fields before clicking the button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
