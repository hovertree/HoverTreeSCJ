/* 何问起 http://hovertree.com/hovertreescj/ */
using System.Collections.Generic;
using System.Windows.Forms;
using HoverTree.HtBll;
using HoverTree.HtModel;

namespace HoverTreeSCJ.SCJForms.TagForms
{
    public partial class Form_TagList : Form
    {
        public Form_TagList()
        {
            InitializeComponent();

            //listView_tags.Items.
        }

        void MyQuery(HtTagSelect select)
        {
            List<HtTagInfo> h_list = HtTag.HtPageQuery(select);
            if (listView_tags.Items.Count > 0)
                listView_tags.Items.Clear();
            ListViewItem h_item;
            foreach (HtTagInfo info in h_list)
            {
                //h_item.
                h_item = new ListViewItem();
                listView_tags.Items.Add(info.HtTagName);
            }
            //dataGridView_htList.DataSource = h_list;
        }

        private void Form_TagList_Load(object sender, System.EventArgs e)
        {
            HtTagSelect h_select = new HtTagSelect();
            MyQuery(h_select);
        }

        private void button_freshen_Click(object sender, System.EventArgs e)
        {
            HtTagSelect h_select = new HtTagSelect();
            MyQuery(h_select);
        }
    }
}