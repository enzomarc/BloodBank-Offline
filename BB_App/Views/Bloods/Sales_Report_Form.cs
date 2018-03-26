using System;
using System.Windows.Forms;
using static BB_App.Models.BloodSale;
using static BB_App.Models.Commons;

namespace BB_App.Views.Bloods
{
    public partial class Sales_Report_Form : UserControl
    {
        public Sales_Report_Form()
        {
            InitializeComponent();
        }

        #region UI Methods

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
            ((Main)ParentForm).LoadForm(new BloodDashboard());
        }

        private void Sales_Report_Form_Load(object sender, EventArgs e)
        {
            reportDGV.DataSource = loadReports();
            reportDGV.DataMember = "sales";
            reportDGV.ReadOnly = true;
            reportDGV.Columns[0].HeaderText = @"Sale ID";
            reportDGV.Columns[1].HeaderText = @"Bloodgroup";
            reportDGV.Columns[2].HeaderText = @"Sale Date";
            reportDGV.Columns[3].HeaderText = @"Units";
            reportDGV.Columns[4].HeaderText = @"Total Price";

            foreach (DataGridViewRow t in reportDGV.Rows)
            {
                t.Cells[1].Value = Format(t.Cells[1].Value.ToString());
            }
        }

        #endregion

    }
}
