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
            set { _items = value; }
        }

        #endregion

        #region Methods

        public void Add(CustomListBoxItem item)
        {
            item.Dock = DockStyle.Top;
            Items.Add(item);
            ItemsContainer.Controls.Add(item);
        }

        #endregion

        private void CustomListBox_Load(object sender, EventArgs e)
        {
            Add(new CustomListBoxItem("FF"));
        }
    }
}
