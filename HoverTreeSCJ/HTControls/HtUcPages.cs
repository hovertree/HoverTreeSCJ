/* 何问起 http://hovertree.com/hovertreescj/ */
using System.Windows.Forms;
using HoverTree.HtModel.Base;

namespace HoverTreeSCJ.HTControls
{
    public delegate void HtPageChangeDelegate (HtSelectBase select);

    public partial class HtUcPages : UserControl
    {
        public HtUcPages()
        {
            InitializeComponent();
            _select = new HtSelectBase();
        }

        HtSelectBase _select;

        public void SetSelectBase(HtSelectBase selectBase)
        {
            _select = selectBase;
            label_pageIndex.Text = _select.HtPageIndex.ToString();
            label_pageSize.Text = _select.HtTotalPageCount.ToString();

            SetShow(selectBase);
        }

        public event HtPageChangeDelegate PageChanged;

        private void linkLabel_next_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_select.HtPageIndex < _select.HtTotalPageCount)
            {
                _select.HtPageIndex += 1;

                OnPageChanged();
            }
        }

        void SetShow(HtSelectBase select)
        {
            if (select.HtPageIndex > 1)
                linkLabel_pre.Visible = true;
            else
                linkLabel_pre.Visible = false;

            if (select.HtPageIndex < select.HtTotalPageCount)
                linkLabel_next.Visible = true;
            else
                linkLabel_next.Visible = false;
        }

        void OnPageChanged()
        {
            label_pageIndex.Text = _select.HtPageIndex.ToString();

            SetShow(_select);

            if (PageChanged != null)
                PageChanged(_select);
        }

        private void linkLabel_pre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_select.HtPageIndex > 1)
            {
                _select.HtPageIndex -= 1;
                OnPageChanged();
            }
        }
    }
}