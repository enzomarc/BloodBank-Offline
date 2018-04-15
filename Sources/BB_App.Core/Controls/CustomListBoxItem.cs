using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using static BB_App.Core.Properties.Resources;

namespace BB_App.Core.Controls
{
    /// <summary>
    /// Represent an item of the CustomListBox Control
    /// </summary>
    public partial class CustomListBoxItem : UserControl, ISerializable
    {
        public CustomListBoxItem(string text)
        {
            InitializeComponent();
            Text = text;
        }

        #region Properties

        [Category("Appearance")]
        [Description("Displayed text of the item")]
        public override string Text
        {
            get { return textLabel?.Text; }
            set { textLabel.Text = value; }
        }

        [Category("Behavior")]
        [Description("Indicates whether the item is selected")]
        public bool Selected { get; set; }

        #endregion

        #region UI Methods

        private void checkBox_MouseEnter(object sender, EventArgs e) => checkBox.Image = Selected ? Checked_Checkbox_Hover : Unchecked_Checkbox_Hover;

        private void checkBox_MouseLeave(object sender, EventArgs e) => checkBox.Image = Selected ? Checked_Checkbox_Def : Unchecked_Checkbox_Def;

        private void kryptonBorderEdge1_MouseEnter(object sender, EventArgs e) =>
            BackColor = Color.FromArgb(240, 240, 240);

        private void kryptonBorderEdge1_MouseLeave(object sender, EventArgs e) => BackColor = Color.WhiteSmoke;

        private void checkBox_Click(object sender, EventArgs e) => Select();

        #endregion

        #region Methods

        public new void Select()
        {
            Selected = !Selected;
            checkBox.Image = Selected ? Checked_Checkbox_Def : Unchecked_Checkbox_Def;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
