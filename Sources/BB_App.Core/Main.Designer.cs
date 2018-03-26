namespace BB_App.Core
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
			this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
			this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
			this.kryptonBorderEdge4 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
			this.frmContainer = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// kryptonBorderEdge1
			// 
			this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 645);
			this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
			this.kryptonBorderEdge1.Size = new System.Drawing.Size(813, 1);
			this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.DarkGray;
			this.kryptonBorderEdge1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
			// 
			// kryptonBorderEdge2
			// 
			this.kryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonBorderEdge2.Location = new System.Drawing.Point(0, 0);
			this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
			this.kryptonBorderEdge2.Size = new System.Drawing.Size(813, 1);
			this.kryptonBorderEdge2.StateCommon.Color1 = System.Drawing.Color.DarkGray;
			this.kryptonBorderEdge2.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.kryptonBorderEdge2.Text = "kryptonBorderEdge2";
			// 
			// kryptonBorderEdge3
			// 
			this.kryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Left;
			this.kryptonBorderEdge3.Location = new System.Drawing.Point(0, 1);
			this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
			this.kryptonBorderEdge3.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.kryptonBorderEdge3.Size = new System.Drawing.Size(1, 644);
			this.kryptonBorderEdge3.StateCommon.Color1 = System.Drawing.Color.DarkGray;
			this.kryptonBorderEdge3.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.kryptonBorderEdge3.Text = "kryptonBorderEdge3";
			// 
			// kryptonBorderEdge4
			// 
			this.kryptonBorderEdge4.Dock = System.Windows.Forms.DockStyle.Right;
			this.kryptonBorderEdge4.Location = new System.Drawing.Point(812, 1);
			this.kryptonBorderEdge4.Name = "kryptonBorderEdge4";
			this.kryptonBorderEdge4.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.kryptonBorderEdge4.Size = new System.Drawing.Size(1, 644);
			this.kryptonBorderEdge4.StateCommon.Color1 = System.Drawing.Color.DarkGray;
			this.kryptonBorderEdge4.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
			this.kryptonBorderEdge4.Text = "kryptonBorderEdge4";
			// 
			// frmContainer
			// 
			this.frmContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frmContainer.Location = new System.Drawing.Point(1, 1);
			this.frmContainer.Name = "frmContainer";
			this.frmContainer.Size = new System.Drawing.Size(811, 644);
			this.frmContainer.TabIndex = 7;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(813, 646);
			this.Controls.Add(this.frmContainer);
			this.Controls.Add(this.kryptonBorderEdge4);
			this.Controls.Add(this.kryptonBorderEdge3);
			this.Controls.Add(this.kryptonBorderEdge2);
			this.Controls.Add(this.kryptonBorderEdge1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Electronic Blood Bank";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
		public System.Windows.Forms.Panel frmContainer;
	}
}

