/* 何问起 http://hovertree.com/hovertreescj/ */
using HoverTree.HtBll;
using HoverTree.HtModel;
using HoverTree.HtModel.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace HoverTreeSCJ.SCJForms
{
    public partial class Form_HtList : Form
    {
        public Form_HtList()
        {
            InitializeComponent();
            htUcPages1.PageChanged += HtUcPages1_PageChanged;
        }

        private void HtUcPages1_PageChanged(HtSelectBase select)
        {

            UrlSelect h_urlSelect = new UrlSelect();
            h_urlSelect.HtPageSize = select.HtPageSize;
            h_urlSelect.HtPageIndex = select.HtPageIndex;
            h_urlSelect.HtTotalPageCount = select.HtTotalPageCount;
            h_urlSelect.HtTotalRecordCount = select.HtTotalRecordCount;
            h_urlSelect.SortType = select.SortType;

            MyQuery(h_urlSelect);
        }

        private void button_htQuery_Click(object sender, EventArgs e)
        {
            InitQuery();
        }

        void InitQuery()
        {
            UrlSelect h_select = new UrlSelect();
            h_select.SortType = HtSortType.Desc;
            h_select.HtPageSize =5;//作为示例，暂定每页5个记录。在后续的版本中将会改进。
            h_select.HtPageIndex = 1;

            MyQuery(h_select);

            htUcPages1.SetSelectBase(h_select);
        }

        void MyQuery(UrlSelect select)
        {
            List<UrlInfo> h_list = HtUrl.HtPageQuery(select);
            dataGridView_htList.DataSource = h_list;
        }

        private void Form_HtList_Load(object sender, EventArgs e)
        {
            // InitQuery();
        }

        private void dataGridView_htList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                try
                {
                    Process.Start(dataGridView_htList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("无法打开，请确认网址的正确性。");
                }
            }
        }

        private void dataGridView_htList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                int h_urlId = Convert.ToInt32(dataGridView_htList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (h_urlId < 1)
                {
                    return;
                }

                Form_Edit h_form = new Form_Edit(h_urlId);
                if (h_form.ShowDialog() == DialogResult.OK)
                {
                    dataGridView_htList.CurrentRow.Cells["HtUrlColumn"].Value = HtGlobal.HtUrlGlobal.EditUrlInfo.HtUrl;
                    dataGridView_htList.CurrentRow.Cells["HtTitle"].Value = HtGlobal.HtUrlGlobal.EditUrlInfo.HtTitle;
                    dataGridView_htList.CurrentRow.Cells["HtSummary"].Value = HtGlobal.HtUrlGlobal.EditUrlInfo.HtSummary;
                    dataGridView_htList.CurrentRow.Cells["HtULCase"].Value = HtGlobal.HtUrlGlobal.EditUrlInfo.HtULCase;

                }
            }
        }
    }
}