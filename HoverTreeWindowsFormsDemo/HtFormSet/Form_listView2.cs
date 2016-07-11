/*
 http://hovertree.com/h/bjaf/m3a6g3wo.htm
 */
using System;
using System.Windows.Forms;

namespace HoverTreeWindowsFormsDemo.HtFormSet
{
    public partial class Form_listView2 : Form
    {
        public Form_listView2()
        {
            InitializeComponent();
        }

        private void Form_listView2_Load(object sender, EventArgs e)
        {
            string[] h_lviStr = { "hovertree", "何问起", "hewenqi" };
            ListViewItem h_lvi = new ListViewItem(h_lviStr);


            listView_myLV.Items.Add(h_lvi);
        }

        private void listView_myLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_myLV.SelectedItems.Count==1)
            {
                MessageBox.Show(listView_myLV.SelectedItems[0].SubItems[2].Text);
            }
        }
    }
}