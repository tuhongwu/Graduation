using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HRManage
{
    public partial class FromUserAdd : DevExpress.XtraEditors.XtraForm
    {
        public FromUserAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsAllowOpt()) return;
            BLL.BllDbOpt bll = new BLL.BllDbOpt();
            DataTable dt = bll.GetUserInfo(this.txtUserID.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("账号已存在！");
                return;
            }
            
            Hashtable ht = this.SetUserInfo();
            bool result = bll.AddUserInfo(ht);
            MessageBox.Show(string.Format("数据添加{0}", result ? "成功" : "失败"));
        }

        private Hashtable SetUserInfo()
        {
            Hashtable ht = new Hashtable();

            ht["UserID"] = this.txtUserID.Text;
            ht["UserPassword"] = this.txtUserPassword.Text;
            ht["UserType"] = this.cmbUserType.SelectedItem.ToString();

            return ht;
        }

        private bool IsAllowOpt()
        {
            if (this.txtUserID.Text.Trim().Length == 0)
            {
                BLL.Assistant.DisplayInfoUseTooltip(txtUserID, "用户名不能为空！", 1000);
                return false;
            }
            if (this.txtUserPassword.Text.Trim().Length < 6)
            {
                BLL.Assistant.DisplayInfoUseTooltip(txtUserPassword, "密码不能为空或长度不能小于六位！", 1000);
                return false;
            }
            if (!this.txtUserPassword.Text.Trim().Equals(this.txtsurepwd.Text.Trim()))
            {
                BLL.Assistant.DisplayInfoUseTooltip(txtsurepwd, "前后密码不符，请检查是否一致！", 1000);
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
            txtsurepwd.Text = string.Empty;
            txtUserID.Focus();
        }

        private void FromUserAdd_Load(object sender, EventArgs e)
        {
            this.cmbUserType.SelectedIndex = 0;
        }    
    }
}
