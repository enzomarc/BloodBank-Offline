using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BB_App.Core.Models;

namespace BB_App.Core
{
    public partial class Database_Config : Form
    {
        public Database_Config()
        {
            InitializeComponent();
        }

        public bool EmptyFields()
        {
            foreach (Control textBox in this.Controls)
            {
                if (textBox.Name.Contains("textBox"))
                {
                    if (((TextBox)textBox).Text == "")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("Check all the fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var server = textBox1.Text;
                var user = textBox2.Text;
                var password = passwordBox.Text;
                var db = textBox4.Text;

                if (SqlConnection.Connect(server, user, password, db))
                {
                    label5.Text = "Status : Connected";
                    button1.Enabled = true;

                    Properties.Settings.Default.server = server;
                    Properties.Settings.Default.db_user = user;
                    Properties.Settings.Default.db_pwd = password;
                    Properties.Settings.Default.db_name = db;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                }
                else
                {
                    label5.Text = "Status : Disconnected";
                    button1.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
