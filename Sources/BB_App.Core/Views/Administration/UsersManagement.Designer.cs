namespace BB_App.Core.Views.Administration
{
    partial class UsersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.deleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.accountType = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.usersListBox = new BB_App.Core.Controls.CustomListBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Administration - Manage Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.Image = global::BB_App.Core.Properties.Resources.HeartMouse_32px;
            this.logo.Location = new System.Drawing.Point(255, 82);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 34;
            this.logo.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(779, 18);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 28;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(60, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Users List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(64, 195);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(100, 1);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonBorderEdge1.StateCommon.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(420, 195);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(100, 1);
            this.kryptonBorderEdge2.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonBorderEdge2.StateCommon.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(416, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Account Informations";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoEllipsis = true;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 10F);
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(416, 233);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(316, 19);
            this.usernameLabel.TabIndex = 42;
            this.usernameLabel.Text = "Username : ";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoEllipsis = true;
            this.typeLabel.Font = new System.Drawing.Font("Roboto", 10F);
            this.typeLabel.ForeColor = System.Drawing.Color.Black;
            this.typeLabel.Location = new System.Drawing.Point(416, 277);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(316, 19);
            this.typeLabel.TabIndex = 43;
            this.typeLabel.Text = "Account Type : ";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteButton
            // 
            this.deleteButton.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.BorderRadius = 7;
            this.deleteButton.ButtonText = "Delete Account";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledColor = System.Drawing.Color.Gray;
            this.deleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteButton.Iconimage = null;
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
            this.deleteButton.Location = new System.Drawing.Point(402, 318);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.deleteButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.deleteButton.selected = false;
            this.deleteButton.Size = new System.Drawing.Size(110, 35);
            this.deleteButton.TabIndex = 44;
            this.deleteButton.Text = "Delete Account";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.deleteButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.BorderRadius = 7;
            this.addButton.ButtonText = "Add Account";
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.DisabledColor = System.Drawing.Color.Gray;
            this.addButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addButton.Iconimage = null;
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
            this.addButton.Location = new System.Drawing.Point(419, 562);
            this.addButton.Name = "addButton";
            this.addButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.addButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.addButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addButton.selected = false;
            this.addButton.Size = new System.Drawing.Size(99, 37);
            this.addButton.TabIndex = 45;
            this.addButton.Text = "Add Account";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addButton.TextFont = new System.Drawing.Font("Roboto Medium", 9F);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(420, 426);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(100, 1);
            this.kryptonBorderEdge3.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonBorderEdge3.StateCommon.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonBorderEdge3.Text = "kryptonBorderEdge3";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(416, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Add Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(419, 442);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(261, 31);
            this.usernameBox.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.usernameBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.usernameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameBox.StateCommon.Border.Rounding = 3;
            this.usernameBox.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.usernameBox.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.usernameBox.TabIndex = 49;
            this.usernameBox.Text = "Username ...";
            this.usernameBox.Enter += new System.EventHandler(this.usernameBox_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.usernameBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(419, 479);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(261, 31);
            this.passwordBox.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.passwordBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.passwordBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordBox.StateCommon.Border.Rounding = 3;
            this.passwordBox.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.passwordBox.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.passwordBox.TabIndex = 50;
            this.passwordBox.Text = "Password ...";
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // accountType
            // 
            this.accountType.ContextMenuStrip = this.contextMenuStrip2;
            this.accountType.Location = new System.Drawing.Point(419, 516);
            this.accountType.Name = "accountType";
            this.accountType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.accountType.Size = new System.Drawing.Size(261, 31);
            this.accountType.Splitter = false;
            this.accountType.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.accountType.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.accountType.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.accountType.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.accountType.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.accountType.StateCommon.Border.Rounding = 3;
            this.accountType.TabIndex = 51;
            this.accountType.Values.Text = "Account Type";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.administratorToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(148, 70);
            this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem1.Text = "Default";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem3.Text = "Analyst";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // menuButton
            // 
            this.menuButton.Image = global::BB_App.Core.Properties.Resources.Left_15px;
            this.menuButton.Location = new System.Drawing.Point(16, 18);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(18, 18);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 53;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // usersListBox
            // 
            this.usersListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usersListBox.Location = new System.Drawing.Point(64, 204);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(264, 395);
            this.usersListBox.TabIndex = 36;
            // 
            // UsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.kryptonBorderEdge3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.kryptonBorderEdge2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.closeButton);
            this.Name = "UsersManagement";
            this.Size = new System.Drawing.Size(813, 646);
            this.Load += new System.EventHandler(this.UsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox closeButton;
        private Controls.CustomListBox usersListBox;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label typeLabel;
        private Bunifu.Framework.UI.BunifuFlatButton deleteButton;
        private Bunifu.Framework.UI.BunifuFlatButton addButton;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton accountType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.PictureBox menuButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
