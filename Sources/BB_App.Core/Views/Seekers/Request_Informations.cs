using System; using static BB_App.Helpers.FormsHelpers;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;

namespace BB_App.Core.Views.Seekers
{
    public partial class RequestInformations : UserControl
    {
        private readonly User _currentUser;

        public RequestInformations(User user)
        {
            InitializeComponent();
            _currentUser = user;
            FillWith(_currentUser);
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
            LoadForm(((Main)ParentForm).frmContainer, new AddType());
        }

        private void FillWith(User user)
        {
            label10.Text = user.Name;
            bloodGD.Text = Commons.Format(user.BloodGroup);
            label8.Text = user.Gender;
            label7.Text = user.Phone.ToString();
            label2.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        }

        private void AddRequest()
        {
            var request = new Requests.Request(_currentUser.Id, Settings.Default.reference, Commons.Unformat(bloodGD.Text).ToLower(), DateTime.Today, new DateTime(1, 1, 1), Convert.ToInt32(kryptonNumericUpDown1.Value), "waiting");

            if (Requests.SaveRequest(request))
                MessageBox.Show(@"Request added successfully.", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show(@"Can't save the request. Contact administrator.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            LoadForm(((Main)ParentForm).frmContainer, new SeekersForm());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!Requests.PendingRequest(_currentUser.Id))
                AddRequest();
            else
                MessageBox.Show("Can't add the request because the specified user has waiting request.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            bloodGD.Text = e.ClickedItem.Text;
            kryptonNumericUpDown1.Maximum = Models.Bloods.GetUnits(Commons.Unformat(e.ClickedItem.Text).ToLower());
        }
    }
}