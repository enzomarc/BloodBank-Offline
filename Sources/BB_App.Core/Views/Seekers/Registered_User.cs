using System;
using System.Data;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;

namespace BB_App.Core.Views.Seekers
{
    public partial class RegisteredUser : UserControl
    {
        private readonly int _id;
        private readonly bool _update;
        private MySqlDataAdapter _data;
        private DataSet _ds;

        public RegisteredUser(bool update, int id = 0)
        {
            InitializeComponent();
            _update = update;
            _id = id;
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
            ((Main) ParentForm).LoadForm(new AddType());
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_update == false)
            {
                var id = (int) usersDGV.SelectedRows[0].Cells[0].Value;
                ((Main) ParentForm).LoadForm(new RequestInformations(new User(id)));
            }
            else
            {
                UpdateRequest(_id);
                ((Main) ParentForm).LoadForm(new SeekersForm());
            }
        }

        public void UpdateRequest(int requestId)
        {
            Requests.ChangeUser(requestId, Convert.ToInt32(usersDGV.SelectedRows[0].Cells[0].Value));
        }

        public void LoadUsers()
        {
            if (SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user, Settings.Default.db_pwd,
                Settings.Default.db_name))
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
            {
                MessageBox.Show(@"Cannot connect to the database", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Registered_User_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        #endregion
    }
}