using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace BLL
{
    public partial class BllDbOpt
    {
        private readonly DataOpt dal = new DataOpt();

        public bool AddUserInfo(Hashtable ht)
        {
            return dal.InsertData("UserInfo", ht);
        }

        public bool UpdateUserInfo(Hashtable ht, string userID)
        {
            string strWhere = string.Format("UserID = '{0}'", userID);
            return dal.UpdateData("UserInfo", ht, strWhere);
        }

        public bool UpdateEmployeeInfo(string tableName,Hashtable ht, string employeeID)
        {
            string strWhere = string.Format("EmployeeID = '{0}'", employeeID);
            return dal.UpdateData(tableName, ht, strWhere);
        }

        public DataTable GetEmployeeInfo(string tableName, string employeeID)
        {
            string strWhere = string.Format("EmployeeID = {0}", employeeID);
            return dal.SearchData(tableName, strWhere);
        }

        public DataTable GetUserInfo(string userID)
        {
            string strWhere = string.Format("UserID='{0}'", userID);
            return dal.SearchData("UserInfo", strWhere);
        }

        public DataTable GetUserInfo(string userID, string userPwd, int typeIndex)
        {
            string strWhere = string.Format("UserID='{0}' and UserPassword='{1}' and UserType='{2}'", userID, userPwd, typeIndex);
            return dal.SearchData("UserInfo", strWhere);
        }

        public DataTable GetEmployeeAll()
        {
            return dal.SearchData("Employee", string.Empty);
        }

        public bool AddUserDetail(string tableName, Hashtable ht)
        {
            return dal.InsertData(tableName, ht);
        }

        public bool DeleteUserInfo(string employeeID)
        {
            string[] tableNameEnums = { "EmployeePay", "EmployeeCheck", "EmployeeContract", "EmployeeQuit", "EmployeeReward", "Employee", "EmployeeInsurance", "EmployeeReinstate", "EmployeeTest", "EmployeeTitle", "EmployeeTraining", "EmployeeTransfer", "EmployeeWelfare" ,"UserInfo"};
            string strWhere = string.Format("EmployeeID ='{0}'", employeeID);
            bool result = false;
            foreach (string tableName in tableNameEnums)
            {
                result = dal.ExistsData(tableName, strWhere);
                if (result)
                {
                    result = dal.DeleteData(tableName, strWhere);
                }
            }
            return result;
        }
    }
}
