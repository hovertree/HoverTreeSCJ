using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoverTree.HtModel;

namespace HoverTree.HtIDal
{
   public interface IHtTag
    {
        string Add(HtTagInfo tagInfo);

        List<HtTagInfo> HtPageQuery(HtTagSelect select);

        HtTagInfo Get(int id);

        string Save(HtTagInfo info);
    }
}
