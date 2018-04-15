namespace BB_App.Core.Controls
{
    partial class CustomListBox
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
            this.ItemsContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ItemsContainer
            // 
            this.ItemsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsContainer.AutoScroll = true;
            this.ItemsContainer.Location = new System.Drawing.Point(9, 9);
            this.ItemsContainer.Name = "ItemsContainer";
            this.ItemsContainer.Size = new System.Drawing.Size(245, 383);
            this.ItemsContainer.TabIndex = 0;
            // 
            // CustomListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.ItemsContainer);
            this.Name = "CustomListBox";
            this.Size = new System.Drawing.Size(262, 401);
            this.Load += new System.EventHandler(this.CustomListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemsContainer;
    }
}
