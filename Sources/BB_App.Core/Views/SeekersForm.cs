using System; using static BB_App.Helpers.FormsHelpers;
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
            LoadForm(((Main)ParentForm)?.frmContainer, new Dashboard());
        }

        private void Seekers_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        public void LoadRequests()
        {
            // Load all requests from the database
            requestsDGV.DataSource = Requests.LoadRequests();
            requestsDGV.DataMember = "requests";

            // Change columns names
            requestsDGV.Columns[0].HeaderText = @"Request ID";
            requestsDGV.Columns[1].HeaderText = @"User";
            requestsDGV.Columns[2].HeaderText = @"Hospital Reference";
            requestsDGV.Columns[3].HeaderText = @"Blood Group";
            requestsDGV.Columns[4].HeaderText = @"Request Date";
            requestsDGV.Columns[5].HeaderText = @"Received Date";
            requestsDGV.Columns[6].HeaderText = @"Units";
            requestsDGV.Columns[7].HeaderText = @"Status";
            requestsDGV.Columns[8].Visible = false;

            for (var i = 0; i < requestsDGV.Rows.Count; i++)
            {
                var id = (int)requestsDGV.Rows[i].Cells[1].Value;
                requestsDGV.Rows[i].Cells[1].ValueType = User.GetUserName(id).GetType();
            }
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
            var id = (int)requestsDGV.SelectedRows[0].Cells[0].Value;

            if (Requests.VerifRequest(id))
            {
                MessageBox.Show(@"Request sended to verification.", @"Verification", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadRequests();
            }
            else
                MessageBox.Show(@"Can't send the request. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm)?.frmContainer, new AddType());
        }

        private void requestsDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (requestsDGV.SelectedRows.Count > 0)
                {
                    fromLabel.Text =
                        @"From " + User.GetUserName(Convert.ToInt32(requestsDGV.SelectedRows[0].Cells[1].Value));
                    updateButton.Enabled = (string)requestsDGV.SelectedRows[0].Cells[7].Value == "waiting";
                    deleteButton.Enabled = requestsDGV.SelectedRows.Count > 0;
                }
            } catch { }
        }

        #endregion

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                var id = (int)requestsDGV.SelectedRows[0].Cells[0].Value;

                if (Requests.DeleteRequest(id))
                {
                    MessageBox.Show(@"Request deleted !", @"Deletion", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    requestsDGV.DataSource = Requests.LoadRequests();
                    requestsDGV.DataMember = "requests";
                }
                else
                    MessageBox.Show(@"Can't delete the request.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch{ }

        }
    }
}