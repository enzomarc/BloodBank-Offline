using System;
using System.Drawing;
using System.Windows.Forms;
using BB_App.Models;
using Bl = BB_App.Models.Bloods;

namespace BB_App.Views.Bloods
{
    public partial class BloodDashboard : UserControl
    {
        public BloodDashboard()
        {
            InitializeComponent();
            Bl.LoadBloods();
        }

        #region Fields

        int counter = 0;

        #endregion Fields

        #region UI Methods

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
                counter = 0;
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
                counter = 8;
                blood = Bl.BloodsList[--counter];
            }

            return blood;
        }

        #endregion Methods
    }
}