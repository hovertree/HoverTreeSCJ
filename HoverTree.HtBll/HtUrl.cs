/* 何问起 http://hovertree.com/hovertreescj/ */
using HoverTree.HtDALFactory;
using HoverTree.HtIDal;
using HoverTree.HtModel;
using System.Collections.Generic;

namespace HoverTree.HtBll
{
    public class HtUrl
    {

        static readonly IHtUrl dal = HtDbFactory.CreateHtUrl();
        public static string Add(UrlInfo info)
        {
            return dal.Add(info);
        }

        public bool Exist(string url, bool ulCase)
        {
            return dal.Exist(url, ulCase);
        }

        public static List<UrlInfo> HtPageQuery(UrlSelect select)
        {
            return dal.HtPageQuery(select);
        }

        public static UrlInfo Get(int id)
        {
            return dal.Get(id);
        }

        public static string Save(UrlInfo info)
        {
            return dal.Save(info);
        }
    }
}