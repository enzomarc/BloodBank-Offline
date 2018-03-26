using System;
using static BB_App.Helpers.FormsHelpers;
using System.Windows.Forms;
using BB_App.Core.Views;

namespace BB_App.Core
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Methods

        private void Main_Load(object sender, EventArgs e)
        {
            LoadForm(frmContainer, new Login());
        }

        #endregion
    }
}