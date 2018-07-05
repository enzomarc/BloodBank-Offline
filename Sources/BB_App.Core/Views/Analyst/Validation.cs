using BB_App.Core.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BB_App.Core.Views.Analyst
{
    public partial class Validation : Form
    {

        #region Fields
        private int id;
        private string mode;
        private string type;
        #endregion

        public Validation(int _id, string _mode, string _type)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            id = _id;
            mode = _mode;
            type = _type;

            if (type == "requests")
            {
                Size = new Size(335, 279);
                label2.Show();
                numericUpDown1.Show();
            }
            else
            {
                Size = new Size(335, 193);
                label2.Hide();
                numericUpDown1.Hide();
            }

            if (mode == "unvalidation")
            {
                button1.Text = "Unvalidate";
                numericUpDown1.Enabled = false;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mode == "validation")
                {
                    if (type == "donations")
                        ValidateDonation();
                    else if (type == "requests")
                        ValidateRequest();
                }
                else if (mode == "unvalidation")
                    if (type == "donations")
                        UnvalidateDonation();
                    else if (type == "requests")
                        UnvalidateRequest();
            } catch { }
        }

        private void ValidateDonation()
        {
            if (Requests.ValidateDonation(id, AccountsModel.UserId(AccountsModel.WhoIsConnected())))
            {
                var user = Requests.DonationUser(id);

                Tests.AddTest(user, AccountsModel.UserId(AccountsModel.WhoIsConnected()), Properties.Settings.Default.reference, "Dear user, your blood donation has been validated. Thank you for giving life. Come to our hospital for more informations.");

                MessageBox.Show(@"Donation validated.", @"Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                SetBloodGroup();
                AddBlood();
                Close();
            }
            else
                MessageBox.Show(@"Can't validate the donation. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ValidateRequest()
        {
            if (Requests.ValidateRequest(id, AccountsModel.UserId(AccountsModel.WhoIsConnected()), (int)numericUpDown1.Value))
            {
                var user = Requests.DonationUser(id);

                Tests.AddTest(user, AccountsModel.UserId(AccountsModel.WhoIsConnected()), Properties.Settings.Default.reference, "Dear user, your blood request has been validated. Come to our hospital for more informations.");

                SetBloodGroup();
                RemoveBlood();
                MessageBox.Show(@"Request validated.", @"Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show(@"Can't validate the request. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UnvalidateDonation()
        {
            if (Requests.UnvalidateDonation(id, AccountsModel.UserId(AccountsModel.WhoIsConnected())))
            {
                var user = Requests.DonationUser(id);

                Tests.AddTest(user, AccountsModel.UserId(AccountsModel.WhoIsConnected()), Properties.Settings.Default.reference, "Dear user, your blood donation has been cancelled due to bad test results. Come to our hospital for more informations.");

                SetBloodGroup();
                MessageBox.Show(@"Donation unvalidated !", @"Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show(@"Can't unvalidate the donation. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UnvalidateRequest()
        {
            if (Requests.UnvalidateRequest(id, AccountsModel.UserId(AccountsModel.WhoIsConnected())))
            {
                var user = Requests.DonationUser(id);

                Tests.AddTest(user, AccountsModel.UserId(AccountsModel.WhoIsConnected()), Properties.Settings.Default.reference, "Dear user, your blood request has been cancelled. Come to our hospital for more informations.");

                SetBloodGroup();
                MessageBox.Show(@"Request unvalidated !", @"Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show(@"Can't unvalidate the request. Contact the administrator.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetBloodGroup()
        {
            var bg = Commons.Unformat(comboBox1.Text).ToLower();
            var user = Requests.DonationUser(id);

            if (!User.HasBloodgroup(user))
            {
                User.SetBloodgroup(user, bg);

                Notifications.AddNotification(user, "Dear user your bloodgroup was automatically set to " + comboBox1.Text + " after the analysis of your blood.", "New blood group");
            }

        }

        private void AddBlood()
        {
            var bg = new User(Requests.DonationUser(id)).BloodGroup.ToLower();
            var previousValue = 0;

            foreach (var blood in Models.Bloods.BloodsList)
            {
                if (blood.BloodGroup.ToLower() == bg)
                    previousValue = blood.BloodUnits;
            }
            
            var unit = new Requests.Donation(id).Unit + previousValue;
            Models.Bloods.ChangeBloodValue(bg, unit);
        }

        private void RemoveBlood()
        {
            var bg = new Requests.Request(id).Bloodgroup.ToLower();
            var previousValue = 0;

            foreach (var blood in Models.Bloods.BloodsList)
            {
                if (blood.BloodGroup.ToLower() == bg)
                    previousValue = blood.BloodUnits;
            }

            var unit = previousValue - (int)numericUpDown1.Value;
            Models.Bloods.ChangeBloodValue(bg, unit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Validation_Load(object sender, EventArgs e)
        {
            
        }
    }
}
