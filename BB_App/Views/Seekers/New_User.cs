using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms; using BB_App.Models;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BB_App.Views.Seekers
{
    public partial class New_User : UserControl
    {

        public New_User()
        {
            InitializeComponent();
        }

        #region Methods

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.Delete_Hover_18px;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.Delete_18px;
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.Image = Properties.Resources.Left_Hover_16px;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.Image = Properties.Resources.Left_15px;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new Views.Seekers.Add_Type());
        }

        private void AddUser()
        {

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string date = kryptonDateTimePicker1.Value.Year.ToString() + "-" + kryptonDateTimePicker1.Value.Month.ToString() + "-" + kryptonDateTimePicker1.Value.Day.ToString();
                string query = "INSERT INTO users(name, phone, bloodgroup, birthdate, gender, city) VALUES (@name, @phone, @blood, @birth, @gender, @city);";
                MySqlCommand cmd = new MySqlCommand(query, SqlConnection.conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", username.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@blood", bloodGD.Text);
                cmd.Parameters.AddWithValue("@birth", date);
                cmd.Parameters.AddWithValue("@gender", genderD.Text);
                cmd.Parameters.AddWithValue("@city", cityD.Text);

                try
                {
                    cmd.ExecuteNonQuery();  // Adding user

                    int id = 0;
                    string query2 = "SELECT id_user FROM users WHERE phone = " + phone.Text;
                    MySqlCommand cmd2 = new MySqlCommand(query2, SqlConnection.conn);

                    object result = cmd2.ExecuteScalar();   // Loading user id for donation informations

                    if (result != null)
                        id = Convert.ToInt32(result);
                    else
                    {
                        MessageBox.Show("Can't retrieve user id, Try creating the user again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ((Main)this.ParentForm).loadForm(new Views.Seekers.Request_Informations(new Models.User(id)));
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Can't create the user. Error " + ex.ErrorCode + " : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        #endregion

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

    }
}
