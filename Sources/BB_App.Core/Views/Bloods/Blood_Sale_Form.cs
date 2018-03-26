using System;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;

namespace BB_App.Core.Views.Bloods
{
    public partial class Blood_Sale_Form : UserControl
    {
        public Blood_Sale_Form()
        {
            InitializeComponent();
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            if (bloodGD.Text != "Blood Group" && dateTime.Value != null && numberUnits.Value > 0)
            {
                var price = Convert.ToInt32(priceLabel.Text.Split(' ')[0]);
                BloodSale.saleBlood(Commons.Unformat(bloodGD.Text).ToUpper(), dateTime.Value, (int) numberUnits.Value,
                    price);
                MessageBox.Show("Blood successfully saled.", "Blood Sale", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ((Main) ParentForm).LoadForm(new BloodDashboard());
            }
            else
            {
                MessageBox.Show("Error occured. Please check all fields before clicking the button.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region UI Methods

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Resources.Delete_Hover_18px;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Resources.Delete_18px;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.Image = Resources.Left_Hover_16px;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.Image = Resources.Left_15px;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm)?.LoadForm(new BloodDashboard());
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            bloodGD.Text = e.ClickedItem.Text;
            numberUnits.Maximum = Models.Bloods.GetUnits(Commons.Unformat(e.ClickedItem.Text).ToLower());
        }

        private void unitsPrice_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = Commons.TotalPrice((int) numberUnits.Value, (int) unitsPrice.Value) + @" Frcs";
        }

        #endregion UI Methods
    }
}