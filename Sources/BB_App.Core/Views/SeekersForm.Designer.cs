namespace BB_App.Core.Views
{
    partial class SeekersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeekersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.requestsDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.fromLabel = new System.Windows.Forms.Label();
            this.deleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Activecolor = System.Drawing.Color.White;
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.White;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.BorderRadius = 7;
            this.updateButton.ButtonText = "Send to verification";
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.DisabledColor = System.Drawing.Color.White;
            this.updateButton.Enabled = false;
            this.updateButton.Iconcolor = System.Drawing.Color.Transparent;
            this.updateButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateButton.Iconimage")));
            this.updateButton.Iconimage_right = null;
            this.updateButton.Iconimage_right_Selected = null;
            this.updateButton.Iconimage_Selected = null;
            this.updateButton.IconMarginLeft = 5;
            this.updateButton.IconMarginRight = 0;
            this.updateButton.IconRightVisible = true;
            this.updateButton.IconRightZoom = 0D;
            this.updateButton.IconVisible = true;
            this.updateButton.IconZoom = 40D;
            this.updateButton.IsTab = false;
            this.updateButton.Location = new System.Drawing.Point(382, 572);
            this.updateButton.Name = "updateButton";
            this.updateButton.Normalcolor = System.Drawing.Color.White;
            this.updateButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.updateButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.updateButton.selected = false;
            this.updateButton.Size = new System.Drawing.Size(155, 48);
            this.updateButton.TabIndex = 29;
            this.updateButton.Text = "Send to verification";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.updateButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Activecolor = System.Drawing.Color.White;
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.BorderRadius = 7;
            this.addButton.ButtonText = "Add Request";
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
            this.addButton.IconRightZoom = 41D;
            this.addButton.IconVisible = true;
            this.addButton.IconZoom = 40D;
            this.addButton.IsTab = false;
            this.addButton.Location = new System.Drawing.Point(681, 572);
            this.addButton.Name = "addButton";
            this.addButton.Normalcolor = System.Drawing.Color.White;
            this.addButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.addButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addButton.selected = false;
            this.addButton.Size = new System.Drawing.Size(116, 48);
            this.addButton.TabIndex = 28;
            this.addButton.Text = "Add Request";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = global::BB_App.Core.Properties.Resources.Left_15px;
            this.menuButton.Location = new System.Drawing.Point(16, 15);
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
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(779, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 26;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Blood Requests Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(263, 90);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 24;
            this.logo.TabStop = false;
            // 
            // requestsDGV
            // 
            this.requestsDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.requestsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.requestsDGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.requestsDGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.requestsDGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.requestsDGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.requestsDGV.Location = new System.Drawing.Point(16, 157);
            this.requestsDGV.MultiSelect = false;
            this.requestsDGV.Name = "requestsDGV";
            this.requestsDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.requestsDGV.ReadOnly = true;
            this.requestsDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.requestsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestsDGV.ShowCellErrors = false;
            this.requestsDGV.ShowCellToolTips = false;
            this.requestsDGV.ShowEditingIcon = false;
            this.requestsDGV.ShowRowErrors = false;
            this.requestsDGV.Size = new System.Drawing.Size(781, 401);
            this.requestsDGV.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.requestsDGV.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.requestsDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.requestsDGV.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.requestsDGV.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.requestsDGV.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.requestsDGV.StateCommon.DataCell.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.requestsDGV.StateCommon.DataCell.Content.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.requestsDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.requestsDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.requestsDGV.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.requestsDGV.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Roboto Medium", 8.75F);
            this.requestsDGV.TabIndex = 23;
            this.requestsDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestsDGV_CellEndEdit);
            this.requestsDGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.requestsDGV_RowsRemoved);
            this.requestsDGV.SelectionChanged += new System.EventHandler(this.requestsDGV_SelectionChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoEllipsis = true;
            this.fromLabel.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.fromLabel.Location = new System.Drawing.Point(13, 589);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(325, 16);
            this.fromLabel.TabIndex = 31;
            this.fromLabel.Text = "From";
            // 
            // deleteButton
            // 
            this.deleteButton.Activecolor = System.Drawing.Color.White;
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.BorderRadius = 7;
            this.deleteButton.ButtonText = "Delete Request";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledColor = System.Drawing.Color.White;
            this.deleteButton.Enabled = false;
            this.deleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteButton.Iconimage")));
            this.deleteButton.Iconimage_right = null;
            this.deleteButton.Iconimage_right_Selected = null;
            this.deleteButton.Iconimage_Selected = null;
            this.deleteButton.IconMarginLeft = 5;
            this.deleteButton.IconMarginRight = 0;
            this.deleteButton.IconRightVisible = true;
            this.deleteButton.IconRightZoom = 0D;
            this.deleteButton.IconVisible = true;
            this.deleteButton.IconZoom = 40D;
            this.deleteButton.IsTab = false;
            this.deleteButton.Location = new System.Drawing.Point(543, 572);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Normalcolor = System.Drawing.Color.White;
            this.deleteButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.deleteButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.deleteButton.selected = false;
            this.deleteButton.Size = new System.Drawing.Size(132, 48);
            this.deleteButton.TabIndex = 32;
            this.deleteButton.Text = "Delete Request";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.deleteButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SeekersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.requestsDGV);
            this.Name = "SeekersForm";
            this.Size = new System.Drawing.Size(813, 646);
            this.Load += new System.EventHandler(this.Seekers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton updateButton;
        private Bunifu.Framework.UI.BunifuFlatButton addButton;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView requestsDGV;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label fromLabel;
        private Bunifu.Framework.UI.BunifuFlatButton deleteButton;
    }
}
