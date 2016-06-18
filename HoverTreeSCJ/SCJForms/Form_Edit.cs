/* 何问起 http://hovertree.com/hovertreescj/ */
using System.Windows.Forms;
using HoverTree.HtBll;
using HoverTree.HtModel;
using System;

namespace HoverTreeSCJ.SCJForms
{
    public partial class Form_Edit : Form
    {
        public Form_Edit(int id)
        {
            InitializeComponent();

            SetUrlId(id);
        }

        UrlInfo _info;

        void SetUrlId(int id)
        {
            textBox_id.Text = id.ToString();

            _info = HtUrl.Get(id);

            textBox_url.Text = _info.HtUrl;
            textBox_title.Text = _info.HtTitle;
            textBox_summary.Text = _info.HtSummary;
            checkBox_ulCase.Checked = _info.HtULCase;
        }

        private void button_edit_Click(object sender, System.EventArgs e)
        {

            _info.HtUrl = textBox_url.Text.Trim();
            _info.HtTitle = textBox_title.Text;
            _info.HtSummary = textBox_summary.Text;
            _info.HtULCase = checkBox_ulCase.Checked;


            string h_tips = HtUrl.Save(_info);

            if (h_tips == "")
            {
                HtGlobal.HtUrlGlobal.EditUrlInfo = _info;
                Close();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(h_tips);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}