namespace BB_App.Views.Bloods
{
    partial class Blood_Sale_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Sale_Form));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.saleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitsPrice = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numberUnits = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.bloodGD = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.dateTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // saleBtn
            // 
            this.saleBtn.Activecolor = System.Drawing.Color.Gainsboro;
            this.saleBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saleBtn.BorderRadius = 7;
            this.saleBtn.ButtonText = "SALE";
            this.saleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saleBtn.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.saleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saleBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("saleBtn.Iconimage")));
            this.saleBtn.Iconimage_right = null;
            this.saleBtn.Iconimage_right_Selected = null;
            this.saleBtn.Iconimage_Selected = null;
            this.saleBtn.IconMarginLeft = 0;
            this.saleBtn.IconMarginRight = 0;
            this.saleBtn.IconRightVisible = true;
            this.saleBtn.IconRightZoom = 0D;
            this.saleBtn.IconVisible = false;
            this.saleBtn.IconZoom = 90D;
            this.saleBtn.IsTab = false;
            this.saleBtn.Location = new System.Drawing.Point(327, 502);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.saleBtn.OnHovercolor = System.Drawing.Color.LightGray;
            this.saleBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.saleBtn.selected = false;
            this.saleBtn.Size = new System.Drawing.Size(150, 38);
            this.saleBtn.TabIndex = 72;
            this.saleBtn.Text = "SALE";
            this.saleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saleBtn.Textcolor = System.Drawing.Color.Black;
            this.saleBtn.TextFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.priceLabel.Location = new System.Drawing.Point(273, 413);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(157, 20);
            this.priceLabel.TabIndex = 71;
            this.priceLabel.Text = "1 Frcs";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.label4.Location = new System.Drawing.Point(188, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Total price";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.label2.Location = new System.Drawing.Point(188, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 69;
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
            this.unitsPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitsPrice.Name = "unitsPrice";
            this.unitsPrice.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.unitsPrice.Size = new System.Drawing.Size(312, 39);
            this.unitsPrice.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.unitsPrice.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.unitsPrice.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.unitsPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.unitsPrice.StateCommon.Border.Rounding = 27;
            this.unitsPrice.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F);
            this.unitsPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.unitsPrice.TabIndex = 68;
            this.unitsPrice.ThousandsSeparator = true;
            this.unitsPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitsPrice.ValueChanged += new System.EventHandler(this.unitsPrice_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 9F);
            this.label3.Location = new System.Drawing.Point(188, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Number of units";
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
            this.numberUnits.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.numberUnits.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.numberUnits.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.numberUnits.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numberUnits.StateCommon.Border.Rounding = 27;
            this.numberUnits.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F);
            this.numberUnits.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.numberUnits.TabIndex = 66;
            this.numberUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUnits.ValueChanged += new System.EventHandler(this.unitsPrice_ValueChanged);
            // 
            // bloodGD
            // 
            this.bloodGD.ContextMenuStrip = this.contextMenuStrip1;
            this.bloodGD.Location = new System.Drawing.Point(188, 167);
            this.bloodGD.Name = "bloodGD";
            this.bloodGD.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.bloodGD.Size = new System.Drawing.Size(436, 39);
            this.bloodGD.Splitter = false;
            this.bloodGD.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.bloodGD.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.bloodGD.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.bloodGD.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.bloodGD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bloodGD.StateCommon.Border.Rounding = 20;
            this.bloodGD.TabIndex = 65;
            this.bloodGD.Values.Text = "Blood Group";
            // 
            // dateTime
            // 
            this.dateTime.Checked = false;
            this.dateTime.CustomNullText = "Sale Date ...";
            this.dateTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTime.Location = new System.Drawing.Point(188, 229);
            this.dateTime.Name = "dateTime";
            this.dateTime.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dateTime.Size = new System.Drawing.Size(436, 40);
            this.dateTime.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dateTime.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.dateTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateTime.StateCommon.Border.Rounding = 30;
            this.dateTime.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F);
            this.dateTime.TabIndex = 64;
            // 
            // menuButton
            // 
            this.menuButton.Image = global::BB_App.Properties.Resources.Left_15px;
            this.menuButton.Location = new System.Drawing.Point(16, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(18, 18);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 63;
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
            this.closeButton.TabIndex = 62;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 61;
            this.label1.Text = "Blood Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(339, 79);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 60;
            this.logo.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // Blood_Sale_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.saleBtn);
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
            this.Name = "Blood_Sale_Form";
            this.Size = new System.Drawing.Size(813, 646);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton saleBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown unitsPrice;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numberUnits;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton bloodGD;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTime;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
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
