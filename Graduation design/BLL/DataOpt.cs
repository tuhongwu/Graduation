using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CYQ.Data;
using System.Collections;

namespace BLL
{
    public partial class DataOpt
    {
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString();

        public DataTable SearchData(string tableName, string strWhere)//查询
        {
            MAction action = new MAction(tableName, connectionString);
            DataTable dt = action.Select(strWhere).ToDataTable();
            action.Close();
            return dt;
        }

        public bool InsertData(string tableName,Hashtable ht)//插入
        {
            MAction action = new MAction(tableName, connectionString);
            foreach(string str in ht.Keys)
            {
                action.Set(str, ht[str]);
            }
            bool result = action.Insert();
            action.Close();
            return result;
        }

        public bool UpdateData(string tableName,Hashtable ht,string strWhere)//更新
        {
            MAction action = new MAction(tableName, connectionString);
            foreach (string str in ht.Keys)
            {
                action.Set(str, ht[str]);
            }
            bool result = action.Update(strWhere);
            action.Close();
            return result;
        }

        public bool ExistsData(string tableName, string strWhere)
        {
            MAction action = new MAction(tableName, connectionString);
            bool result = action.Exists(strWhere);
            action.Close();
            return result;
        }

        public bool DeleteData(string tableName, string strWhere)//删除
        {
            MAction action = new MAction(tableName, connectionString);
            bool result = action.Delete(strWhere);                      
            action.Close();
            return result;
        }
    }
}
