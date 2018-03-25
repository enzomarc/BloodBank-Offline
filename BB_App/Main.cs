using System;
using System.Windows.Forms;

namespace BB_App
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
            LoadForm(new Views.Login());
        }

        #endregion

    }
}
