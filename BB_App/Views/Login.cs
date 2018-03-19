using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using BB_App.Models;

namespace BB_App.Views
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Methods

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (this.username.Text == "Nom d'utilisateur ...")
            {
                this.username.Clear();
                this.username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (this.username.Text == "")
            {
                this.username.Text = "Nom d'utilisateur ...";
                this.username.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (this.password.Text == "Mot de passe ...")
            {
                this.password.Clear();
                this.password.UseSystemPasswordChar = true;
                this.password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (this.password.Text == "")
            {
                this.password.UseSystemPasswordChar = false;
                this.password.Text = "Mot de passe ...";
                this.password.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new Views.Dashboard());

            //if (username.Text == "admin" && password.Text == "root")
                
            //else
               // MessageBox.Show("Wrong username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void logo_MouseEnter(object sender, EventArgs e)
        {
            logo.Image = Properties.Resources.Heart_Red_96px;
        }

        private void logo_MouseLeave(object sender, EventArgs e)
        {
            logo.Image = Properties.Resources.Heart_96px;
        }

        #endregion

    }
}
