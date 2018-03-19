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

namespace BB_App.Views
{
    public partial class DonationsForm : UserControl
    {
        public DonationsForm()
        {
            InitializeComponent();
        }
 
        MySqlDataAdapter data;
        DataSet ds;

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
            ((Main)this.ParentForm).loadForm(new Views.Dashboard());
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new Views.Donations.Add_Type());
        }

        public void loadDonations()
        {
            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string query = "SELECT id_donation, id_user, donation_date, expiration_date, unit FROM donations WHERE ref_hospital = '" + Properties.Settings.Default.reference + "';";
                data = new MySqlDataAdapter(query, SqlConnection.conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data);

                ds = new DataSet();
                data.Fill(ds, "donations");
                donationsDGV.DataSource = ds;
                donationsDGV.DataMember = "donations";
                donationsDGV.Columns[0].ReadOnly = true;
                donationsDGV.Columns[1].ReadOnly = true;
                donationsDGV.Columns[0].HeaderText = "Donation ID";
                donationsDGV.Columns[1].HeaderText = "User ID";
                donationsDGV.Columns[2].HeaderText = "Donation Date";
                donationsDGV.Columns[3].HeaderText = "Expiration Date";
                donationsDGV.Columns[4].HeaderText = "Units";
            }
            else
                MessageBox.Show("Can't connect to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Donations_Load(object sender, EventArgs e)
        {
            loadDonations();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            data.Update(ds, "donations");
        }

        private void donationsDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            data.Update(ds, "donations");
        }

        private void donationsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (donationsDGV.SelectedRows.Count > 0)
            {
                bunifuFlatButton2.Text = "From " + Models.User.getUserName(Convert.ToInt32(donationsDGV.SelectedRows[0].Cells[1].Value));
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int id = (int)donationsDGV.SelectedRows[0].Cells[0].Value;
            ((Main)this.ParentForm).loadForm(new Views.Donations.Registered_User(true, id));
        }

        #endregion

    }
}
