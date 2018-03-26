using System;
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

        public void LoadForm(Control frm)
        {
            try
            {
                frmContainer.Controls.Clear();
                frm.Dock = DockStyle.Fill;
                frmContainer.Controls.Add(frm);
            }
            catch
            {
                // ignored
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadForm(new Login());
        }

        #endregion
    }
}