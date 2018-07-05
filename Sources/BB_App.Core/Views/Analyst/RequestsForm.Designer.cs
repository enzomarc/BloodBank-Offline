namespace BB_App.Core.Views.Analyst
{
    partial class RequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestsForm));
            this.requestsDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fromLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsDGV
            // 
            this.requestsDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.requestsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.requestsDGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.requestsDGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.requestsDGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.requestsDGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.requestsDGV.Location = new System.Drawing.Point(16, 146);
            this.requestsDGV.Name = "requestsDGV";
            this.requestsDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.requestsDGV.ReadOnly = true;
            this.requestsDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.requestsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestsDGV.ShowCellErrors = false;
            this.requestsDGV.ShowCellToolTips = false;
            this.requestsDGV.ShowEditingIcon = false;
            this.requestsDGV.ShowRowErrors = false;
            this.requestsDGV.Size = new System.Drawing.Size(781, 413);
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
            this.requestsDGV.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.requestsDGV.TabIndex = 0;
            this.requestsDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.donationsDGV_CellEndEdit);
            this.requestsDGV.SelectionChanged += new System.EventHandler(this.donationsDGV_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Requests List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
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
            this.logo.Location = new System.Drawing.Point(323, 79);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Unvalidate request";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Enabled = false;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(632, 573);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(165, 48);
            this.bunifuFlatButton1.TabIndex = 21;
            this.bunifuFlatButton1.Text = "Unvalidate request";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Activecolor = System.Drawing.Color.White;
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.White;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.BorderRadius = 7;
            this.updateButton.ButtonText = "Validate request";
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
            this.updateButton.Location = new System.Drawing.Point(461, 573);
            this.updateButton.Name = "updateButton";
            this.updateButton.Normalcolor = System.Drawing.Color.White;
            this.updateButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.updateButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.updateButton.selected = false;
            this.updateButton.Size = new System.Drawing.Size(152, 48);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Validate request";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.updateButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoEllipsis = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fromLabel.Location = new System.Drawing.Point(15, 591);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(289, 16);
            this.fromLabel.TabIndex = 32;
            this.fromLabel.Text = "From";
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.requestsDGV);
            this.Name = "RequestsForm";
            this.Size = new System.Drawing.Size(813, 646);
            this.Load += new System.EventHandler(this.Donations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView requestsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton updateButton;
        private System.Windows.Forms.Label fromLabel;
    }
}
