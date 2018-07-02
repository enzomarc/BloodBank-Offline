using System; using static BB_App.Helpers.FormsHelpers;
using System.Windows.Forms;
using BB_App.Core.Models;
using BB_App.Core.Properties;
using BB_App.Core.Views.Seekers;

namespace BB_App.Core.Views.Analyst
{
    public partial class DonationResult : UserControl
    {
        public DonationResult()
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
            // Load all requests from the database
            
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
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            LoadForm(((Main)ParentForm)?.frmContainer, new AddType());
        }

        private void requestsDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
            } catch { }
        }

        #endregion

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                
            }
            catch{ }

        }
    }
}