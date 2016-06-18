/* 何问起 http://hovertree.com/hovertreescj/ */

namespace HoverTree.HtModel.Base
{
    public enum HtSortType
    {
        Asc = 1,
        Desc = 2,
        Multi = 3
    }
    public class HtSelectBase
    {
        HtSortType _sortType = HtSortType.Desc;

        /// <summary>
        /// 排序类型
        /// </summary>
        public HtSortType SortType
        {
            get
            {
                return _sortType;
            }

            set
            {
                _sortType = value;
            }
        }

        public int HtPageIndex
        {
            get
            {
                return _htPageIndex;
            }

            set
            {
                _htPageIndex = value;
            }
        }

        public int HtPageSize
        {
            get
            {
                return _htPageSize;
            }

            set
            {
                _htPageSize = value;
            }
        }

        public int HtTotalPageCount
        {
            get
            {
                return _htTotalPageCount;
            }

            set
            {
                _htTotalPageCount = value;
            }
        }

        public int HtTotalRecordCount
        {
            get
            {
                return _htTotalRecordCount;
            }

            set
            {
                _htTotalRecordCount = value;
            }
        }

        int _htPageIndex = 1;
        int _htPageSize = 20;
        int _htTotalPageCount = 0;
        int _htTotalRecordCount = 0;
    }
}
