using System; using static BB_App.Helpers.FormsHelpers;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;

namespace BB_App.Core.Views.Donations
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

        private void FillWith(User user)
        {
            label10.Text = user.Name;
            label9.Text = Commons.Format(user.BloodGroup);
            label8.Text = user.Gender;
            label7.Text = user.Phone.ToString();
            label2.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        }

        /// <summary>
        ///     Add donation to the database.
        /// </summary>
        private void AddDonation()
        {
            if (SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user, Settings.Default.db_pwd,
                Settings.Default.db_name))
            {
                var date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
                var expDate = kryptonDateTimePicker1.Value.Year + "-" + kryptonDateTimePicker1.Value.Month + "-" +
                              kryptonDateTimePicker1.Value.Day;
                const string query =
                    "INSERT INTO donations(id_user, ref_hospital, donation_date, expiration_date, unit, donation_status) VALUES (@id, @ref, @date, @exp_date, @qty, @status);";
                var cmd = new MySqlCommand(query, SqlConnection.Conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", _currentUser.Id);
                cmd.Parameters.AddWithValue("@ref", Settings.Default.reference);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@qty", kryptonNumericUpDown1.Value);
                cmd.Parameters.AddWithValue("@status", "waiting");

                cmd.Parameters.AddWithValue("@exp_date", radioButton1.Checked ? date : expDate);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Donation added with succes", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadForm(((Main)ParentForm).frmContainer, new DonationsForm());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(@"Can't create the donation. Error " + ex.ErrorCode + @" : " + ex.Message, @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Cannot connect to the database", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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