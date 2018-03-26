namespace BB_App.Core.Views
{
    partial class DonationsForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationsForm));
			this.donationsDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.addButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.menuButton = new System.Windows.Forms.PictureBox();
			this.closeButton = new System.Windows.Forms.PictureBox();
			this.logo = new System.Windows.Forms.PictureBox();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
			((System.ComponentModel.ISupportInitialize)(this.donationsDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.SuspendLayout();
			// 
			// donationsDGV
			// 
			this.donationsDGV.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.donationsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.donationsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.donationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.donationsDGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
			this.donationsDGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
			this.donationsDGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
			this.donationsDGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
			this.donationsDGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
			this.donationsDGV.Location = new System.Drawing.Point(16, 146);
			this.donationsDGV.Name = "donationsDGV";
			this.donationsDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.donationsDGV.RowHeadersVisible = false;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.donationsDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.donationsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.donationsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.donationsDGV.ShowCellErrors = false;
			this.donationsDGV.ShowCellToolTips = false;
			this.donationsDGV.ShowEditingIcon = false;
			this.donationsDGV.ShowRowErrors = false;
			this.donationsDGV.Size = new System.Drawing.Size(781, 413);
			this.donationsDGV.StateCommon.Background.Color1 = System.Drawing.Color.White;
			this.donationsDGV.StateCommon.Background.Color2 = System.Drawing.Color.White;
			this.donationsDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
			this.donationsDGV.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.donationsDGV.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.donationsDGV.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.donationsDGV.StateCommon.DataCell.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.donationsDGV.StateCommon.DataCell.Content.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.donationsDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
			this.donationsDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.donationsDGV.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
			this.donationsDGV.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Roboto Medium", 8.75F);
			this.donationsDGV.TabIndex = 0;
			this.donationsDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.donationsDGV_CellEndEdit);
			this.donationsDGV.SelectionChanged += new System.EventHandler(this.donationsDGV_SelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(328, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 32);
			this.label1.TabIndex = 17;
			this.label1.Text = "Donations Management";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			// 
			// addButton
			// 
			this.addButton.Activecolor = System.Drawing.Color.WhiteSmoke;
			this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
			this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.addButton.BorderRadius = 7;
			this.addButton.ButtonText = "Add Donation";
			this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addButton.DisabledColor = System.Drawing.Color.Gray;
			this.addButton.Iconcolor = System.Drawing.Color.Transparent;
			this.addButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("addButton.Iconimage")));
			this.addButton.Iconimage_right = null;
			this.addButton.Iconimage_right_Selected = null;
			this.addButton.Iconimage_Selected = null;
			this.addButton.IconMarginLeft = 5;
			this.addButton.IconMarginRight = 0;
			this.addButton.IconRightVisible = true;
			this.addButton.IconRightZoom = 0D;
			this.addButton.IconVisible = true;
			this.addButton.IconZoom = 40D;
			this.addButton.IsTab = false;
			this.addButton.Location = new System.Drawing.Point(672, 573);
			this.addButton.Name = "addButton";
			this.addButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
			this.addButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.addButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.addButton.selected = false;
			this.addButton.Size = new System.Drawing.Size(125, 48);
			this.addButton.TabIndex = 20;
			this.addButton.Text = "Add Donation";
			this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.addButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
			this.addButton.Click += new System.EventHandler(this.profileButton_Click);
			// 
			// menuButton
			// 
			this.menuButton.Image = global::BB_App.Core.Properties.Resources.Left_15px;
			this.menuButton.Location = new System.Drawing.Point(16, 15);
			this.menuButton.Name = "menuButton";
			this.menuButton.Size = new System.Drawing.Size(18, 18);
			this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.menuButton.TabIndex = 19;
			this.menuButton.TabStop = false;
			this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
			this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
			this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
			// 
			// closeButton
			// 
			this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
			this.closeButton.Location = new System.Drawing.Point(779, 15);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(18, 18);
			this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.closeButton.TabIndex = 18;
			this.closeButton.TabStop = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
			this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
			// 
			// logo
			// 
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.Location = new System.Drawing.Point(290, 79);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(32, 32);
			this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logo.TabIndex = 16;
			this.logo.TabStop = false;
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.WhiteSmoke;
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 7;
			this.bunifuFlatButton1.ButtonText = "Update Database";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 5;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 40D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(503, 573);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.WhiteSmoke;
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(150, 48);
			this.bunifuFlatButton1.TabIndex = 21;
			this.bunifuFlatButton1.Text = "Update Database";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
			this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
			// 
			// bunifuFlatButton2
			// 
			this.bunifuFlatButton2.Activecolor = System.Drawing.Color.WhiteSmoke;
			this.bunifuFlatButton2.AutoSize = true;
			this.bunifuFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.bunifuFlatButton2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 7;
			this.bunifuFlatButton2.ButtonText = "From ";
			this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 5;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = false;
			this.bunifuFlatButton2.IconRightZoom = 0D;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 40D;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new System.Drawing.Point(16, 573);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.WhiteSmoke;
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(295, 48);
			this.bunifuFlatButton2.TabIndex = 22;
			this.bunifuFlatButton2.Text = "From ";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
			this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
			// 
			// DonationsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.bunifuFlatButton2);
			this.Controls.Add(this.bunifuFlatButton1);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.menuButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.logo);
			this.Controls.Add(this.donationsDGV);
			this.Name = "DonationsForm";
			this.Size = new System.Drawing.Size(813, 646);
			this.Load += new System.EventHandler(this.Donations_Load);
			((System.ComponentModel.ISupportInitialize)(this.donationsDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView donationsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton addButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
