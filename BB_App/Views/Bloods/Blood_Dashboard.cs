using System;
using System.Drawing;
using System.Windows.Forms;
using static BB_App.Models.Commons;
using Bl = BB_App.Models.Bloods;

namespace BB_App.Views.Bloods
{
    public partial class BloodDashboard : UserControl
    {
        public BloodDashboard()
        {
            InitializeComponent();
        }

        #region Fields

        private int counter = -1;

        #endregion Fields

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
            ((Main)ParentForm).LoadForm(new BB_App.Views.Dashboard());
        }

        private void nextBlood_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(235, 235, 235);
        }

        private void nextBlood_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.WhiteSmoke;
        }

        private void nextBlood_Click(object sender, EventArgs e)
        {
            try
            {
                var item = GoNextBlood();
                bloodLabel.Text = Format(item.BloodGroup);
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
                bloodLabel.Text = Format(item.BloodGroup);
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

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new Blood_Purchase_Form());
        }

        private void BloodDashboard_Load(object sender, EventArgs e)
        {
            Bl.LoadBloods();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ((Main)ParentForm).LoadForm(new Blood_Sale_Form());
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            ((Main)ParentForm).LoadForm(new Sales_Report_Form());
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            ((Main)ParentForm).LoadForm(new Purchases_Report_Form());
        }
    }
}