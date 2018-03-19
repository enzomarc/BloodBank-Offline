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

namespace BB_App.Views.Donations
{
    public partial class Donation_Informations : UserControl
    {
        User currentUser;

        public Donation_Informations(Models.User user)
        {
            InitializeComponent();
            currentUser = user;
            FillWith(currentUser);
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
            ((Main)this.ParentForm).loadForm(new Views.Donations.Add_Type());
        }

        private void FillWith(Models.User _user)
        {
            label10.Text = _user.Name;
            label9.Text = _user.BloodGroup;
            label8.Text = _user.Gender;
            label7.Text = _user.Phone.ToString();
            label2.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        /// <summary>
        /// Add donation to the database.
        /// </summary>
        private void AddDonation()
        {

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string date = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();
                string expDate = kryptonDateTimePicker1.Value.Year.ToString() + "-" + kryptonDateTimePicker1.Value.Month.ToString() + "-" + kryptonDateTimePicker1.Value.Day.ToString();
                string query = "INSERT INTO donations(id_user, ref_hospital, donation_date, expiration_date, blood_group, unit, donation_status) VALUES (@id, @ref, @date, @exp_date, @blood, @qty, @status);";
                MySqlCommand cmd = new MySqlCommand(query, SqlConnection.conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", currentUser.Id);
                cmd.Parameters.AddWithValue("@ref", Properties.Settings.Default.reference);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@blood", label9.Text);
                cmd.Parameters.AddWithValue("@qty", kryptonNumericUpDown1.Value);
                cmd.Parameters.AddWithValue("@status", "pending");

                if (radioButton1.Checked)
                    cmd.Parameters.AddWithValue("@exp_date", null);
                else
                    cmd.Parameters.AddWithValue("@exp_date", expDate);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation added with succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Main)this.ParentForm).loadForm(new Views.DonationsForm());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Can't create the donation. Error " + ex.ErrorCode + " : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Cannot connect to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kryptonDateTimePicker1.Enabled = radioButton2.Checked;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddDonation();
        }

        #endregion

    }
}
