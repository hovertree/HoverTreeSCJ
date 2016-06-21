/* 何问起 http://hovertree.com/hovertreescj/ */
using System;
using System.Windows.Forms;
using HoverTreeWindowsFormsDemo.HtFormSet;

namespace HoverTreeWindowsFormsDemo
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_listView_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_hovertree.Hide();

            Form_ListView h_form = new Form_ListView();
            h_form.MdiParent = this;

            h_form.Show();

            h_form.BringToFront();
        }

        private void showControlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_hovertree.Show();
        }

        private void button_hideControlPanel_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_hovertree.Hide();
        }
    }
}