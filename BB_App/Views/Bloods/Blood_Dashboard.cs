using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB_App.Views.Bloods
{
    public partial class Blood_Dashboard : UserControl
    {
        public Blood_Dashboard()
        {
            InitializeComponent();
        }

        private void nextBlood_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(235, 235, 235);
        }

        private void nextBlood_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.WhiteSmoke;        
        }
    }
}
