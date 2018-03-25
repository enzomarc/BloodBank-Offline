using System;
using System.Windows.Forms;
using BB_App.Models;
using static BB_App.Models.Bloods;
using static BB_App.Models.Commons;

namespace BB_App.Views.Bloods
{
    public partial class Blood_Purchase_Form : UserControl
    {
        public Blood_Purchase_Form()
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
        }

        #endregion UI Methods

        #region Methods

        #endregion Methods

        private void unitsPrice_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = TotalPrice((int)numberUnits.Value, (int)unitsPrice.Value).ToString() + @" Frcs";
        }
    
        private void purchaseBtn_Click(object sender, EventArgs e)
        {

            if (bloodGD.Text != "Blood Group" && dateTime.Value != null)
            {
                var price = Convert.ToInt32(priceLabel.Text.Split(' ')[0]);
                BloodPurchase.PurchaseBlood(Unformat(bloodGD.Text).ToUpper(), dateTime.Value, (int)numberUnits.Value, price);
            }

        }
    }
}