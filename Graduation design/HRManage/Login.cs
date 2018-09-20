using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Model;
using System.Runtime.InteropServices;

namespace HRManage
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;//缓冲转动圆圈
                BLL.BllDbOpt bll = new BLL.BllDbOpt();//
                string UserID = txtUserID.Text.Trim();
                string UserPassword = txtUserPassword.Text.Trim();
                int typeIndex = this.cmbUserType.SelectedIndex;
                if (UserID != "" && UserPassword != "")
                {
                    //string strWhere = string.Format("UserID='{0}' and UserPassword='{1}' and UserType='{2}'", UserID, UserPassword, typeIndex);
                    //Model.ModelUserInfo model = new Model.ModelUserInfo();
                    DataTable dt = new DataTable();
                    dt = bll.GetUserInfo(UserID, UserPassword, typeIndex);
                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        BLL.UserInfo.UserID = UserID;
                        BLL.UserInfo.UserPassword = UserPassword;
                        if (this.cmbUserType.SelectedIndex.Equals(0))
                        {
                            FormAdmin dlg = new FormAdmin();
                            dlg.ShowDialog();
                        }
                        else
                        {
                            FormEmployee dlg = new FormEmployee();
                            dlg.ShowDialog();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
                else
                {
                    MessageBox.Show("用户名或者密码未输入！");
                }
            }
            finally { this.Cursor = Cursors.Default; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
            txtUserID.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.cmbUserType.SelectedIndex = 0;
            this.InitIDAndPwd();
        }

        private void InitIDAndPwd()
        {
            //this.txtUserID.Text = "123456";
            //this.txtUserPassword.Text = "123456";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 窗体拖动代码
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion
    }
}
