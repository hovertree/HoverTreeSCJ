using System;
using System.Windows.Forms;
using HoverTree.HtBll;
using HoverTree.HtModel;

namespace HoverTreeSCJ.SCJForms.TagForms
{
    public partial class Form_TagEdit : Form
    {
        int _tagId;
        public Form_TagEdit(int id)
        {
            InitializeComponent();

            _tagId = id;
            numericUpDown_id.Value = id;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(numericUpDown_id.Value.ToString());

            HtTagInfo h_info = new HtTagInfo();
            h_info.HtId = _tagId;
            h_info.HtTagName = textBox_tagName.Text;
            string h_tips = HtTag.Save(h_info);
            if (h_tips == "")
            {
                // MessageBox.Show("保存成功");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(h_tips);
            }

        }

        private void Form_TagEdit_Load(object sender, EventArgs e)
        {
            HtTagInfo h_info = HtTag.Get(Convert.ToInt32(numericUpDown_id.Value));
            textBox_tagName.Text = h_info.HtTagName;
        }
    }
}