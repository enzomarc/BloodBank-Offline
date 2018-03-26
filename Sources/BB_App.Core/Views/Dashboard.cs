using System;
using System.Windows.Forms;
using BB_App.Core.Properties;
using BB_App.Core.Views.Bloods;

namespace BB_App.Core.Views
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
            closeButton.Image = Resources.Delete_Hover_18px;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Resources.Delete_18px;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.Image = Resources.Menu_Hover_16px;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.Image = Resources.Menu_16px;
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
            logo.Image = Resources.HeartMouse_Color_32px;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            logo.Image = Resources.HeartMouse_32px;
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new Login());
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new DonationsForm());
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new SeekersForm());
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new BloodDashboard());
        }

        #endregion
    }
}