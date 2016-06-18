using System.Data;
using System.Data.SqlClient;
using HoverTree.DBTools;
using HoverTree.HtIDal;
using HoverTree.HtModel;

namespace HoverTree.HtMsSqlDal
{
    public class HtTag : IHtTag
    {
        public string Add(HtTagInfo tagInfo)
        {

            string h_result = "";

            if (tagInfo.HtTagName.Trim() == "")
                h_result = "标签名不能为空";
            // CheckInfo(info);

            //if (Exist(info.HtUrl, info.HtULCase))
            //    return "url已经存在！";

            if (h_result != "")
                return h_result;

            IDataParameter[] m_parameters = new SqlParameter[1];
            m_parameters[0] = new SqlParameter("@HtTagName", SqlDbType.NVarChar, 100);
            m_parameters[0].Value = tagInfo.HtTagName.Trim();
            

            int m_returnCount;

            //执行结果等于1表示添加成功
            m_returnCount = KeleyiSQLHelper.HoverTreeSql.RunProcedureWithReturn("p_HoverTreeSCJ_Tag_Add", m_parameters);

            if (m_returnCount == 1)
                return string.Empty;
            else
                return "添加失败 ";
        }
    }
}