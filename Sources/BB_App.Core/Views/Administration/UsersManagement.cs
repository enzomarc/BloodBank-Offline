using System;
using System.Drawing;
using System.Windows.Forms;
using BB_App.Core.Controls;
using BB_App.Core.Properties;
using static BB_App.Core.Models.AccountsModel;
using static BB_App.Helpers.AccountsHelpers;
using static BB_App.Helpers.FormsHelpers;

namespace BB_App.Core.Views.Administration
{
    public partial class UsersManagement : UserControl
    {
        public UsersManagement()
        {
            InitializeComponent();
        }

        private void UsersManagement_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

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
            LoadForm(((Main)ParentForm).frmContainer, new Administration.Dashboard());
        }

        private void Item_Click(object sender, EventArgs e)
        {
            var text = ((Control)sender).Name.Contains("Label")
                ? ((Control)sender).Text
                : ((CustomListBoxItem)sender).textLabel.Text;
            var infos = LoadInfo(text);
            usernameLabel.Text = "Username : " + infos.Split('|')[0];
            typeLabel.Text = "Account Type : " + ParseAccountType(infos.Split('|')[1]).ToString();
        }

        private void GetUsers()
        {
            usersListBox.Clear();

            foreach (var user in LoadUsers())
                usersListBox.Add(new CustomListBoxItem(user));

            foreach (var item in usersListBox.Items)
            {
                item.Click += Item_Click;
                item.textLabel.Click += Item_Click;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var user = usernameLabel.Text.Split(':')[1].Remove(0, 1);

            if (user.ToLower() != WhoIsConnected().ToLower())
            {
                if (DeleteUser(user))
                {
                    MessageBox.Show("User successfully deleted.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GetUsers();
                }
                else
                {
                    MessageBox.Show("Can't delete the specified user.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't delete the specified user because he is actually connected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Username ...")
            { 
                usernameBox.Text = "";
                usernameBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {
                usernameBox.Text = "Username ...";
                usernameBox.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password ...")
            {
                passwordBox.UseSystemPasswordChar = true;
                passwordBox.Text = "";
                passwordBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.UseSystemPasswordChar = false;
                passwordBox.Text = "Password ...";
                passwordBox.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accountType.Text = e.ClickedItem.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != "" && usernameBox.Text != "Username ..." && passwordBox.Text != "" &&
                passwordBox.Text != "Password ..." && accountType.Text != "Account Type")
            {
                var username = usernameBox.Text;
                var password = passwordBox.Text;
                var type = accountType.Text;
                if (CreateUser(username, password, type))
                {
                    MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GetUsers();
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    accountType.Text = "Account Type";
                }
                else
                {
                    MessageBox.Show("Error during account creation.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
