using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BB_App.Models;

namespace BB_App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Methods

        public void loadForm(Control frm)
        {

            try
            {
                this.frmContainer.Controls.Clear();
                frm.Dock = DockStyle.Fill;
                this.frmContainer.Controls.Add(frm);
            }
            catch { }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadForm(new Views.Login());
            Blood.initializeBank();
        }

        #endregion

    }
}
