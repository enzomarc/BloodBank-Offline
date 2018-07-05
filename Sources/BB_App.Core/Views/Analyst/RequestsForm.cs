using System; using static BB_App.Helpers.FormsHelpers;
using System.Data;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using BB_App.Core.Views.Donations;
using MySql.Data.MySqlClient;

namespace BB_App.Core.Views.Analyst
{
    public partial class RequestsForm : UserControl
    {
        private MySqlDataAdapter _data;
        private DataSet _ds;

        public RequestsForm()
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

        private void profileButton_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm)?.frmContainer, new AddType());
        }

        private void LoadRequests()
        {
            if (SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user, Settings.Default.db_pwd,
                Settings.Default.db_name))
            {
                var query = "SELECT * FROM requests WHERE request_status = 'verificating' AND ref_hospital = '" + Settings.Default.reference + "'";

                _data = new MySqlDataAdapter(query, SqlConnection.Conn);

                _ds = new DataSet();
                _data.Fill(_ds, "requests");
                requestsDGV.DataSource = _ds;
                requestsDGV.DataMember = "requests";
                requestsDGV.Columns[0].HeaderText = @"Request ID";
                requestsDGV.Columns[1].HeaderText = @"User";
                requestsDGV.Columns[2].HeaderText = @"Hospital Reference";
                requestsDGV.Columns[3].HeaderText = @"Blood Group";
                requestsDGV.Columns[4].HeaderText = @"Request Date";
                requestsDGV.Columns[5].HeaderText = @"Received Date";
                requestsDGV.Columns[6].HeaderText = @"Units";
                requestsDGV.Columns[7].HeaderText = @"Status";
                requestsDGV.Columns[8].Visible = false;
            }
            else
            {
                MessageBox.Show(@"Can't connect to the database", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Donations_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var id = (int)requestsDGV.SelectedRows[0].Cells[0].Value;
            var validationForm = new Validation(id, "unvalidation", "requests");

            validationForm.FormClosed += ValidationForm_FormClosed;
            validationForm.ShowDialog();
        }

        private void donationsDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _data.Update(_ds, "donations");
        }

        private void donationsDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (requestsDGV.SelectedRows.Count > 0)
                {
                    fromLabel.Text =
                        @"From " + User.GetUserName(Convert.ToInt32(requestsDGV.SelectedRows[0].Cells[1].Value));
                    updateButton.Enabled = (string)requestsDGV.SelectedRows[0].Cells[7].Value == "verificating";
                    bunifuFlatButton1.Enabled = (string)requestsDGV.SelectedRows[0].Cells[7].Value == "verificating";
                }
            } catch { }
            
        }

        #endregion

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = (int)requestsDGV.SelectedRows[0].Cells[0].Value;
            var validationForm = new Validation(id, "validation", "requests");

            validationForm.FormClosed += ValidationForm_FormClosed;
            validationForm.ShowDialog();

            /* if (Requests.ValidateDonation(id, AccountsModel.UserId(AccountsModel.WhoIsConnected())))
            {
                MessageBox.Show(@"Donation validated.", @"Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadDonations();
                updateButton.Enabled = false;
                bunifuFlatButton1.Enabled = false;
            }
            else
                MessageBox.Show(@"Can't validate the donation. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); */
        }

        private void ValidationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRequests();
        }
    }
}