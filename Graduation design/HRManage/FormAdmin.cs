using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRManage
{
    public partial class FormAdmin : DevExpress.XtraEditors.XtraForm
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private string userID = string.Empty;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private void pnlAdd_Click(object sender, EventArgs e)
        {
            FromUserAdd dlg = new FromUserAdd();
            dlg.ShowDialog();
        }
        private void pnlAddInfo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            InfoAdd dlg = new InfoAdd();
            dlg.IsUpdate = false;
            dlg.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        bool isSwitch = false;

        private void pnlQuit_Click(object sender, EventArgs e)
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

        BLL.BllDbOpt bll = new BLL.BllDbOpt();

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.InitDgvAutoColumn();
            this.tvDepartment.ExpandAll();
            this.dgvAdminEmployeeInfo.MultiSelect = false;
            this.GetSearchData();
            tctl_SelectedIndexChanged(null, null);
        }

        private void GetSearchData()
        {
            dtEmployeeInfo = bll.GetEmployeeAll();
            DataView dv = new DataView(dtEmployeeInfo);
            dv.Sort= "EmployeeID ASC";
            dtEmployeeInfo = dv.ToTable();
            this.dgvAdminEmployeeInfo.DataSource = dtEmployeeInfo;
        }

        private void InitDgvAutoColumn()
        {
            this.dgvAdminEmployeeInfo.AutoGenerateColumns = false;//初始化表格，不让其自增列
            this.dgvCheck.AutoGenerateColumns = false;
            this.dgvContract.AutoGenerateColumns = false;
            this.dgvInsurance.AutoGenerateColumns = false;
            this.dgvPay.AutoGenerateColumns = false;
            this.dgvQuit.AutoGenerateColumns = false;
            this.dgvReinstatement.AutoGenerateColumns = false;
            this.dgvRewardandPunishment.AutoGenerateColumns = false;
            this.dgvTest.AutoGenerateColumns = false;
            this.dgvTitle.AutoGenerateColumns = false;
            this.dgvTrainingCourse.AutoGenerateColumns = false;
            this.dgvTrainingDepartment.AutoGenerateColumns = false;
            this.dgvTrainingRecord.AutoGenerateColumns = false;
            this.dgvTransfer.AutoGenerateColumns = false;
            this.dgvWelfare.AutoGenerateColumns = false;
        }

        private void ClearDgvAutoColumn()
        {
            this.dgvCheck.DataSource = null;
            this.dgvContract.DataSource = null;
            this.dgvInsurance.DataSource = null;
            this.dgvPay.DataSource = null;
            this.dgvQuit.DataSource = null;
            this.dgvReinstatement.DataSource = null;
            this.dgvRewardandPunishment.DataSource = null;
            this.dgvTest.DataSource = null;
            this.dgvTitle.DataSource = null;
            this.dgvTrainingCourse.DataSource = null;
            this.dgvTrainingDepartment.DataSource = null;
            this.dgvTrainingRecord.DataSource = null;
            this.dgvTransfer.DataSource = null;
            this.dgvWelfare.DataSource = null;
        }

        private DataTable dtEmployeeInfo = null;

        private void tctl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvAdminEmployeeInfo.CurrentRow == null) return;
            
            int index = this.tctl.SelectedIndex;
            if (index < 0) return;

            string dataName = this.tctl.TabPages[index].Tag.ToString();
            string employeeID = this.dgvAdminEmployeeInfo.CurrentRow.Cells["EmployeeID"].Value.ToString();
            DataTable dt = bll.GetEmployeeInfo(dataName, employeeID);
            this.SetDgvDatasource(dt, index);

            currrentIndex = this.dgvAdminEmployeeInfo.CurrentRow.Index;
        }

        private void SetDgvDatasource(DataTable dt, int index)
        {
            switch (index)
            {
                case 0:
                    this.dgvTransfer.DataSource = dt;
                    break;
                case 1:
                    this.dgvTitle.DataSource = dt;
                    break;
                case 2:
                    this.dgvQuit.DataSource = dt;
                    break;
                case 3:
                    this.dgvReinstatement.DataSource = dt;
                    break;
                case 4:
                    this.dgvContract.DataSource = dt;
                    break;
                case 5:
                    this.dgvRewardandPunishment.DataSource = dt;
                    break;
                case 6:
                    this.dgvTest.DataSource = dt;
                    break;
                case 7:
                    this.dgvCheck.DataSource = dt;
                    break;
                case 8:
                    this.dgvPay.DataSource = dt;
                    break;
                case 9:
                    this.dgvInsurance.DataSource = dt;
                    break;
                case 10:
                    this.dgvWelfare.DataSource = dt;
                    break;
                default:
                    this.dgvTrainingDepartment.DataSource = dgvTrainingCourse.DataSource = dgvTrainingRecord.DataSource = dt;
                    break;
            }
        }

        private void dgvAdminEmployeeInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdminEmployeeInfo.CurrentRow == null) return;
            if (dgvAdminEmployeeInfo.CurrentRow.Index.Equals(currrentIndex)) return;

            //this.dgvAdminEmployeeInfo.CurrentCell = dgvAdminEmployeeInfo.Rows[currrentIndex].Cells[0];
            tctl_SelectedIndexChanged(null, null);
        }

        private void tvDepartment_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)//TreeView切换
        {
            if (this.tvDepartment.SelectedNode == null) return;
            string nodeText = this.tvDepartment.SelectedNode.Text.ToString();
            if (nodeText.Equals("公司部门"))
            {
                this.dgvAdminEmployeeInfo.DataSource = dtEmployeeInfo;
            }
            else
            {
                DataView dv = new DataView(dtEmployeeInfo);
                dv.RowFilter = string.Format("CurrentDepartment = '{0}'", nodeText);
                DataTable dt = dv.ToTable();
                this.dgvAdminEmployeeInfo.DataSource = dt;
                if (BLL.Assistant.IsDtNull(dt)) return;
                this.tctl_SelectedIndexChanged(null, null);            }
        }

        private void tvDepartment_MouseDown(object sender, MouseEventArgs e)
        {
            if ((sender as TreeView) != null)
            {
                tvDepartment.SelectedNode = tvDepartment.GetNodeAt(e.X, e.Y);
            }
        }

        private void pnlDel_Click(object sender, EventArgs e)
        {
            if (dgvAdminEmployeeInfo.CurrentRow == null) return;
            int index = this.dgvAdminEmployeeInfo.CurrentRow.Index;
            string employeeID = this.dgvAdminEmployeeInfo.Rows[index].Cells["EmployeeID"].Value.ToString();
            string message = string.Format("您确定要删除工号为【{0}】的用户信息吗，与其相关的表格数据也将会删除，请确认操作！", employeeID);
            bool result = BLL.Assistant.ConfirmMessage(message);
            if (!result) return;
            if (true)
            {
                DataRowView drv = dgvAdminEmployeeInfo.SelectedRows[0].DataBoundItem as DataRowView;
                drv.Row.Delete();
                int count = this.dgvAdminEmployeeInfo.Rows.Count;
                if (index.Equals(count) && count > 0)
                {
                    this.dgvAdminEmployeeInfo.CurrentCell = dgvAdminEmployeeInfo.Rows[index - 1].Cells[0];
                }
            }
            BLL.Assistant.ShowMessage(string.Format("删除{0}！", result ? "成功" : "失败"));
        }

        private void pnlModify_Click(object sender, EventArgs e)
        {
            dgvAdminEmployeeInfo_CellDoubleClick(null, null);
        }

        private int currrentIndex = -1;

        private void dgvAdminEmployeeInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdminEmployeeInfo.CurrentRow == null) return;
            this.Cursor = Cursors.WaitCursor;
            currrentIndex = this.dgvAdminEmployeeInfo.CurrentRow.Index;
            string employeeID = this.dgvAdminEmployeeInfo.Rows[currrentIndex].Cells["EmployeeID"].Value.ToString();
            InfoAdd dlg = new InfoAdd();

            dlg.ProjectCnt = this.dgvAdminEmployeeInfo.Rows.Count;
            dlg.ProjectRowHandle = currrentIndex;
            dlg.OnSwitchProject += new InfoAdd.SwitchProjectHandler(dlg_OnSwitchProject);

            dlg.EmployeeID = employeeID;
            dlg.IsUpdate = true;
            dlg.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private string dlg_OnSwitchProject(int projIndex)
        {
            if (this.dgvAdminEmployeeInfo.DataSource == null) return null;
            //if (projIndex < 0) return null;
            if (projIndex >= this.dgvAdminEmployeeInfo.Rows.Count) return null;
            currrentIndex = this.dgvAdminEmployeeInfo.CurrentRow.Index;

            this.dgvAdminEmployeeInfo.CurrentCell = dgvAdminEmployeeInfo.Rows[projIndex].Cells[0];
            this.tctl_SelectedIndexChanged(null, null);
            string employeeID = this.dgvAdminEmployeeInfo.CurrentRow.Cells["EmployeeID"].Value.ToString();
            return employeeID;
        }

        private void pnlExport_Click(object sender, EventArgs e)
        {
            BLL.Template tp = new BLL.Template();
            tp.DataToExcel(dgvAdminEmployeeInfo);
        }

        private void dgvAdminEmployeeInfo_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgvAdminEmployeeInfo.Rows.Count > 0) return;
            this.ClearDgvAutoColumn();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSwitch) return;
            bool result = BLL.Assistant.ConfirmMessage("确认关闭吗？");
            if (!result) e.Cancel = true;
        }

        private void pnlSkin_Click(object sender, EventArgs e)
        {
            FormSkinSet dlg = new FormSkinSet();
            dlg.ShowDialog();
        }

        /// <summary> 显示dgv行号 </summary>
        private void dgvAdminEmployeeInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            BLL.Assistant.ShowRowNum(e, dgvAdminEmployeeInfo);
        }

        private void pnlUpdate_Click(object sender, EventArgs e)
        {
            this.tvDepartment.SelectedNode = tvDepartment.Nodes[0];
            this.GetSearchData();
        }
    }
}
