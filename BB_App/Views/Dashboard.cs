using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BB_App.Models;
using BB_App.Views;

namespace BB_App.Views
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        #region Fields

        

        #endregion

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
            menuButton.Image = Properties.Resources.Menu_Hover_16px;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.Image = Properties.Resources.Menu_16px;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Menu.Show(menuButton, menuButton.Location);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            logo.Image = Properties.Resources.HeartMouse_Color_32px;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            logo.Image = Properties.Resources.HeartMouse_32px;
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new Login());
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new DonationsForm());
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            ((Main)ParentForm).loadForm(new SeekersForm());
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            ((Main)ParentForm).loadForm(new Bloods.Blood_Dashboard());
        }

        #endregion

    }
}
