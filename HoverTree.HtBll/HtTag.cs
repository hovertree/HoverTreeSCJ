using System.Collections.Generic;
using HoverTree.HtDALFactory;
using HoverTree.HtIDal;
using HoverTree.HtModel;

namespace HoverTree.HtBll
{
    public class HtTag
    {
        static readonly IHtTag dal = HtDbFactory.CreateHtTag();
        public static string Add(HtTagInfo tagInfo)
        {
            return dal.Add(tagInfo);
        }

        public static List<HtTagInfo> HtPageQuery(HtTagSelect select)
        {
            return dal.HtPageQuery(select);
        }
    }
}