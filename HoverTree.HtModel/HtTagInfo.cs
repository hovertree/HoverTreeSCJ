using System;

namespace HoverTree.HtModel
{
    public class HtTagInfo
    {
        int _htId;
        string _htTagName;
        DateTime _htAddTime;

        public int HtId
        {
            get
            {
                return _htId;
            }

            set
            {
                _htId = value;
            }
        }

        public string HtTagName
        {
            get
            {
                return _htTagName;
            }

            set
            {
                _htTagName = value;
            }
        }

        public DateTime HtAddTime
        {
            get
            {
                return _htAddTime;
            }

            set
            {
                _htAddTime = value;
            }
        }
    }
}