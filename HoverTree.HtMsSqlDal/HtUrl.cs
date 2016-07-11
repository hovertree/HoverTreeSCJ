/* 何问起 http://hovertree.com/hovertreescj/ */
using HoverTree.HtIDal;
using HoverTree.HtModel;
using System.Data;
using System.Data.SqlClient;
using HoverTree.DBTools;
using System;
using System.Collections.Generic;

namespace HoverTree.HtMsSqlDal
{
    public class HtUrl : IHtUrl
    {
        public string Add(UrlInfo info)
        {
            string h_result = CheckInfo(info);

            if (Exist(info.HtUrl, info.HtULCase))
                return "url已经存在！";

            if (h_result != "")
                return h_result;

            IDataParameter[] m_parameters = new SqlParameter[4];
            m_parameters[0] = new SqlParameter("@htUrl", SqlDbType.NVarChar, 2000);
            m_parameters[0].Value = info.HtUrl.Trim();
            m_parameters[1] = new SqlParameter("@htTitle", SqlDbType.NVarChar, 200);
            m_parameters[1].Value = info.HtTitle;
            m_parameters[2] = new SqlParameter("@htSumary", SqlDbType.NVarChar, 1000);
            m_parameters[2].Value = info.HtSummary;
            m_parameters[3] = new SqlParameter("@HtULCase", SqlDbType.Bit);
            m_parameters[3].Value = info.HtULCase;

            int m_returnCount;

            //执行结果等于1表示添加成功
            m_returnCount = KeleyiSQLHelper.HoverTreeSql.RunProcedureWithReturn("p_HoverTreeSCJ_URLs_Add", m_parameters);

            if (m_returnCount == 1)
                return string.Empty;
            else
                return "添加失败 ";
        }

        public bool Exist(string url, bool ulCase)
        {
            if (url.Trim() == "")
                return false;

            IDataParameter[] m_parameters = new SqlParameter[2];
            m_parameters[0] = new SqlParameter("@htUrl", SqlDbType.NVarChar, 2000);
            m_parameters[0].Value = url.Trim();

            m_parameters[1] = new SqlParameter("@htULCase", SqlDbType.Bit);
            m_parameters[1].Value = ulCase;

            int m_returnCount;

            //执行结果等于1表示存在
            m_returnCount = KeleyiSQLHelper.HoverTreeSql.RunProcedureWithReturn("p_HoverTreeSCJ_URLs_Exist", m_parameters);

            if (m_returnCount == 1)
                return true;
            else
                return false;
        }

        public List<UrlInfo> HtPageQuery(UrlSelect select)
        {
            string h_tableName = "HoverTreeSCJ_Urls";

            int h_totalCount, h_totalPageCount;

            DataTable h_dt = KeleyiSQLHelper.HoverTreeSql.HtPageQuery(h_tableName, "*", "htid", " htid>0 ", " htId desc ", (int)select.SortType, select.HtPageSize, select.HtPageIndex, 0, out h_totalCount, out h_totalPageCount);

            select.HtTotalRecordCount = h_totalCount;
            select.HtTotalPageCount = h_totalPageCount;

            return ConvertToList(h_dt);

        }

        List<UrlInfo> ConvertToList(DataTable htTable)
        {

            if (htTable == null)
                return null;
            List<UrlInfo> h_list = new List<UrlInfo>();
            int m_rowCount = htTable.Rows.Count;
            if (m_rowCount == 0)
                return h_list;

            for (int i = 0; i < m_rowCount; i++)
            {
                h_list.Add(ConvertToInfo(htTable.Rows[i]));
            }

            return h_list;
        }

        UrlInfo ConvertToInfo(DataRow htDataRow)
        {

            UrlInfo h_info = new UrlInfo();
            if (htDataRow == null)
                return h_info;

            h_info.HtId = Convert.ToInt32(htDataRow["htid"]);
            h_info.HtUrl = htDataRow["HtUrl"].ToString();
            h_info.HtTitle = htDataRow["HtTitle"].ToString();
            h_info.HtAddTime = Convert.ToDateTime(htDataRow["HtAddTime"]);
            h_info.HtSummary = htDataRow["HtSummary"].ToString();
            h_info.HtULCase = Convert.ToBoolean(htDataRow["HtULCase"]);

            return h_info;
        }

        string CheckInfo(UrlInfo info)
        {
            if (info.HtUrl.Trim() == "")
                return "网址不能为空。";

            if (info.HtUrl.Trim().Length > 2000)
                return "网址长度超出范围。";

            if (info.HtTitle.Length > 200)
                return "标题长度超出范围。";

            return "";
        }

        public UrlInfo Get(int id)
        {
            IDataParameter[] m_parameters = new SqlParameter[1];
            m_parameters[0] = new SqlParameter("@htid", SqlDbType.Int, 4);
            m_parameters[0].Value = id;

            DataRow h_dr;
            h_dr = KeleyiSQLHelper.HoverTreeSql.RunProcedureDataRow("p_HoverTreeSCJ_URLs_Get", m_parameters);
            return ConvertToInfo(h_dr);
        }

        public string Save(UrlInfo info)
        {
            IDataParameter[] m_parameters = new SqlParameter[5];
            m_parameters[0] = new SqlParameter("@htid", SqlDbType.Int, 4);
            m_parameters[0].Value = info.HtId;
            m_parameters[1] = new SqlParameter("@htUrl", SqlDbType.NVarChar, 2000);
            m_parameters[1].Value = info.HtUrl.Trim();
            m_parameters[2] = new SqlParameter("@htTitle", SqlDbType.NVarChar, 200);
            m_parameters[2].Value = info.HtTitle;
            m_parameters[3] = new SqlParameter("@htSumary", SqlDbType.NVarChar, 1000);
            m_parameters[3].Value = info.HtSummary;
            m_parameters[4] = new SqlParameter("@HtULCase", SqlDbType.NVarChar, 1000);
            m_parameters[4].Value = info.HtULCase;

            int m_returnCount;

            //执行结果等于1表示添加成功
            m_returnCount = KeleyiSQLHelper.HoverTreeSql.RunProcedureWithReturn("p_HoverTreeSCJ_URLs_Save", m_parameters);

            if (m_returnCount == 1)
                return string.Empty;
            else
                return "保存失败 ";
        }
    }
}