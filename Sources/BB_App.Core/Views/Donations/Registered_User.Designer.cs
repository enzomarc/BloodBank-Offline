namespace BB_App.Core.Views.Donations
{
    partial class RegisteredUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisteredUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nextButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.usersDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select the user";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextButton
            // 
            this.nextButton.Activecolor = System.Drawing.Color.White;
            this.nextButton.BackColor = System.Drawing.Color.White;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.BorderRadius = 7;
            this.nextButton.ButtonText = "Next";
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.DisabledColor = System.Drawing.Color.Gray;
            this.nextButton.Iconcolor = System.Drawing.Color.Transparent;
            this.nextButton.Iconimage = null;
            this.nextButton.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("nextButton.Iconimage_right")));
            this.nextButton.Iconimage_right_Selected = null;
            this.nextButton.Iconimage_Selected = null;
            this.nextButton.IconMarginLeft = 5;
            this.nextButton.IconMarginRight = 0;
            this.nextButton.IconRightVisible = true;
            this.nextButton.IconRightZoom = 0D;
            this.nextButton.IconVisible = true;
            this.nextButton.IconZoom = 45D;
            this.nextButton.IsTab = false;
            this.nextButton.Location = new System.Drawing.Point(703, 566);
            this.nextButton.Name = "nextButton";
            this.nextButton.Normalcolor = System.Drawing.Color.White;
            this.nextButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.nextButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.nextButton.selected = false;
            this.nextButton.Size = new System.Drawing.Size(79, 48);
            this.nextButton.TabIndex = 29;
            this.nextButton.Text = "Next";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nextButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.nextButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = global::BB_App.Core.Properties.Resources.Left_15px;
            this.menuButton.Location = new System.Drawing.Point(16, 16);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(18, 18);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 27;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(779, 16);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 26;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(325, 80);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 24;
            this.logo.TabStop = false;
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F);
            this.usersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.ColumnHeadersVisible = false;
            this.usersDGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.usersDGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.usersDGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.usersDGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.usersDGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.usersDGV.Location = new System.Drawing.Point(162, 138);
            this.usersDGV.MultiSelect = false;
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.usersDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F);
            this.usersDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.usersDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.ShowCellErrors = false;
            this.usersDGV.ShowCellToolTips = false;
            this.usersDGV.ShowEditingIcon = false;
            this.usersDGV.ShowRowErrors = false;
            this.usersDGV.Size = new System.Drawing.Size(468, 413);
            this.usersDGV.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.usersDGV.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.usersDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.usersDGV.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.usersDGV.StateCommon.DataCell.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.usersDGV.StateCommon.DataCell.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.usersDGV.StateCommon.DataCell.Content.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.usersDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.usersDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.usersDGV.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.usersDGV.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Roboto Medium", 8.75F);
            this.usersDGV.TabIndex = 30;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Registered_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.usersDGV);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Name = "RegisteredUser";
            this.Size = new System.Drawing.Size(813, 646);
            this.Load += new System.EventHandler(this.Registered_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton nextButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView usersDGV;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
