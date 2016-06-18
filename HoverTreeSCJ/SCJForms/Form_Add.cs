using HoverTree.HtBll;
using HoverTree.HtModel;
using System;
using System.Windows.Forms;
using HoverTree.HoverTreeFrame.HtText;
using HoverTree.HoverTreeFrame.HtNet;
using System.Text;

namespace HoverTreeSCJ.SCJForms
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            UrlInfo h_info = new UrlInfo();
            h_info.HtUrl = textBox_url.Text.Trim();
            h_info.HtTitle = textBox_title.Text;
            h_info.HtULCase = checkBox_ulCase.Checked;
            h_info.HtSummary = textBox_summary.Text;

            string h_tips = HtUrl.Add(h_info);

            if (h_tips == "")
            {
                textBox_tips.Text = "添加成功！" + DateTime.Now.ToString();
                Clear();
            }
            else
            {
                textBox_tips.Text = "添加失败，" + DateTime.Now.ToString() + "。" + h_tips;
            }
        }

        void Clear()
        {
            textBox_summary.Clear();
            textBox_title.Clear();
            textBox_url.Clear();
        }

        private void button_getTitle_Click(object sender, EventArgs e)
        {
            if(textBox_url.Text.Trim()=="")
            {
                MessageBox.Show("请输入网址。");
                return;
            }

            try
            {
               string h_title= HtHtml.GetTitle(HtWeb.GetHtmlByUrl(textBox_url.Text, Encoding.Default));
                if(h_title=="")
                {
                    MessageBox.Show("获取标题为空","何问起");
                    return;
                }
                textBox_title.Text = h_title;

            }
            catch(Exception ex)
            {
                MessageBox.Show("获取失败。"+ex.ToString(),"何问起");
            }
        }
    }
}