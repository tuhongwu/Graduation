using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserInfo
    {
        private static string _UserID;
        private static string _userpassword;
        private string _usertype;

        public static string UserID
        {
            set { _UserID = value; }
            get { return _UserID; }
        }
        public static string UserPassword
        {
            set { _userpassword = value; }
            get { return _userpassword; }
        }
        public string UserType
        {
            set { _usertype = value; }
            get { return _usertype; }
        }
    }
}
