using System;
using System.Drawing;
using System.Windows.Forms;
using BB_App.Core.Properties;

namespace BB_App.Core.Views
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
            if (username.Text != "Nom d'utilisateur ...") return;
            username.Clear();
            username.StateCommon.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (username.Text != "") return;
            username.Text = "Nom d'utilisateur ...";
            username.StateCommon.Content.Color1 = Color.DarkGray;
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (password.Text != "Mot de passe ...") return;
            password.Clear();
            password.UseSystemPasswordChar = true;
            password.StateCommon.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (password.Text != "") return;
            password.UseSystemPasswordChar = false;
            password.Text = "Mot de passe ...";
            password.StateCommon.Content.Color1 = Color.DarkGray;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new Dashboard());

            //if (username.Text == "admin" && password.Text == "root")

            //else
            // MessageBox.Show("Wrong username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void logo_MouseEnter(object sender, EventArgs e)
        {
            logo.Image = Resources.Heart_Red_96px;
        }

        private void logo_MouseLeave(object sender, EventArgs e)
        {
            logo.Image = Resources.Heart_96px;
        }

        #endregion
    }
}