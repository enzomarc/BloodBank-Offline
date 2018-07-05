namespace BB_App.Core.Views.Bloods
{
    partial class Blood_Purchase_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Purchase_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.bloodGD = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.numberUnits = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitsPrice = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.purchaseBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Blood Purchase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bloodGD
            // 
            this.bloodGD.ContextMenuStrip = this.contextMenuStrip1;
            this.bloodGD.Location = new System.Drawing.Point(188, 167);
            this.bloodGD.Name = "bloodGD";
            this.bloodGD.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.bloodGD.Size = new System.Drawing.Size(436, 39);
            this.bloodGD.Splitter = false;
            this.bloodGD.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.bloodGD.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.bloodGD.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.bloodGD.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.bloodGD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bloodGD.StateCommon.Border.Rounding = 20;
            this.bloodGD.TabIndex = 45;
            this.bloodGD.Values.Text = "Blood Group";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.bToolStripMenuItem1,
            this.bToolStripMenuItem2,
            this.aBToolStripMenuItem,
            this.aBToolStripMenuItem1,
            this.oToolStripMenuItem,
            this.oToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 202);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.aToolStripMenuItem.Text = "Unknow";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.bToolStripMenuItem.Text = "A+";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.aToolStripMenuItem1.Text = "A-";
            // 
            // bToolStripMenuItem1
            // 
            this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            this.bToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.bToolStripMenuItem1.Text = "B+";
            // 
            // bToolStripMenuItem2
            // 
            this.bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            this.bToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.bToolStripMenuItem2.Text = "B-";
            // 
            // aBToolStripMenuItem
            // 
            this.aBToolStripMenuItem.Name = "aBToolStripMenuItem";
            this.aBToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.aBToolStripMenuItem.Text = "AB+";
            // 
            // aBToolStripMenuItem1
            // 
            this.aBToolStripMenuItem1.Name = "aBToolStripMenuItem1";
            this.aBToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.aBToolStripMenuItem1.Text = "AB-";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.oToolStripMenuItem.Text = "O+";
            // 
            // oToolStripMenuItem1
            // 
            this.oToolStripMenuItem1.Name = "oToolStripMenuItem1";
            this.oToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.oToolStripMenuItem1.Text = "O-";
            // 
            // dateTime
            // 
            this.dateTime.Checked = false;
            this.dateTime.CustomNullText = "Purchase Date ...";
            this.dateTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTime.Location = new System.Drawing.Point(188, 229);
            this.dateTime.Name = "dateTime";
            this.dateTime.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dateTime.Size = new System.Drawing.Size(436, 40);
            this.dateTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dateTime.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.dateTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateTime.StateCommon.Border.Rounding = 30;
            this.dateTime.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F);
            this.dateTime.TabIndex = 44;
            // 
            // numberUnits
            // 
            this.numberUnits.Location = new System.Drawing.Point(312, 291);
            this.numberUnits.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberUnits.Name = "numberUnits";
            this.numberUnits.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.numberUnits.Size = new System.Drawing.Size(312, 39);
            this.numberUnits.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.numberUnits.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.numberUnits.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.numberUnits.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numberUnits.StateCommon.Border.Rounding = 27;
            this.numberUnits.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F);
            this.numberUnits.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.numberUnits.TabIndex = 48;
            this.numberUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUnits.ValueChanged += new System.EventHandler(this.unitsPrice_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.label3.Location = new System.Drawing.Point(188, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Number of units";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.label2.Location = new System.Drawing.Point(188, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Unit price";
            // 
            // unitsPrice
            // 
            this.unitsPrice.Location = new System.Drawing.Point(312, 346);
            this.unitsPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.unitsPrice.Name = "unitsPrice";
            this.unitsPrice.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.unitsPrice.Size = new System.Drawing.Size(312, 39);
            this.unitsPrice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.unitsPrice.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.unitsPrice.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.unitsPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.unitsPrice.StateCommon.Border.Rounding = 27;
            this.unitsPrice.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F);
            this.unitsPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.unitsPrice.TabIndex = 55;
            this.unitsPrice.ThousandsSeparator = true;
            this.unitsPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitsPrice.ValueChanged += new System.EventHandler(this.unitsPrice_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.label4.Location = new System.Drawing.Point(188, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Total price";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.priceLabel.Location = new System.Drawing.Point(273, 413);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(157, 20);
            this.priceLabel.TabIndex = 58;
            this.priceLabel.Text = "1 Frcs";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Activecolor = System.Drawing.Color.Gainsboro;
            this.purchaseBtn.BackColor = System.Drawing.Color.White;
            this.purchaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchaseBtn.BorderRadius = 7;
            this.purchaseBtn.ButtonText = "PURCHASE";
            this.purchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseBtn.DisabledColor = System.Drawing.Color.Gray;
            this.purchaseBtn.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.purchaseBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.purchaseBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("purchaseBtn.Iconimage")));
            this.purchaseBtn.Iconimage_right = null;
            this.purchaseBtn.Iconimage_right_Selected = null;
            this.purchaseBtn.Iconimage_Selected = null;
            this.purchaseBtn.IconMarginLeft = 0;
            this.purchaseBtn.IconMarginRight = 0;
            this.purchaseBtn.IconRightVisible = true;
            this.purchaseBtn.IconRightZoom = 0D;
            this.purchaseBtn.IconVisible = false;
            this.purchaseBtn.IconZoom = 90D;
            this.purchaseBtn.IsTab = false;
            this.purchaseBtn.Location = new System.Drawing.Point(327, 502);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Normalcolor = System.Drawing.Color.White;
            this.purchaseBtn.OnHovercolor = System.Drawing.Color.LightGray;
            this.purchaseBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.purchaseBtn.selected = false;
            this.purchaseBtn.Size = new System.Drawing.Size(150, 38);
            this.purchaseBtn.TabIndex = 59;
            this.purchaseBtn.Text = "PURCHASE";
            this.purchaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchaseBtn.Textcolor = System.Drawing.Color.Black;
            this.purchaseBtn.TextFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
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
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(310, 79);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 24;
            this.logo.TabStop = false;
            // 
            // Blood_Purchase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitsPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberUnits);
            this.Controls.Add(this.bloodGD);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Name = "Blood_Purchase_Form";
            this.Size = new System.Drawing.Size(813, 646);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton bloodGD;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numberUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown unitsPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceLabel;
        private Bunifu.Framework.UI.BunifuFlatButton purchaseBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem1;
    }
}
