namespace BB_App.Core.Views.Administration
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Electronic Blood Bank - Administration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
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
            this.profileButton.Activecolor = System.Drawing.Color.White;
            this.profileButton.BackColor = System.Drawing.Color.White;
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
            this.profileButton.Location = new System.Drawing.Point(355, 581);
            this.profileButton.Name = "profileButton";
            this.profileButton.Normalcolor = System.Drawing.Color.White;
            this.profileButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.profileButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.profileButton.selected = false;
            this.profileButton.Size = new System.Drawing.Size(108, 48);
            this.profileButton.TabIndex = 27;
            this.profileButton.Text = "John Doe";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.profileButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            // 
            // logo
            // 
            this.logo.Image = global::BB_App.Core.Properties.Resources.HeartMouse_32px;
            this.logo.Location = new System.Drawing.Point(219, 82);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton4.color = System.Drawing.Color.White;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 28;
            this.bunifuTileButton4.ImageZoom = 32;
            this.bunifuTileButton4.LabelPosition = 25;
            this.bunifuTileButton4.LabelText = "LOGOUT";
            this.bunifuTileButton4.Location = new System.Drawing.Point(432, 356);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton4.TabIndex = 24;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton6.color = System.Drawing.Color.White;
            this.bunifuTileButton6.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton6.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton6.Image")));
            this.bunifuTileButton6.ImagePosition = 18;
            this.bunifuTileButton6.ImageZoom = 45;
            this.bunifuTileButton6.LabelPosition = 25;
            this.bunifuTileButton6.LabelText = "HOSPITAL MANAGEMENT";
            this.bunifuTileButton6.Location = new System.Drawing.Point(266, 356);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton6.TabIndex = 22;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton3.color = System.Drawing.Color.White;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 45;
            this.bunifuTileButton3.LabelPosition = 25;
            this.bunifuTileButton3.LabelText = "BLOOD REQUEST";
            this.bunifuTileButton3.Location = new System.Drawing.Point(432, 198);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton3.TabIndex = 21;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton1.color = System.Drawing.Color.White;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Roboto Medium", 6.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 15;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 25;
            this.bunifuTileButton1.LabelText = "MANAGE USERS";
            this.bunifuTileButton1.Location = new System.Drawing.Point(266, 198);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(116, 112);
            this.bunifuTileButton1.TabIndex = 19;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = global::BB_App.Core.Properties.Resources.Left_15px;
            this.menuButton.Location = new System.Drawing.Point(16, 18);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(18, 18);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 18;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(779, 18);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 17;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.bunifuTileButton6);
            this.Controls.Add(this.bunifuTileButton3);
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

        private Bunifu.Framework.UI.BunifuFlatButton profileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
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
