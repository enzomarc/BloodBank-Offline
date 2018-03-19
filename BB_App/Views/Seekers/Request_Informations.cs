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

namespace BB_App.Views.Seekers
{
    public partial class Request_Informations : UserControl
    {
        User currentUser;

        public Request_Informations(Models.User user)
        {
            InitializeComponent();
            currentUser = user;
            FillWith(currentUser);
            kryptonDateTimePicker1.MinDate = DateTime.Today.AddDays(1);
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
            ((Main)this.ParentForm).loadForm(new Views.Seekers.Add_Type());
        }

        private void FillWith(Models.User _user)
        {
            label10.Text = _user.Name;
            label9.Text = _user.BloodGroup;
            label8.Text = _user.Gender;
            label7.Text = _user.Phone.ToString();
            label2.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void AddRequest()
        {

            Requests.Request request = new Requests.Request(currentUser.Id, Properties.Settings.Default.reference, DateTime.Today, kryptonDateTimePicker1.Value, Convert.ToInt32(kryptonNumericUpDown1.Value), "waiting");

            if (Models.Requests.saveRequest(request))
                MessageBox.Show("Request added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Can't save the request. Contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ((Main)this.ParentForm).loadForm(new Views.SeekersForm());

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddRequest();
        }

        #endregion

    }
}
