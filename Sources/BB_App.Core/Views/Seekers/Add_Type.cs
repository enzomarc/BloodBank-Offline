using System;
using System.Windows.Forms;
using BB_App.Core.Properties;

namespace BB_App.Core.Views.Seekers
{
    public partial class AddType : UserControl
    {
        public AddType()
        {
            InitializeComponent();
        }

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
            ((Main) ParentForm).LoadForm(new SeekersForm());
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new NewUser());
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new RegisteredUser(false));
        }

        #endregion
    }
}