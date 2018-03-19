using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms; using BB_App.Models;

namespace BB_App.Views.Donations
{
    public partial class Add_Type : UserControl
    {
        public Add_Type()
        {
            InitializeComponent();
        }

        #region Methods

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
            ((Main)this.ParentForm).loadForm(new Views.DonationsForm());
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new Views.Donations.New_User());
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new Views.Donations.Registered_User(false));
        }

        #endregion

    }
}
