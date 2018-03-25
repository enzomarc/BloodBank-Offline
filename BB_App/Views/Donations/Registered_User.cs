using System;
using System.Data;
using System.Windows.Forms; using BB_App.Models;
using MySql.Data.MySqlClient;

namespace BB_App.Views.Donations
{
    public partial class RegisteredUser : UserControl
    {
        private MySqlDataAdapter _data;
        private DataSet _ds;
        private readonly int _id;
        private readonly bool _update;

        public RegisteredUser(bool update, int id = 0)
        {
            InitializeComponent();
            _update = update;
            _id = id;
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_update == false)
            {
                var id = (int)usersDGV.SelectedRows[0].Cells[0].Value;
                ((Main)ParentForm).LoadForm(new DonationInformations(new User(id)));
            }
            else
            {
                UpdateDonation(_id);
                ((Main)ParentForm).LoadForm(new DonationsForm());
            }
        }

        /// <summary>
        /// Update donation over the database.
        /// </summary>
        /// <param name="donationId">Id of the donation to update.</param>
        public void UpdateDonation(int donationId)
        {

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {

                try
                {
                    var id = (int)usersDGV.SelectedRows[0].Cells[0].Value;
                    var query = "UPDATE donations SET id_user = " + id + " WHERE id_donation = " + donationId + ";";
                    var cmd = new MySqlCommand(query, SqlConnection.Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"User updated !", @"Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(@"Error occured during update (" + ex.ErrorCode + @") : " + ex.Message, @"Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// Load list of all users available in the database.
        /// </summary>
        public void LoadUsers()
        {

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                const string query = "SELECT id_user, name FROM users";
                _data = new MySqlDataAdapter(query, SqlConnection.Conn);

                _ds = new DataSet();
                _data.Fill(_ds, "users");
                usersDGV.DataSource = _ds;
                usersDGV.DataMember = "users";
                usersDGV.Columns[0].ReadOnly = true;
                usersDGV.Columns[1].ReadOnly = true;
                usersDGV.Columns[0].HeaderText = "#";
                usersDGV.Columns[1].HeaderText = "User Name";

            }
            else
                MessageBox.Show(@"Cannot connect to the database", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Registered_User_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        #endregion

    }
}
