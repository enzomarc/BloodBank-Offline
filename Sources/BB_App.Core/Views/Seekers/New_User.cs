using System;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;

namespace BB_App.Core.Views.Seekers
{
    public partial class NewUser : UserControl
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            bloodGD.Text = e.ClickedItem.Text;
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            genderD.Text = e.ClickedItem.Text;
        }

        private void contextMenuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cityD.Text = e.ClickedItem.Text;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        #region Methods

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
            ((Main) ParentForm).LoadForm(new AddType());
        }

        private void AddUser()
        {
            if (SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user, Settings.Default.db_pwd,
                Settings.Default.db_name))
            {
                var date = kryptonDateTimePicker1.Value.Year + "-" + kryptonDateTimePicker1.Value.Month + "-" +
                           kryptonDateTimePicker1.Value.Day;
                var query =
                    "INSERT INTO users(name, phone, bloodgroup, birthdate, gender, city) VALUES (@name, @phone, @blood, @birth, @gender, @city);";
                var cmd = new MySqlCommand(query, SqlConnection.Conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", username.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@blood", bloodGD.Text);
                cmd.Parameters.AddWithValue("@birth", date);
                cmd.Parameters.AddWithValue("@gender", genderD.Text);
                cmd.Parameters.AddWithValue("@city", cityD.Text);

                try
                {
                    cmd.ExecuteNonQuery(); // Adding user

                    int id;
                    var query2 = "SELECT id_user FROM users WHERE phone = " + phone.Text;
                    var cmd2 = new MySqlCommand(query2, SqlConnection.Conn);

                    var result = cmd2.ExecuteScalar(); // Loading user id for donation informations

                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show(@"Can't retrieve user id, Try creating the user again.", @"Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ((Main) ParentForm).LoadForm(new RequestInformations(new User(id)));
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(@"Can't create the user. Error " + ex.ErrorCode + @" : " + ex.Message, @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}