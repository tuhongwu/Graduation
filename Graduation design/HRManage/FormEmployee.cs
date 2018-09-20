using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Model;

namespace HRManage
{
    public partial class FormEmployee : DevExpress.XtraEditors.XtraForm
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private string userID = string.Empty;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string userPwd = string.Empty;

        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }
        BLL.BllDbOpt bll = new BLL.BllDbOpt();
        private void btnModifyPassword_Click(object sender, EventArgs e)
        {
            ModifyPwd dlg = new ModifyPwd();           
            dlg.ShowDialog();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Text = BLL.UserInfo.UserID;

            InitDgvColumnEnabled();

            this.btnQuery_Click(null, null);   
            this.tctl_SelectedIndexChanged(null, null);
        }

        private void InitDgvColumnEnabled()
        {
            this.dgvCheck.AutoGenerateColumns = false;
            this.dgvContract.AutoGenerateColumns = false;
            this.dgvEmployeeInfo.AutoGenerateColumns = false;
            this.dgvInsurance.AutoGenerateColumns = false;
            this.dgvPay.AutoGenerateColumns = false;
            this.dgvRewardandPunishment.AutoGenerateColumns = false;
            this.dgvTest.AutoGenerateColumns = false;
            this.dgvTraining.AutoGenerateColumns = false;
            this.dgvWelfare.AutoGenerateColumns = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.GetEmployeeInfo("Employee", BLL.UserInfo.UserID);
            this.dgvEmployeeInfo.DataSource = dt;
        }

        private void tctl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.tctl.SelectedIndex;
            if (index < 0) return;
            string dataName = this.tctl.TabPages[index].Tag.ToString();
            DataTable dt = bll.GetEmployeeInfo(dataName, BLL.UserInfo.UserID);
            this.SetDgvDatasource(dt, index);
        }

        private void SetDgvDatasource(DataTable dt, int index)
        {
            switch (index)
            { 
                case 0:
                    this.dgvContract.DataSource = dt;
                    break;
                case 1:
                    this.dgvRewardandPunishment.DataSource = dt;
                    break;
                case 2:
                    this.dgvTraining.DataSource = dt;
                    break;
                case 3:
                    this.dgvTest.DataSource = dt;
                    break;
                case 4:
                    this.dgvCheck.DataSource = dt;
                    break;
                case 5:
                    this.dgvPay.DataSource = dt;
                    break;
                case 6:
                    this.dgvInsurance.DataSource = dt;
                    break;
                case 7:
                    this.dgvWelfare.DataSource = dt;
                    break;
                default:
                    break;
            }
        }

        bool isSwitch = false;

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            isSwitch = BLL.Assistant.ConfirmMessage("确认切换用户吗？");
            if (isSwitch)
            {
                this.Hide();
                frmLogin dlg = new frmLogin();
                dlg.ShowDialog();
                this.Close();
            }
        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSwitch) return;
            bool result = BLL.Assistant.ConfirmMessage("确认关闭吗？");
            if (!result) e.Cancel = true;
        }
    }
}
