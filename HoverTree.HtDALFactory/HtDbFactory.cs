/* 何问起 http://hovertree.com/hovertreescj/ */
using HoverTree.HtIDal;
using HoverTree.HtMsSqlDal;

namespace HoverTree.HtDALFactory
{
    public class HtDbFactory
    {
        public static IHtUrl CreateHtUrl()
        {
            return new HtUrl();
        }

        public static IHtTag CreateHtTag()
        {
            return new HtTag();
        }
    }
}