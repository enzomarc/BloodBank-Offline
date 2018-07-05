using System;
using System.Windows.Forms;
using BB_App.Core.Properties;
using static BB_App.Helpers.FormsHelpers;
using BB_App.Core.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace BB_App.Core.Views.Administration
{
    public partial class HospitalRequest : UserControl
    {
        private MySqlDataAdapter _data;
        private DataSet _ds;

        public HospitalRequest()
        {
            InitializeComponent();
        }

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
            LoadForm(((Main)ParentForm).frmContainer, new Dashboard());
        }

        private void LoadRequests()
        {
            try
            {
                if (SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user, Settings.Default.db_pwd,
                    Settings.Default.db_name))
                {
                    var query = "SELECT * FROM hospital_request WHERE ref_hospital = '" + Settings.Default.reference + "'";

                    _data = new MySqlDataAdapter(query, SqlConnection.Conn);

                    _ds = new DataSet();
                    _data.Fill(_ds, "hospital_request");
                    requestsDGV.DataSource = _ds;
                    requestsDGV.DataMember = "hospital_request";
                    requestsDGV.Columns[0].HeaderText = @"Request ID";
                    requestsDGV.Columns[1].Visible = false;
                    requestsDGV.Columns[2].HeaderText = @"Blood Group";
                    requestsDGV.Columns[3].HeaderText = @"Units";
                    requestsDGV.Columns[4].Visible = false;
                    requestsDGV.Columns[5].Visible = false;
                }
                else
                {
                    MessageBox.Show(@"Can't connect to the database", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch { }
        }

        private static bool DeleteRequest(int id)
        {
            if (!SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            const string query = "DELETE FROM hospital_request WHERE id = @id";

            var command = new MySqlCommand(query, SqlConnection.Conn);
            command.Prepare();
            command.Parameters.AddWithValue("@id", id);

            return command.ExecuteNonQuery() > 0;
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            var id = (int)requestsDGV.SelectedRows[0].Cells[0].Value;
            if (DeleteRequest(id))
                MessageBox.Show(@"Blood request deleted.", @"Blood Request", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show(@"Can't delete the blood request. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadRequests();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.FormClosed += AddForm_FormClosed;
            addForm.ShowDialog();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRequests();
        }
    }
}
