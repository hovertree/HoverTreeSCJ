/*
 http://hovertree.com/hovertreescj/
本示例展示如何使用ListView分组显示数据。
h : hovertree
 */
using System;
using System.Collections;
using System.Windows.Forms;

namespace HoverTreeWindowsFormsDemo.HtFormSet
{
    public partial class Form_ListView : Form
    {
        public Form_ListView()
        {
            InitializeComponent();
        }

        // Determine whether Windows XP or a later
        // operating system is present.
        private bool _isRunningXPOrLater =
            OSFeature.Feature.IsPresent(OSFeature.Themes);

        // Declare a Hashtable array in which to store the groups.
        private Hashtable[] _groupTables;

        // Declare a variable to store the current grouping column.
        int _groupColumn = 0;

        private void Form_ListView_Load(object sender, EventArgs e)
        {

            ColumnHeader h_columnHeader0 = new ColumnHeader();
            h_columnHeader0.Text = "Title";
            // columnHeader0.Width = -1;
            h_columnHeader0.Width = 200;
            ColumnHeader h_columnHeader1 = new ColumnHeader();
            h_columnHeader1.Text = "Info";
            //columnHeader1.Width = -1;
            h_columnHeader1.Width = 150;

            ColumnHeader h_columnHeader2 = new ColumnHeader();
            h_columnHeader2.Text = "Year";
            // columnHeader2.Width = -1;
            h_columnHeader2.Width = 100;
            // Add the column headers to listView_HoverTree.
            listView_HoverTree.Columns.AddRange(new ColumnHeader[]
                {h_columnHeader0, h_columnHeader1, h_columnHeader2});

            // Add a handler for the ColumnClick event.
            listView_HoverTree.ColumnClick +=
                new ColumnClickEventHandler(listView_HoverTree_ColumnClick);

            // Create items and add them to listView_HoverTree.
            ListViewItem item0 = new ListViewItem(new string[]
                {"HoverTreeSCJ",
            "Hewenqi",
            "2016"});
            ListViewItem item1 = new ListViewItem(new string[]
                {"Keleyi: jQuery and HTML5",
            "柯乐义",
            "2012"});
            ListViewItem item2 = new ListViewItem(new string[]
                {"hwq2.com",
            "A Good Site",
            "2015"});
            ListViewItem item3 = new ListViewItem(new string[]
                {"何问起收藏夹",
            "HT",
            "2012"});
            ListViewItem item4 = new ListViewItem(new string[]
                {"HoverClock",
            "HTML5 Clock",
            "2016"});
            ListViewItem item5 = new ListViewItem(new string[]
                {"EasySector",
            "HTML5 canvas",
            "2016"});
            listView_HoverTree.Items.AddRange(
                new ListViewItem[] { item0, item1, item2, item3, item4, item5 });

            if (_isRunningXPOrLater)
            {
                // Create the groupsTable array and populate it with one 
                // hash table for each column.
                _groupTables = new Hashtable[listView_HoverTree.Columns.Count];
                for (int column = 0; column < listView_HoverTree.Columns.Count; column++)
                {
                    // Create a hash table containing all the groups 
                    // needed for a single column.
                    _groupTables[column] = CreateGroupsTable(column);
                    //groupTables[column]
                }

                // Start with the groups created for the Title column.
                SetGroups(0);
            }

            // Initialize the form.
            this.Controls.Add(listView_HoverTree);
            this.Size = new System.Drawing.Size(550, 330);
            this.Text = "ListView Groups Example_何问起";
        }

        // Groups the items using the groups created for the clicked 
        // column.
        private void listView_HoverTree_ColumnClick(
            object sender, ColumnClickEventArgs e)
        {
            // Set the sort order to ascending when changing
            // column groups; otherwise, reverse the sort order.
            if (listView_HoverTree.Sorting == SortOrder.Descending ||
                (_isRunningXPOrLater && (e.Column != _groupColumn)))
            {
                listView_HoverTree.Sorting = SortOrder.Ascending;
            }
            else
            {
                listView_HoverTree.Sorting = SortOrder.Descending;
            }
            _groupColumn = e.Column;

            // Set the groups to those created for the clicked column.
            if (_isRunningXPOrLater)
            {
                SetGroups(e.Column);
            }
        }

        // Sets listView_HoverTree to the groups created for the specified column.
        private void SetGroups(int column)
        {
            // Remove the current groups.
            listView_HoverTree.Groups.Clear();

            // Retrieve the hash table corresponding to the column.
            Hashtable groups = (Hashtable)_groupTables[column];

            // Copy the groups for the column to an array.
            ListViewGroup[] h_groupsArray = new ListViewGroup[groups.Count];
            groups.Values.CopyTo(h_groupsArray, 0);

            // Sort the groups and add them to listView_HoverTree.
            Array.Sort(h_groupsArray, new ListViewGroupSorter(listView_HoverTree.Sorting));
            listView_HoverTree.Groups.AddRange(h_groupsArray);

            // Iterate through the items in listView_HoverTree, assigning each 
            // one to the appropriate group.
            foreach (ListViewItem item in listView_HoverTree.Items)
            {
                // Retrieve the subitem text corresponding to the column.
                string h_subItemText = item.SubItems[column].Text;

                // For the Title column, use only the first letter.
                if (column == 0)
                {
                    h_subItemText = h_subItemText.Substring(0, 1);
                }

                // Assign the item to the matching group.
                item.Group = (ListViewGroup)groups[h_subItemText];
            }
        }

        // Creates a Hashtable object with one entry for each unique
        // subitem value (or initial letter for the parent item)
        // in the specified column.
        private Hashtable CreateGroupsTable(int column)
        {
            // Create a Hashtable object.
            Hashtable h_groups = new Hashtable();

            // Iterate through the items in listView_HoverTree.
            foreach (ListViewItem item in listView_HoverTree.Items)
            {
                // Retrieve the text value for the column.
                string h_subItemText = item.SubItems[column].Text;

                // Use the initial letter instead if it is the first column.
                if (column == 0)
                {
                    h_subItemText = h_subItemText.Substring(0, 1);
                }

                // If the groups table does not already contain a group
                // for the subItemText value, add a new group using the 
                // subItemText value for the group header and Hashtable key.
                if (!h_groups.Contains(h_subItemText))
                {
                    h_groups.Add(h_subItemText, new ListViewGroup(h_subItemText,
                        HorizontalAlignment.Left));
                }
            }

            // Return the Hashtable object.
            return h_groups;
        }

        // Sorts ListViewGroup objects by header value.
        private class ListViewGroupSorter : IComparer
        {
            private SortOrder h_order;

            // Stores the sort order.
            public ListViewGroupSorter(SortOrder theOrder)
            {
                h_order = theOrder;
            }

            // Compares the groups by header value, using the saved sort
            // order to return the correct value.
            public int Compare(object x, object y)
            {
                int result = String.Compare(
                    ((ListViewGroup)x).Header,
                    ((ListViewGroup)y).Header
                );
                if (h_order == SortOrder.Ascending)
                {
                    return result;
                }
                else
                {
                    return -result;
                }
            }
        }

    }
}