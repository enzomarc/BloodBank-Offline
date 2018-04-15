using System;
using System.Windows.Forms;
using BB_App.Core.Views.Administration;
using static BB_App.Helpers.FormsHelpers;

namespace BB_App.Core.Views.Administration
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm).frmContainer, new UsersManagement());
        }
    }
}
