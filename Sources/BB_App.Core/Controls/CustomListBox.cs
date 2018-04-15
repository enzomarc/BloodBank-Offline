using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB_App.Core.Controls
{
    public partial class CustomListBox : UserControl
    {
        private List<CustomListBoxItem> _items;

        public CustomListBox()
        {
            InitializeComponent();
            _items = new List<CustomListBoxItem>();
        }

        #region Properties

        [Category("Data")]
        [Description("List of items in the listbox control")]
        public List<CustomListBoxItem> Items
        {
            get { return _items; }
        }

        [Category("Behavior")]
        [Description("Determines whether the listbox can support items multiselection")]
        [DefaultValue(false)]
        public bool MultiSelect { get; set; }

        #endregion

        #region Methods

        public void Add(CustomListBoxItem item)
        {
            item.checkBox.Visible = MultiSelect;
            item.Dock = DockStyle.Top;
            Items.Add(item);
            ItemsContainer.Controls.Add(item);
        }

        public void Clear()
        {
            Items.Clear();
            ItemsContainer.Controls.Clear();
        }

        #endregion

        private void CustomListBox_Load(object sender, EventArgs e)
        {
            
        }

        private void Item_Click(object sender, EventArgs e)
        {
            var text = ((Control) sender).Name.Contains("Label")
                ? ((Control) sender).Text
                : ((CustomListBoxItem) sender).textLabel.Text;
        }
    }
}
