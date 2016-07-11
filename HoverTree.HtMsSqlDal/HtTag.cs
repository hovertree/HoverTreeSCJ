using System;
using System.Collections.Generic;
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
            string h_tagName = tagInfo.HtTagName.Trim();

            if (h_tagName == "")
                h_result = "标签名不能为空";

            if (h_tagName.Length > 50)
                return "标签名不能多于50个字符。";

            // CheckInfo(info);

            //if (Exist(info.HtUrl, info.HtULCase))
            //    return "url已经存在！";

            if (h_result != "")
                return h_result;

            IDataParameter[] m_parameters = new SqlParameter[1];
            m_parameters[0] = new SqlParameter("@HtTagName", SqlDbType.NVarChar, 100);
            m_parameters[0].Value = h_tagName;
            

            int m_returnCount;

            //执行结果等于1表示添加成功
            m_returnCount = KeleyiSQLHelper.HoverTreeSql.RunProcedureWithReturn("p_HoverTreeSCJ_Tag_Add", m_parameters);

            if (m_returnCount == 1)
                return string.Empty;
            else
                return "添加失败 ";
        }

        public List<HtTagInfo> HtPageQuery(HtTagSelect select)
        {
            string h_tableName = "HoverTreeSCJ_Tag";

            int h_totalCount, h_totalPageCount;

            DataTable h_dt = KeleyiSQLHelper.HoverTreeSql.HtPageQuery(h_tableName, "*", "htid", " htid>0 ", " htId desc ", (int)select.SortType, select.HtPageSize, select.HtPageIndex, 0, out h_totalCount, out h_totalPageCount);

            select.HtTotalRecordCount = h_totalCount;
            select.HtTotalPageCount = h_totalPageCount;

            return ConvertToList(h_dt);
        }

        List<HtTagInfo> ConvertToList(DataTable htTable)
        {

            if (htTable == null)
                return null;
            List<HtTagInfo> h_list = new List<HtTagInfo>();
            int m_rowCount = htTable.Rows.Count;
            if (m_rowCount == 0)
                return h_list;

            for (int i = 0; i < m_rowCount; i++)
            {
                h_list.Add(ConvertToInfo(htTable.Rows[i]));
            }

            return h_list;
        }

        HtTagInfo ConvertToInfo(DataRow htDataRow)
        {

            HtTagInfo h_info = new HtTagInfo();
            if (htDataRow == null)
                return h_info;

            h_info.HtId = Convert.ToInt32(htDataRow["htid"]);
            h_info.HtTagName = htDataRow["HtTagName"].ToString();
            h_info.HtAddTime = Convert.ToDateTime(htDataRow["HtAddTime"]);

            return h_info;
        }

        public HtTagInfo Get(int id)
        {
            IDataParameter[] m_parameters = new SqlParameter[1];
            m_parameters[0] = new SqlParameter("@htid", SqlDbType.Int, 4);
            m_parameters[0].Value = id;

            DataRow h_dr;
            h_dr = KeleyiSQLHelper.HoverTreeSql.RunProcedureDataRow("p_HoverTreeSCJ_Tag_Get", m_parameters);
            return ConvertToInfo(h_dr);
        }

        public string Save(HtTagInfo info)
        {
            IDataParameter[] m_parameters = new SqlParameter[2];
            m_parameters[0] = new SqlParameter("@htid", SqlDbType.Int, 4);
            m_parameters[0].Value = info.HtId;
            m_parameters[1] = new SqlParameter("@htTagName", SqlDbType.NVarChar, 100);
            m_parameters[1].Value = info.HtTagName.Trim();
            

            int m_returnCount;

            //执行结果等于1表示添加成功
            m_returnCount = KeleyiSQLHelper.HoverTreeSql.RunProcedureWithReturn("p_HoverTreeSCJ_Tag_Save", m_parameters);

            if (m_returnCount == 1)
                return string.Empty;
            else
                return "保存失败 ";
        }
    }
}