using System;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using BB_App.Core.Views.Seekers;

namespace BB_App.Core.Views
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
            ((Main) ParentForm).LoadForm(new Dashboard());
        }

        private void Seekers_Load(object sender, EventArgs e)
        {
            // Load all requests from the database
            requestsDGV.DataSource = Requests.LoadRequests();
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
            Requests.Adapter.Update(Requests.Datas, "requests");
            MessageBox.Show(@"Database updated !", @"Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).LoadForm(new AddType());
        }

        private void requestsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (requestsDGV.SelectedRows.Count > 0)
                bunifuFlatButton2.Text =
                    "From " + User.GetUserName(Convert.ToInt32(requestsDGV.SelectedRows[0].Cells[1].Value));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var id = (int) requestsDGV.SelectedRows[0].Cells[0].Value;
            ((Main) ParentForm).LoadForm(new RegisteredUser(true, id));
        }

        #endregion
    }
}