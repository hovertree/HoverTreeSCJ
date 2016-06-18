/* 何问起 http://hovertree.com/hovertreescj/ */
using System;

namespace HoverTree.HtModel
{
    /// <summary>
    /// Url信息类 
    /// by 何问起
    /// </summary>
    public class UrlInfo
    {
        int _htId;
        /// <summary>
        /// ID
        /// </summary>
        public int HtId
        {
            get { return _htId; }
            set { _htId = value; }
        }

        public string HtUrl
        {
            get
            {
                return _htUrl;
            }

            set
            {
                _htUrl = value;
            }
        }
        

        public string HtTitle
        {
            get
            {
                return _htTitle;
            }

            set
            {
                _htTitle = value;
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

        public bool HtULCase
        {
            get
            {
                return _htULCase;
            }

            set
            {
                _htULCase = value;
            }
        }

        public string HtSummary
        {
            get
            {
                return _htSummary;
            }

            set
            {
                _htSummary = value;
            }
        }

        string _htUrl;
        string _htSummary;
        DateTime _htAddTime;
        string _htTitle;
        bool _htULCase=false;
    }
}