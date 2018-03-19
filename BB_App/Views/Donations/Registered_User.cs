﻿using System;
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
    public partial class Registered_User : UserControl
    {
        
        MySqlDataAdapter data;
        DataSet ds;
        int id;
        bool update = false;

        public Registered_User(bool _update, int _id = 0)
        {
            InitializeComponent();
            update = _update;
            id = _id;
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                int id = (int)usersDGV.SelectedRows[0].Cells[0].Value;
                ((Main)this.ParentForm).loadForm(new Views.Donations.Donation_Informations(new Models.User(id)));
            }
            else
            {
                updateDonation(id);
                ((Main)this.ParentForm).loadForm(new Views.DonationsForm());
            }
        }

        /// <summary>
        /// Update donation over the database.
        /// </summary>
        /// <param name="donationId">Id of the donation to update.</param>
        public void updateDonation(int donationId)
        {

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {

                try
                {
                    int id = (int)usersDGV.SelectedRows[0].Cells[0].Value;
                    string query = "UPDATE donations SET id_user = " + id + " WHERE id_donation = " + donationId + ";";
                    MySqlCommand cmd = new MySqlCommand(query, SqlConnection.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error occured during update (" + ex.ErrorCode + ") : " + ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// Load list of all users available in the database.
        /// </summary>
        public void loadUsers()
        {

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string query = "SELECT id_user, name FROM users";
                data = new MySqlDataAdapter(query, SqlConnection.conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data);

                ds = new DataSet();
                data.Fill(ds, "users");
                usersDGV.DataSource = ds;
                usersDGV.DataMember = "users";
                usersDGV.Columns[0].ReadOnly = true;
                usersDGV.Columns[1].ReadOnly = true;
                usersDGV.Columns[0].HeaderText = "#";
                usersDGV.Columns[1].HeaderText = "User Name";

            }
            else
                MessageBox.Show("Cannot connect to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Registered_User_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        #endregion

    }
}