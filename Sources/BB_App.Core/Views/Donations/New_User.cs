using System;
using System.Security.Cryptography;
using static BB_App.Helpers.FormsHelpers;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;
using BB_App.Helpers;
using System.Text;

namespace BB_App.Core.Views.Donations
{
    public partial class NewUser : UserControl
    {
        public NewUser()
        {
            InitializeComponent();
            kryptonDateTimePicker1.MaxDate = DateTime.Today;
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
            LoadForm(((Main)ParentForm).frmContainer, new AddType());
        }

        /// <summary>
        ///     Insert user into the database.
        /// </summary>
        private void AddUser()
        {
            if (SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user, Settings.Default.db_pwd,
                Settings.Default.db_name))
            {
                try
                {
                    var password = StringHelpers.UniqueId();
                    
                    var md5= MD5.Create();

                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes = md5.ComputeHash(sourceBytes);
                    var md5_pass = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                    var month = kryptonDateTimePicker1.Value.Month.ToString();

                    if (month.Length == 1)
                        month = "0" + month;

                    var day = kryptonDateTimePicker1.Value.Day.ToString();

                    if (day.Length == 1)
                        day = "0" + day;

                    var date = kryptonDateTimePicker1.Value.Year + "-" + month + "-" +
                               day;
                    var query =
                        "INSERT INTO users(name, phone, password, bloodgroup, birthdate, gender, city) VALUES (@name, @phone, @pass, @blood, @birth, @gender, @city);";
                    var cmd = new MySqlCommand(query, SqlConnection.Conn);
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@name", username.Text);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                    cmd.Parameters.AddWithValue("@pass", md5_pass.ToLower());
                    cmd.Parameters.AddWithValue("@blood", Commons.Unformat(bloodGD.Text).ToLower());
                    cmd.Parameters.AddWithValue("@birth", date);
                    cmd.Parameters.AddWithValue("@gender", genderD.Text.ToLower());
                    cmd.Parameters.AddWithValue("@city", cityD.Text);

                    try
                    {
                        cmd.ExecuteNonQuery(); // Adding user

                        var id = 0;
                        var query2 = "SELECT id_user FROM users WHERE phone = " + phone.Text;
                        var cmd2 = new MySqlCommand(query2, SqlConnection.Conn);

                        var result = cmd2.ExecuteScalar(); // Loading user id for donation informations

                        if (result != null)
                            id = Convert.ToInt32(result);
                        else
                            MessageBox.Show(@"Can't retrieve user id, Try creating the user again.", @"Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        MessageBox.Show(@"Here is the new user password. Please note it somewhere and give it to the user." + Environment.NewLine + @" Password : " + password);
                        LoadForm(((Main)ParentForm).frmContainer, new DonationInformations(new User(id)));
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(@"Can't create the user. Error " + ex.ErrorCode + @" : " + ex.Message, @"Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex2)
                {
                    MessageBox.Show(@"Can't create the user. Error : " + ex2.Message, @"Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        #endregion Methods
    }
}