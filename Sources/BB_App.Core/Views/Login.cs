using System;
using static BB_App.Helpers.FormsHelpers;
using static BB_App.Helpers.AccountsHelpers;
using static BB_App.Helpers.StringHelpers;
using System.Drawing;
using System.Windows.Forms;
using BB_App.Core.Properties;
using static BB_App.Core.Models.AccountsModel;

namespace BB_App.Core.Views
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        #region UI Methods

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (username.Text != @"Nom d'utilisateur ...") return;
            username.Clear();
            username.StateCommon.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (username.Text != "") return;
            username.Text = @"Nom d'utilisateur ...";
            username.StateCommon.Content.Color1 = Color.DarkGray;
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (password.Text != @"Mot de passe ...") return;
            password.Clear();
            password.UseSystemPasswordChar = true;
            password.StateCommon.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (password.Text != "") return;
            password.UseSystemPasswordChar = false;
            password.Text = @"Mot de passe ...";
            password.StateCommon.Content.Color1 = Color.DarkGray;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
	        var accountType = Login(username.Text, password.Text);

			if (accountType != string.Empty)
	        {
				SetAccountType(ParseAccountType(accountType));
	            SetCurrentUser(username.Text);
                if (accountType == "analyst")
                    LoadForm(((Main) ParentForm)?.frmContainer, new Analyst.Dashboard());
                else
                    LoadForm(((Main)ParentForm)?.frmContainer, new Dashboard());
            }
            else
		        password.Clear();
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

        private void password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuFlatButton1_Click(sender, EventArgs.Empty);
            }
        }
    }
}