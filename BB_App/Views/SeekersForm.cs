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
    public partial class SeekersForm : UserControl
    {
        public SeekersForm()
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
            ((Main)this.ParentForm).loadForm(new Views.Dashboard());
        }

        private void Seekers_Load(object sender, EventArgs e)
        {

            // Load all requests from the database
            requestsDGV.DataSource = Models.Requests.loadRequests();
            requestsDGV.DataMember = "requests";

            // Change columns names
            requestsDGV.Columns[0].ReadOnly = true;
            requestsDGV.Columns[1].ReadOnly = true;
            requestsDGV.Columns[2].ReadOnly = true;
            requestsDGV.Columns[0].HeaderText = "Request ID";
            requestsDGV.Columns[1].HeaderText = "User ID";
            requestsDGV.Columns[2].HeaderText = "Hospital Reference";
            requestsDGV.Columns[3].HeaderText = "Request Date";
            requestsDGV.Columns[4].HeaderText = "Expiration Date";
            requestsDGV.Columns[5].HeaderText = "Units";
            requestsDGV.Columns[6].HeaderText = "Status";

        }

        private void requestsDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateButton.Enabled = true;
        }

        private void requestsDGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateButton.Enabled = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Models.Requests.adapter.Update(Models.Requests.datas, "requests");
            MessageBox.Show("Database updated !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).loadForm(new Views.Seekers.Add_Type());
        }

        private void requestsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (requestsDGV.SelectedRows.Count > 0)
            {
                bunifuFlatButton2.Text = "From " + Models.User.getUserName(Convert.ToInt32(requestsDGV.SelectedRows[0].Cells[1].Value));
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int id = (int)requestsDGV.SelectedRows[0].Cells[0].Value;
            ((Main)this.ParentForm).loadForm(new Views.Seekers.Registered_User(true, id));
        }

        #endregion

    }
}
