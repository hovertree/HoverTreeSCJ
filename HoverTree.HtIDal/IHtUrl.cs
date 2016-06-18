/* 何问起 http://hovertree.com/hovertreescj/ */
using HoverTree.HtModel;
using System.Collections.Generic;

namespace HoverTree.HtIDal
{
    public interface IHtUrl
    {
        string Add(UrlInfo info);

        /// <summary>
        /// url是否已经存在
        /// </summary>
        /// <param name="url"></param>
        /// <param name="ulCase">url是否区分大小写</param>
        /// <returns></returns>
        bool Exist(string url,bool ulCase);

        List<UrlInfo> HtPageQuery(UrlSelect select);

        UrlInfo Get(int id);

        string Save(UrlInfo info);
    }
}