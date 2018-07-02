using System;
using System.Windows.Forms;
using BB_App.Core.Properties;
using BB_App.Core.Views.Administration;
using static BB_App.Helpers.FormsHelpers;

namespace BB_App.Core.Views.Analyst
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
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

        #endregion

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new DonationsForm());
        }
    }
}
