using System;
using System.Windows.Forms;
using BB_App.Models;
using MySql.Data.MySqlClient;

namespace BB_App.Views.Donations
{
    public partial class DonationInformations : UserControl
    {
        private readonly User _currentUser;

        public DonationInformations(User user)
        {
            InitializeComponent();
            _currentUser = user;
            FillWith(_currentUser);
            kryptonDateTimePicker1.MinDate = DateTime.Today.AddDays(1);
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
            ((Main)ParentForm).LoadForm(new AddType());
        }

        private void FillWith(User user)
        {
            label10.Text = user.Name;
            label9.Text = user.BloodGroup;
            label8.Text = user.Gender;
            label7.Text = user.Phone.ToString();
            label2.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        }

        /// <summary>
        /// Add donation to the database.
        /// </summary>
        private void AddDonation()
        {
            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                var date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
                var expDate = kryptonDateTimePicker1.Value.Year.ToString() + "-" + kryptonDateTimePicker1.Value.Month.ToString() + "-" + kryptonDateTimePicker1.Value.Day.ToString();
                const string query = "INSERT INTO donations(id_user, ref_hospital, donation_date, expiration_date, blood_group, unit, donation_status) VALUES (@id, @ref, @date, @exp_date, @blood, @qty, @status);";
                var cmd = new MySqlCommand(query, SqlConnection.Conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", _currentUser.Id);
                cmd.Parameters.AddWithValue("@ref", Properties.Settings.Default.reference);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@blood", label9.Text);
                cmd.Parameters.AddWithValue("@qty", kryptonNumericUpDown1.Value);
                cmd.Parameters.AddWithValue("@status", "pending");

                cmd.Parameters.AddWithValue("@exp_date", radioButton1.Checked ? null : expDate);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Donation added with succes", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Main)ParentForm).LoadForm(new DonationsForm());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(@"Can't create the donation. Error " + ex.ErrorCode + @" : " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(@"Cannot connect to the database", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kryptonDateTimePicker1.Enabled = radioButton2.Checked;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddDonation();
        }

        #endregion Methods
    }
}