namespace BB_App.Core.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodBankWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBloodBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Electronic Blood Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDatabaseToolStripMenuItem,
            this.updateSoftwareToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(171, 92);
            // 
            // updateDatabaseToolStripMenuItem
            // 
            this.updateDatabaseToolStripMenuItem.Name = "updateDatabaseToolStripMenuItem";
            this.updateDatabaseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.updateDatabaseToolStripMenuItem.Text = "Update Database";
            // 
            // updateSoftwareToolStripMenuItem
            // 
            this.updateSoftwareToolStripMenuItem.Name = "updateSoftwareToolStripMenuItem";
            this.updateSoftwareToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.updateSoftwareToolStripMenuItem.Text = "Check for updates";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloodBankWebsiteToolStripMenuItem,
            this.reportIssueToolStripMenuItem,
            this.aboutBloodBankToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // bloodBankWebsiteToolStripMenuItem
            // 
            this.bloodBankWebsiteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.bloodBankWebsiteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bloodBankWebsiteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bloodBankWebsiteToolStripMenuItem.Name = "bloodBankWebsiteToolStripMenuItem";
            this.bloodBankWebsiteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.bloodBankWebsiteToolStripMenuItem.Text = "BloodBank Website";
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue";
            // 
            // aboutBloodBankToolStripMenuItem
            // 
            this.aboutBloodBankToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.aboutBloodBankToolStripMenuItem.Name = "aboutBloodBankToolStripMenuItem";
            this.aboutBloodBankToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutBloodBankToolStripMenuItem.Text = "About BloodBank";
            // 
            // profileButton
            // 
            this.profileButton.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.profileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileButton.BorderRadius = 7;
            this.profileButton.ButtonText = "John Doe";
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.DisabledColor = System.Drawing.Color.Gray;
            this.profileButton.Iconcolor = System.Drawing.Color.Transparent;
            this.profileButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("profileButton.Iconimage")));
            this.profileButton.Iconimage_right = null;
            this.profileButton.Iconimage_right_Selected = null;
            this.profileButton.Iconimage_Selected = null;
            this.profileButton.IconMarginLeft = 0;
            this.profileButton.IconMarginRight = 0;
            this.profileButton.IconRightVisible = false;
            this.profileButton.IconRightZoom = 0D;
            this.profileButton.IconVisible = true;
            this.profileButton.IconZoom = 55D;
            this.profileButton.IsTab = false;
            this.profileButton.Location = new System.Drawing.Point(355, 578);
            this.profileButton.Name = "profileButton";
            this.profileButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.profileButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.profileButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.profileButton.selected = false;
            this.profileButton.Size = new System.Drawing.Size(108, 48);
            this.profileButton.TabIndex = 16;
            this.profileButton.Text = "John Doe";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.profileButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            // 
            // logo
            // 
            this.logo.Image = global::BB_App.Core.Properties.Resources.HeartMouse_32px;
            this.logo.Location = new System.Drawing.Point(290, 79);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
            this.logo.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.logo.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton4.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 28;
            this.bunifuTileButton4.ImageZoom = 32;
            this.bunifuTileButton4.LabelPosition = 25;
            this.bunifuTileButton4.LabelText = "LOGOUT";
            this.bunifuTileButton4.Location = new System.Drawing.Point(481, 353);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton4.TabIndex = 13;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton5.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 18;
            this.bunifuTileButton5.ImageZoom = 45;
            this.bunifuTileButton5.LabelPosition = 25;
            this.bunifuTileButton5.LabelText = "ADMINISTRATION";
            this.bunifuTileButton5.Location = new System.Drawing.Point(336, 353);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton5.TabIndex = 12;
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton6.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton6.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton6.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton6.Image")));
            this.bunifuTileButton6.ImagePosition = 18;
            this.bunifuTileButton6.ImageZoom = 45;
            this.bunifuTileButton6.LabelPosition = 25;
            this.bunifuTileButton6.LabelText = "HOSPITAL MANAGEMENT";
            this.bunifuTileButton6.Location = new System.Drawing.Point(189, 353);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton6.TabIndex = 11;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton3.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 45;
            this.bunifuTileButton3.LabelPosition = 25;
            this.bunifuTileButton3.LabelText = "SEEKERS";
            this.bunifuTileButton3.Location = new System.Drawing.Point(481, 195);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton3.TabIndex = 10;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton2.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 15;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 25;
            this.bunifuTileButton2.LabelText = "DONATIONS";
            this.bunifuTileButton2.Location = new System.Drawing.Point(336, 195);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton2.TabIndex = 9;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton1.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 15;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 25;
            this.bunifuTileButton1.LabelText = "BLOOD MANAGEMENT";
            this.bunifuTileButton1.Location = new System.Drawing.Point(189, 195);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton1.TabIndex = 8;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(16, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(18, 18);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 1;
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
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.bunifuTileButton6);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.closeButton);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(813, 646);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox menuButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton profileButton;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem updateDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodBankWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBloodBankToolStripMenuItem;
    }
}
