using BB_App.Core.Models;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static BB_App.Core.Models.SqlConnection;

namespace BB_App.Core.Views.Administration
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private bool AddRequest(string hospital, string bloodgroup, int units)
        {
            bool saved = false;

            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return saved;

            var query =
                "INSERT INTO hospital_request(ref_hospital, bloodgroup, unit, date) VALUES (@ref, @bg, @unit, @date);";

            var date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;

            var cmd = new MySqlCommand(query, Conn);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@ref", hospital);
            cmd.Parameters.AddWithValue("@bg", bloodgroup);
            cmd.Parameters.AddWithValue("@unit", units);
            cmd.Parameters.AddWithValue("@date", date);

            try
            {
                saved = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                saved = false;
            }

            return saved;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddRequest(Settings.Default.reference, Commons.Unformat(comboBox1.Text).ToLower(), (int)numericUpDown1.Value))
            { 
                MessageBox.Show(@"Blood request added.", @"Blood Request", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show(@"Can't add the blood request. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
