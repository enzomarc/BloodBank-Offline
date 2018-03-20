using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BB_App.Models;
using Bl = BB_App.Models.Bloods;

namespace BB_App.Views.Bloods
{
    public partial class Blood_Dashboard : UserControl
    {
        public Blood_Dashboard()
        {
            InitializeComponent();
        }

        #region Fields

        struct blood
        {
            public string name;
            public int value;
        }

        int x = 0;

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
                bloodLabel.Text = Commons.Format(goNextBlood().name);
                unitLabel.Text = goNextBlood().value.ToString() + " Bottles";
            }
            catch { }
        }

        private void previousBlood_Click(object sender, EventArgs e)
        {
            try
            {
                bloodLabel.Text = Commons.Format(goPreviousBlood().name);
                unitLabel.Text = goPreviousBlood().value.ToString() + " Bottles";
            }
            catch { }
        }

        private void bloodLabel_Click(object sender, EventArgs e)
        {
            Bl.loadBloods();
            MessageBox.Show(Bl.BloodsList.Count.ToString());
        }

        #endregion

        #region Methods

        private blood goNextBlood()
        {
            blood _blood = new blood();

            try
            {
                if (Bl.BloodsList.Count >= 0)
                {
                    if (x >= Bl.BloodsList.Count)
                        x = 0;

                    _blood.name = Bl.BloodsList[x].BloodGroup;
                    _blood.value = Bl.BloodsList[x].BloodUnits;
                    x++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get next bloodgroup. Error is : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _blood;
        }

        private blood goPreviousBlood()
        {
            blood _blood = new blood();

            try
            {
                if (Bl.BloodsList.Count >= 0)
                {
                    if (x >= Bl.BloodsList.Count)
                        x = 0;

                    _blood.name = Bl.BloodsList[x].BloodGroup;
                    _blood.value = Bl.BloodsList[x].BloodUnits;
                    x--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get next bloodgroup. Error is : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _blood;
        }

        #endregion

    }
}
