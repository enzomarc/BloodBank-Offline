using System; using static BB_App.Helpers.FormsHelpers;
using System.Windows.Forms;
using BB_App.Core.Properties;

namespace BB_App.Core.Views.Donations
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
            LoadForm(((Main)ParentForm).frmContainer, new DonationsForm());
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new NewUser());
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new RegisteredUser(false));
        }

        #endregion
    }
}