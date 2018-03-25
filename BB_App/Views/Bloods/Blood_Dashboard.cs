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

        private struct Blood
        {
            public string Name;
            public int Value;
        }

        private int _x;

        #endregion

        #region UI Methods

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
                bloodLabel.Text = Commons.Format(GoNextBlood().Name);
                unitLabel.Text = GoNextBlood().Value.ToString() + @" Bottles";
            }
            catch { }
        }

        private void previousBlood_Click(object sender, EventArgs e)
        {
            try
            {
                bloodLabel.Text = Commons.Format(GoPreviousBlood().Name);
                unitLabel.Text = GoPreviousBlood().Value.ToString() + " Bottles";
            }
            catch { }
        }

        private void bloodLabel_Click(object sender, EventArgs e)
        {
            Bl.LoadBloods();
            MessageBox.Show(Bl.BloodsList.Count.ToString());
        }

        #endregion

        #region Methods

        private Blood GoNextBlood()
        {
            var blood = new Blood();

            try
            {
                if (Bl.BloodsList.Count >= 0)
                {
                    if (_x >= Bl.BloodsList.Count)
                        _x = 0;

                    blood.Name = Bl.BloodsList[_x].BloodGroup;
                    blood.Value = Bl.BloodsList[_x].BloodUnits;
                    _x++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get next bloodgroup. Error is : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return blood;
        }

        private Blood GoPreviousBlood()
        {
            var blood = new Blood();

            try
            {
                if (Bl.BloodsList.Count >= 0)
                {
                    if (_x >= Bl.BloodsList.Count)
                        _x = 0;

                    blood.Name = Bl.BloodsList[_x].BloodGroup;
                    blood.Value = Bl.BloodsList[_x].BloodUnits;
                    _x--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get next bloodgroup. Error is : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return blood;
        }

        #endregion

    }
}
