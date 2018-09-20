using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Model;
using System.Collections;

namespace HRManage
{
    public partial class ModifyPwd : DevExpress.XtraEditors.XtraForm
    {
        public ModifyPwd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsAllowOpt()) return;
            string userID = this.txtUserID.Text;
            Hashtable ht = new Hashtable();
            ht["UserPassword"] = this.txtNewUserPassword.Text;

            BLL.BllDbOpt bll = new BLL.BllDbOpt();
            bool result = bll.UpdateUserInfo(ht, userID);
            MessageBox.Show(string.Format("修改{0}！", result ? "成功" : "失败"));   
        }

        private bool IsAllowOpt()
        {
            string strOldPwd = this.txtOldUserPassword.Text;
            if (string.IsNullOrEmpty(strOldPwd) || !strOldPwd.Equals(BLL.UserInfo.UserPassword))
            {
                MessageBox.Show("旧密码不能为空或密码错误！");
                return false;
            }
            string strNewPwd = this.txtNewUserPassword.Text;
            if (string.IsNullOrEmpty(strNewPwd) || strNewPwd.Length < 5)
            {
                MessageBox.Show("新密码不能为空且长度不低于六位！");
                return false;
            }
            else if(strOldPwd.Equals(strNewPwd))
            {
                MessageBox.Show("新旧密码一致，请重新输入！");
                return false;
            }
            return true;
        }

        private void ModifyPassword_Load(object sender, EventArgs e)
        {
            this.txtUserID.Text = BLL.UserInfo.UserID;
            this.txtOldUserPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
