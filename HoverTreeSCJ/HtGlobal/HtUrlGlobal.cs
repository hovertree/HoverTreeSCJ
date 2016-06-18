using HoverTree.HtModel;

namespace HoverTreeSCJ.HtGlobal
{
    class HtUrlGlobal
    {
        private static UrlInfo _editUrlInfo;

        public static UrlInfo EditUrlInfo
        {
            get
            {
                return _editUrlInfo;
            }

            set
            {
                _editUrlInfo = value;
            }
        }
    }
}