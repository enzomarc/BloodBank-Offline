namespace BB_App.Core.Views.Analyst
{
    partial class DonationResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationResult));
            this.updateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.fromLabel = new System.Windows.Forms.Label();
            this.deleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.BorderRadius = 7;
            this.updateButton.ButtonText = "Validate Request";
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.DisabledColor = System.Drawing.Color.WhiteSmoke;
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
            this.updateButton.Location = new System.Drawing.Point(394, 572);
            this.updateButton.Name = "updateButton";
            this.updateButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.updateButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.updateButton.selected = false;
            this.updateButton.Size = new System.Drawing.Size(143, 48);
            this.updateButton.TabIndex = 29;
            this.updateButton.Text = "Validate Request";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.updateButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.addButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
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
            this.label1.Location = new System.Drawing.Point(339, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Donation Test Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(301, 90);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 24;
            this.logo.TabStop = false;
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
            this.deleteButton.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.BorderRadius = 7;
            this.deleteButton.ButtonText = "Delete Request";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledColor = System.Drawing.Color.WhiteSmoke;
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
            this.deleteButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(188, 187);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(436, 41);
            this.username.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.username.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.username.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.username.StateCommon.Border.Rounding = 20;
            this.username.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.username.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, 7, 5, 5);
            this.username.TabIndex = 34;
            this.username.Text = "Test result title ...";
            // 
            // DonationResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Name = "DonationResult";
            this.Size = new System.Drawing.Size(813, 646);
            this.Load += new System.EventHandler(this.Seekers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton updateButton;
        private Bunifu.Framework.UI.BunifuFlatButton addButton;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label fromLabel;
        private Bunifu.Framework.UI.BunifuFlatButton deleteButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox username;
    }
}
