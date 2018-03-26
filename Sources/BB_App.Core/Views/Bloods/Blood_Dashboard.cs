using System;
using static BB_App.Helpers.FormsHelpers;
using System.Drawing;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using Bl = BB_App.Core.Models.Bloods;

namespace BB_App.Core.Views.Bloods
{
    public partial class BloodDashboard : UserControl
    {
        #region Fields

        private int counter = -1;

        #endregion Fields

        public BloodDashboard()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new Blood_Purchase_Form());
        }

        private void BloodDashboard_Load(object sender, EventArgs e)
        {
            Bl.LoadBloods();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new Blood_Sale_Form());
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new Sales_Report_Form());
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new Purchases_Report_Form());
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
            LoadForm(((Main)ParentForm).frmContainer, new Dashboard());
        }

        private void nextBlood_MouseEnter(object sender, EventArgs e)
        {
            ((Control) sender).BackColor = Color.FromArgb(235, 235, 235);
        }

        private void nextBlood_MouseLeave(object sender, EventArgs e)
        {
            ((Control) sender).BackColor = Color.WhiteSmoke;
        }

        private void nextBlood_Click(object sender, EventArgs e)
        {
            try
            {
                var item = GoNextBlood();
                bloodLabel.Text = Commons.Format(item.BloodGroup);
                unitLabel.Text = item.BloodUnits + @" Bottles";
            }
            catch
            {
                // ignored
            }
        }

        private void previousBlood_Click(object sender, EventArgs e)
        {
            try
            {
                var item = GoPreviousBlood();
                bloodLabel.Text = Commons.Format(item.BloodGroup);
                unitLabel.Text = item.BloodUnits + @" Bottles";
            }
            catch
            {
                // ignored
            }
        }

        private void bloodLabel_Click(object sender, EventArgs e)
        {
            Bl.LoadBloods();
            MessageBox.Show(Bl.BloodsList.Count.ToString());
        }

        #endregion UI Methods

        #region Methods

        private Bl.Blood GoNextBlood()
        {
            Bl.Blood blood;

            if (counter < 8)
            {
                blood = Bl.BloodsList[++counter];
            }
            else
            {
                counter = -1;
                blood = Bl.BloodsList[++counter];
            }

            return blood;
        }

        private Bl.Blood GoPreviousBlood()
        {
            Bl.Blood blood;

            if (counter > 0)
            {
                blood = Bl.BloodsList[--counter];
            }
            else
            {
                counter = 9;
                blood = Bl.BloodsList[--counter];
            }

            return blood;
        }

        #endregion Methods
    }
}