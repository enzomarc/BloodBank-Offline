using System;
using System.Windows.Forms; using BB_App.Models;

namespace BB_App.Views.Seekers
{
    public partial class RequestInformations : UserControl
    {
        private readonly User _currentUser;

        public RequestInformations(User user)
        {
            InitializeComponent();
            _currentUser = user;
            FillWith(_currentUser);
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
            ((Main)ParentForm).LoadForm(new AddType());
        }

        private void FillWith(User user)
        {
            label10.Text = user.Name;
            label9.Text = user.BloodGroup;
            label8.Text = user.Gender;
            label7.Text = user.Phone.ToString();
            label2.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void AddRequest()
        {

            var request = new Requests.Request(_currentUser.Id, Properties.Settings.Default.reference, DateTime.Today, kryptonDateTimePicker1.Value, Convert.ToInt32(kryptonNumericUpDown1.Value), "waiting");

            if (Requests.SaveRequest(request))
                MessageBox.Show("Request added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Can't save the request. Contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ((Main)ParentForm).LoadForm(new SeekersForm());

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddRequest();
        }

        #endregion

    }
}
