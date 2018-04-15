namespace BB_App.Core.Controls
{
    partial class CustomListBoxItem
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
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.textLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 39);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(231, 1);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.LightGray;
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.MouseEnter += new System.EventHandler(this.kryptonBorderEdge1_MouseEnter);
            this.kryptonBorderEdge1.MouseLeave += new System.EventHandler(this.kryptonBorderEdge1_MouseLeave);
            // 
            // textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLabel.Font = new System.Drawing.Font("Roboto", 8F);
            this.textLabel.Location = new System.Drawing.Point(30, 10);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(190, 23);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "John Doe";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textLabel.MouseEnter += new System.EventHandler(this.kryptonBorderEdge1_MouseEnter);
            this.textLabel.MouseLeave += new System.EventHandler(this.kryptonBorderEdge1_MouseLeave);
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox.Image = global::BB_App.Core.Properties.Resources.Unchecked_Checkbox_Def;
            this.checkBox.Location = new System.Drawing.Point(7, 12);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(16, 16);
            this.checkBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkBox.TabIndex = 2;
            this.checkBox.TabStop = false;
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click);
            this.checkBox.MouseEnter += new System.EventHandler(this.kryptonBorderEdge1_MouseEnter);
            this.checkBox.MouseLeave += new System.EventHandler(this.kryptonBorderEdge1_MouseLeave);
            // 
            // CustomListBoxItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Name = "CustomListBoxItem";
            this.Size = new System.Drawing.Size(231, 40);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox checkBox;
    }
}
