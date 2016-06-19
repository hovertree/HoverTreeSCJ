/* 何问起 http://hovertree.com/hovertreescj/ */
using HoverTreeSCJ.SCJForms;
using System;
using System.Windows.Forms;
using HoverTreeSCJ.SCJForms.TagForms;
using HoverTreeSCJ.SCJForms.ToolForms;

namespace HoverTreeSCJ
{
    public partial class HoverTreeSCJForm : Form
    {
        public HoverTreeSCJForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add h_form = new Form_Add();
            h_form.MdiParent = this;
            h_form.WindowState = FormWindowState.Maximized;
            h_form.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HtList h_form = new Form_HtList();
            h_form.MdiParent = this;
            h_form.WindowState = FormWindowState.Maximized;
            h_form.Show();
        }

        private void tagAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TagAdd h_form = new Form_TagAdd();
            h_form.MdiParent = this;
            h_form.Show();
        }

        private void getScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GetScreen h_from = new Form_GetScreen();
            h_from.MdiParent = this;
            h_from.Show();
        }
    }
}
