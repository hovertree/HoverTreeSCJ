using System;
using System.Windows.Forms;
using HoverTree.HtBll;
using HoverTree.HtModel;

namespace HoverTreeSCJ.SCJForms.TagForms
{
    public partial class Form_TagAdd : Form
    {
        public Form_TagAdd()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            HtTagInfo h_tagInfo = new HtTagInfo();
            h_tagInfo.HtTagName = textBox_tagName.Text;
           string h_result= HtTag.Add(h_tagInfo);
            if (h_result == "")
                MessageBox.Show("添加成功!");
            else
                MessageBox.Show(h_result);
        }
    }
}
