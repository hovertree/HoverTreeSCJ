/* 何问起 http://hovertree.com/hovertreescj/ */
using System.Collections.Generic;
using System.Windows.Forms;
using HoverTree.HtBll;
using HoverTree.HtModel;
using System;

namespace HoverTreeSCJ.SCJForms.TagForms
{
    public partial class Form_TagList : Form
    {
        public Form_TagList()
        {
            InitializeComponent();
            listView_tags.View = View.Details;
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
                string[] h_subItems = { info.HtTagName, info.HtId.ToString(), info.HtAddTime.ToString() };
                h_item = new ListViewItem(h_subItems);
                listView_tags.Items.Add(h_item);
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

        private void listView_tags_ItemActivate(object sender, System.EventArgs e)
        {

            //ListViewItem h_item = (ListViewItem)sender;
            //MessageBox.Show(h_item.Text);
            if (listView_tags.SelectedItems.Count == 1)
            {
                //MessageBox.Show(listView_tags.SelectedItems[0].SubItems[1].Text);
                Form_TagEdit h_editForm = new Form_TagEdit(Convert.ToInt32(listView_tags.SelectedItems[0].SubItems[1].Text));
                //h_editForm.MdiParent = this.MdiParent;
                if (h_editForm.ShowDialog() == DialogResult.OK)
                {
                    HtTagInfo h_tempInfo = HtTag.Get(Convert.ToInt32(listView_tags.SelectedItems[0].SubItems[1].Text));
                    listView_tags.SelectedItems[0].Text = h_tempInfo.HtTagName;

                }
            }
        }
    }
}