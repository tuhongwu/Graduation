using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BLL;

namespace HRManage
{
    public partial class InfoAdd : DevExpress.XtraEditors.XtraForm
    {
        public InfoAdd()
        {
            InitializeComponent();
        }

        BLL.BllDbOpt bll = new BLL.BllDbOpt();

        private string employeeID = string.Empty;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private bool isUpdate = false;

        public bool IsUpdate
        {
            get { return isUpdate; }
            set { isUpdate = value; }
        }

        private void pnlSave_Click(object sender, EventArgs e)
        {
            string tableName = this.tctlAdd.SelectedTab.Tag.ToString();
            Hashtable ht = IdentifyWhichTable(tableName);

            bool result =false;
            if (isUpdate)
            {
                ht.Remove("EmployeeID");
                result = bll.UpdateEmployeeInfo(tableName, ht, employeeID);
            }
            else
            {
                result = bll.AddUserDetail(tableName, ht);
            }
            MessageBox.Show(string.Format("{0}{1}！", isUpdate ? "修改" : "添加", result ? "成功" : "失败"));
        }

        private Hashtable IdentifyWhichTable(string tableName)
        {
            Hashtable ht = new Hashtable();  
            switch (tableName)
            {
                case "Employee":
                    ht = this.GetHashtableBase();
                    break;
                case "EmployeeContract":
                    ht = this.GetHashtableContract();
                    break;
                case "EmployeeMoney":
                    ht = this.GetHashtableMoney();
                    break;
                case "EmployeeTraining":
                    ht = this.GetHashtableTrain();
                    break;
                case "EmployeeTest":
                    ht = this.GetHashtableTest();
                    break;
                case "EmployeeTransfer":
                    ht = this.GetHashtableTransfer();
                    break;
                case "EmployeeInsurance":
                    ht = this.GetHashtableInsurance();
                    break;
                case "EmployeeWelfare":
                    ht = this.GetHashtableWelfare();
                    break;
                case "EmployeeQuitstate":
                    ht = this.GetHashtableQuitstate();
                    break;
                default:
                    ht = null;
                    break;
            }
            return ht;
        }
        
        private Hashtable GetHashtableContract()
        {
            Hashtable ht = new Hashtable();

            ht["EmployeeID"] = this.txtContractID.Text;
            ht["ContractID"] = this.txtContractID1.Text;
            ht["ContractType"] = this.cmbContractType.SelectedItem.ToString();
            ht["SigningTime"] = this.dtpSigningTime.Text;
            ht["ExpireTime"] = this.dtpExpireTime.Text;
            ht["Relieve"] = this.ucRelieve.Checked ? "是" : "否";
            ht["RelieveTime"] = this.dtpRelieveTime.Text;
            ht["ContractState"] = this.cmbContractState.SelectedItem.ToString();

            return ht;
        }

        private void SetHashtableContract(DataTable dt)
        {
            this.txtContractID.Text = employeeID;
            this.txtContractID1.Text = dt.Rows[0]["ContractID"].ToString();
            this.cmbContractType.SelectedItem = dt.Rows[0]["ContractType"].ToString();
            this.dtpSigningTime.Text = dt.Rows[0]["SigningTime"].ToString();
            this.dtpExpireTime.Text = dt.Rows[0]["ExpireTime"].ToString();
            this.ucRelieve.Checked = dt.Rows[0]["Relieve"].ToString().Equals("是") ? true : false;
            this.dtpRelieveTime.Text = dt.Rows[0]["RelieveTime"].ToString();
            this.cmbContractState.SelectedItem = dt.Rows[0]["ContractState"].ToString();
        }

        private Hashtable GetHashtableMoney()
        {
            Hashtable ht = new Hashtable();

            ht["EmployeeID"] = this.txtRewardandPunishmentID.Text;
            ht["RewardandPunishmentTime"] = this.dtpRewardandPunishmentTime.Text;
            ht["RewardandPunishmentProject"] = this.cmbRewardandPunishmentProject.SelectedItem.ToString();
            ht["RewardandPunishmentAttribute"] = this.txtCount.Text;
            ht["RewardandPunishmentMoney"] = this.txtRewardandPunishmentMoney.Text;

            ht["OriginalTitle"] = this.cmbOriginalTitle.SelectedItem.ToString();
            ht["CurrentTitle"] = this.cmbCurrentTitle.SelectedItem.ToString();
            ht["AcquireWay"] = this.txtAcquireWay.Text;
            ht["AcquireTime"] = this.dtpAcquireTime.Text;
            ht["Approver"] = this.txtApprover.Text;

            ht["LeaveDate"] = this.dtpLeaveDate.Text;
            ht["LeaveReason"] = this.cmbLeaveReason.SelectedItem.ToString();
            ht["LeaveApprover"] = this.txtLeaveApprover.Text;
            ht["ApprovalComments"] = this.cmbApprovalComments.SelectedItem.ToString();
            ht["OvertimeHours"] = this.txtOvertimeHours.Text;
            ht["OvertimeReward"] = this.txtOvertimeReward.Text;
            ht["OvertimePeople"] = this.txtOvertimePeople.Text;
            //ht["ShouldArriveDays"] = this.txtShouldArriveDays.Text;
            ht["ActualDays"] = this.txtActualDays.Text;

            ht["ShouldPay"] = this.txtShouldPay.Text;
            ht["ActualPay"] = this.txtActualPay.Text;

            return ht;
        }

        private void SetHashtableMoney(DataTable dt)
        {
            this.txtRewardandPunishmentID.Text = employeeID;
            this.dtpRewardandPunishmentTime.Text = dt.Rows[0]["RewardandPunishmentTime"].ToString();
            this.cmbRewardandPunishmentProject.SelectedItem = dt.Rows[0]["RewardandPunishmentProject"].ToString();
            this.txtCount.Text = dt.Rows[0]["RewardandPunishmentAttribute"].ToString();
            this.txtRewardandPunishmentMoney.Text = dt.Rows[0]["RewardandPunishmentMoney"].ToString();

            this.cmbOriginalTitle.SelectedItem = dt.Rows[0]["OriginalTitle"].ToString();
            this.cmbCurrentTitle.SelectedItem = dt.Rows[0]["CurrentTitle"].ToString();
            this.txtAcquireWay.Text = dt.Rows[0]["AcquireWay"].ToString();
            this.dtpAcquireTime.Text = dt.Rows[0]["AcquireTime"].ToString();
            this.txtApprover.Text = dt.Rows[0]["Approver"].ToString();

            this.dtpLeaveDate.Text = dt.Rows[0]["LeaveDate"].ToString();
            this.cmbLeaveReason.SelectedItem = dt.Rows[0]["LeaveReason"].ToString();
            this.txtLeaveApprover.Text = dt.Rows[0]["LeaveApprover"].ToString();
            this.cmbApprovalComments.SelectedItem = dt.Rows[0]["ApprovalComments"].ToString();
            this.txtOvertimeHours.Text = dt.Rows[0]["OvertimeHours"].ToString();
            this.txtOvertimeReward.Text = dt.Rows[0]["OvertimeReward"].ToString();
            this.txtOvertimePeople.Text = dt.Rows[0]["OvertimePeople"].ToString();
            this.txtActualDays.Text = dt.Rows[0]["ActualDays"].ToString();

            this.txtShouldPay.Text = dt.Rows[0]["ShouldPay"].ToString();
            this.txtActualPay.Text = dt.Rows[0]["ActualPay"].ToString();
        }

        private Hashtable GetHashtableTest()
        {
            Hashtable ht = new Hashtable();

            ht["EmployeeID"] = this.txtTestID.Text;
            ht["TestType"] = this.cmbTestType.SelectedItem.ToString();
            ht["TestTime"] = this.cmbTestTime.SelectedItem.ToString();
            ht["TestScore"] = this.txtTestScore.Text; 
            ht["TestLevel"] = this.cmbTestLevel.SelectedItem.ToString();
            ht["TestEvaluation"] = this.txtTestEvaluation.Text;
            ht["EvaluationPeople"] = this.txtEvaluationPeople.Text;

            return ht;
        }

        private void SetHashtableTest(DataTable dt)
        {
            this.txtTestID.Text = employeeID;
            this.cmbTestType.SelectedItem = dt.Rows[0]["TestType"].ToString();
            this.cmbTestTime.SelectedItem = dt.Rows[0]["TestTime"].ToString();
            this.txtTestScore.Text = dt.Rows[0]["TestScore"].ToString();
            this.cmbTestLevel.SelectedItem = dt.Rows[0]["TestLevel"].ToString();
            this.txtTestEvaluation.Text = dt.Rows[0]["TestEvaluation"].ToString(); 
            this.txtEvaluationPeople.Text = dt.Rows[0]["EvaluationPeople"].ToString();
        }

        private Hashtable GetHashtableTransfer()
        {
            Hashtable ht = new Hashtable();

            ht["EmployeeID"] = this.txtTransferID.Text;
            ht["CurrentDepartment1"] = this.cmbCurrentDepartment.SelectedItem.ToString();
            ht["OriginalDepartment"] = this.cmbOriginalDepartment.SelectedItem.ToString();
            ht["CurrentPosition"] = this.txtCurrentPosition.Text; 
            ht["OriginalPosition"] = this.txtOriginalPosition.Text;
            ht["CurrentWorkType"] = this.cmbCurrentWorkType.SelectedItem.ToString();
            ht["OriginalWorkType"] = this.cmbOriginalWorkType.SelectedItem.ToString();
            ht["CurrentAdministrativeLevel"] = this.cmbCurrentAdministrativeLevel.SelectedItem.ToString();
            ht["OriginalAdministrativeLevel"] = this.cmbOriginalAdministrativeLevel.SelectedItem.ToString();
            ht["TransferType"] = this.cmbTransferType.SelectedItem.ToString();
            ht["TransferTime"] = this.dtpTransferTime.Text;

            return ht;
        }

        private void SetHashtableTransfer(DataTable dt)
        {
            this.txtTransferID.Text = employeeID;
            this.cmbCurrentDepartment.SelectedItem = dt.Rows[0]["CurrentDepartment1"].ToString();
            this.cmbOriginalDepartment.SelectedItem = dt.Rows[0]["OriginalDepartment"].ToString();
            this.txtCurrentPosition.Text = dt.Rows[0]["CurrentPosition"].ToString();
            this.txtOriginalPosition.Text = dt.Rows[0]["OriginalPosition"].ToString();
            this.cmbCurrentWorkType.SelectedItem = dt.Rows[0]["CurrentWorkType"].ToString();
            this.cmbOriginalWorkType.SelectedItem = dt.Rows[0]["OriginalWorkType"].ToString();
            this.cmbCurrentAdministrativeLevel.SelectedItem = dt.Rows[0]["CurrentAdministrativeLevel"].ToString();
            this.cmbOriginalAdministrativeLevel.SelectedItem = dt.Rows[0]["OriginalAdministrativeLevel"].ToString();
            this.cmbTransferType.SelectedItem = dt.Rows[0]["TransferType"].ToString();
            this.dtpTransferTime.Text = dt.Rows[0]["TransferTime"].ToString();
        }

        private Hashtable GetHashtableInsurance()
        {
            Hashtable ht = new Hashtable();

            ht["EmployeeID"] = this.txtInsuranceID.Text;
            ht["InsuranceDate"] = this.dtpInsuranceDate.Text;
            ht["ExpirationDate"] = this.dtpExpirationDate.Text;
            ht["EndowmentInsurance"] = this.ucEndowmentInsurance.Checked ? "已投" : "未投";
            ht["MedicalInsurance"] = this.ucMedicalInsurance.Checked ? "已投" : "未投";
            ht["UnemploymentInsurance"] = this.ucUnemploymentInsurance.Checked ? "已投" : "未投";
            ht["MaternityInsurance"] = this.ucMaternityInsurance.Checked ? "已投" : "未投";
            ht["InjuryInsurance"] = this.ucInjuryInsurance.Checked ? "已投" : "未投";
            ht["HousingProvidentFund"] = this.ucHousingProvidentFund.Checked ? "已投" : "未投";

            return ht;
        }

        private void SetHashtableInsurance(DataTable dt)
        {
            this.txtInsuranceID.Text = employeeID;
            this.dtpInsuranceDate.Text = dt.Rows[0]["InsuranceDate"].ToString();
            this.dtpExpirationDate.Text = dt.Rows[0]["ExpirationDate"].ToString();
            this.ucEndowmentInsurance.Checked = dt.Rows[0]["EndowmentInsurance"].ToString().Equals("已投") ? true : false;
            this.ucMedicalInsurance.Checked = dt.Rows[0]["MedicalInsurance"].ToString().Equals("已投") ? true : false;
            this.ucUnemploymentInsurance.Checked = dt.Rows[0]["UnemploymentInsurance"].ToString().Equals("已投") ? true : false;
            this.ucMaternityInsurance.Checked = dt.Rows[0]["MaternityInsurance"].ToString().Equals("已投") ? true : false;
            this.ucInjuryInsurance.Checked = dt.Rows[0]["InjuryInsurance"].ToString().Equals("已投") ? true : false;
            this.ucHousingProvidentFund.Checked = dt.Rows[0]["HousingProvidentFund"].ToString().Equals("已投") ? true : false;
        }
        
        private Hashtable GetHashtableWelfare()
        {
            Hashtable ht = new Hashtable();
            ht["EmployeeID"] = this.txtWelfareID.Text;
            ht["WelfareProject"] = this.cmbWelfareProject.SelectedItem.ToString();
            ht["WelfareItems"] = this.txtWelfareItems.Text;
            ht["WelfareAmount"] = this.txtWelfareAmount.Text;

            return ht;
        }

        private void SetHashtableWelfare(DataTable dt)
        {
            this.txtWelfareID.Text = employeeID;
            this.cmbWelfareProject.SelectedItem = dt.Rows[0]["WelfareProject"].ToString();
            this.txtWelfareItems.Text = dt.Rows[0]["WelfareItems"].ToString();
            this.txtWelfareAmount.Text = dt.Rows[0]["WelfareAmount"].ToString();
        }

        private Hashtable GetHashtableQuitstate()
        {
            Hashtable ht = new Hashtable();

            ht["EmployeeID"] = this.txtQuitID.Text;
            ht["QuitTime"] = this.dtpQuitTime.Text;
            ht["QuitTpye"] = this.cmbQuitTpye.SelectedItem.ToString();
            ht["WageCutOffTime"] = this.dtpWageCutOffTime.Text;
            ht["QuitDescription"] = this.txtQuitDescription.Text;

            ht["Reinstatement"] = this.ucReinstatement.Checked ? "是" : "否";
            ht["ReinstatementTime"] = this.dtpReinstatementTime.Text;
            ht["ReinstatementType"] = this.cmbReinstatementType.SelectedItem.ToString();
            ht["ReinstatementDescription"] = this.txtReinstatementDescription.Text;

            return ht;
        }

        private void SetHashtableQuitstate(DataTable dt)
        {
            this.txtQuitID.Text = employeeID;
            this.dtpQuitTime.Text = dt.Rows[0]["QuitTime"].ToString();
            this.cmbQuitTpye.SelectedItem = dt.Rows[0]["QuitTpye"].ToString();
            this.dtpWageCutOffTime.Text = dt.Rows[0]["WageCutOffTime"].ToString();
            this.txtQuitDescription.Text = dt.Rows[0]["QuitDescription"].ToString();

            this.ucReinstatement.Checked = dt.Rows[0]["Reinstatement"].ToString().Equals("是") ? true : false;
            this.dtpReinstatementTime.Text = dt.Rows[0]["ReinstatementTime"].ToString();
            this.cmbReinstatementType.SelectedItem = dt.Rows[0]["ReinstatementType"].ToString();
            this.txtReinstatementDescription.Text = dt.Rows[0]["ReinstatementDescription"].ToString();
        }

        private Hashtable GetHashtableTrain()
        {
            Hashtable ht = new Hashtable();

            ht["EmployeeID"] = this.txtTrainingID.Text;
            ht["MechanismID"] = this.txtMechanismID.Text;
            ht["MechanismName"] = this.txtMechanismName.Text;
            ht["MechanismType"] = this.cmbMechanismType.SelectedItem.ToString();
            ht["MechanismNumber"] = this.txtMechanismNumber.Text;
            ht["MechanismWebsite"] = this.txtMechanismWebsite.Text;
            ht["MechanismAddress"] = this.txtMechanismAddress.Text;
            ht["ContactPeople"] = this.txtContactPeople.Text;
            ht["MechanismContactNum"] = this.txtContactPeopleNum.Text;
            ht["ContactMail"] = this.txtContactMail.Text;

            ht["TrainingCourseID"] = this.txtCourseID.Text;
            ht["TrainingCourseName"] = this.txtCourseName.Text;
            ht["TrainingType"] = this.cmbTrainingType.SelectedItem.ToString();
            ht["HostDepartment"] = this.cmbHostDepartment.SelectedItem.ToString();
            ht["TrainingStartTime"] = this.dtpTrainingStartTime.Text;
            ht["TrainingEndTime"] = this.dtpTrainingEndTime.Text;
            ht["TrainingMoney"] = this.txtTrainingMoney.Text;
            ht["TrainingMember"] = this.txtTrainingMember.Text;
            ht["TrainingAttendance"] = this.txtTrainingAttendance.Text;
            ht["TrainingTestResults"] = this.txtTrainingTestResults.Text;

            ht["TrainingTestLevel"] = this.cmbTrainingTestLevel.SelectedItem.ToString();
            ht["TrainingEvaluation"] = this.txtTrainingEvaluation.Text;

            return ht;
        }

        private void SetHashtableTrain(DataTable dt)
        {
            this.txtTrainingID.Text = employeeID;
            this.txtMechanismID.Text = dt.Rows[0]["MechanismID"].ToString();
            this.txtMechanismName.Text = dt.Rows[0]["MechanismName"].ToString();
            this.cmbMechanismType.SelectedItem = dt.Rows[0]["MechanismType"].ToString();
            this.txtMechanismNumber.Text = dt.Rows[0]["MechanismNumber"].ToString();
            this.txtMechanismWebsite.Text = dt.Rows[0]["MechanismWebsite"].ToString();
            this.txtMechanismAddress.Text = dt.Rows[0]["MechanismAddress"].ToString();
            this.txtContactPeople.Text = dt.Rows[0]["ContactPeople"].ToString();
            this.txtContactPeopleNum.Text = dt.Rows[0]["MechanismContactNum"].ToString();
            this.txtContactMail.Text = dt.Rows[0]["ContactMail"].ToString();

            this.txtCourseID.Text = dt.Rows[0]["TrainingCourseID"].ToString();
            this.txtCourseName.Text = dt.Rows[0]["TrainingCourseName"].ToString();
            this.cmbTrainingType.SelectedItem = dt.Rows[0]["TrainingType"].ToString();
            this.cmbHostDepartment.SelectedItem = dt.Rows[0]["HostDepartment"].ToString();
            this.dtpTrainingStartTime.Text = dt.Rows[0]["TrainingStartTime"].ToString();
            this.dtpTrainingEndTime.Text = dt.Rows[0]["TrainingEndTime"].ToString();
            this.txtTrainingMoney.Text = dt.Rows[0]["TrainingMoney"].ToString();
            this.txtTrainingMember.Text = dt.Rows[0]["TrainingMember"].ToString();
            this.txtTrainingAttendance.Text = dt.Rows[0]["TrainingAttendance"].ToString();
            this.txtTrainingTestResults.Text = dt.Rows[0]["TrainingTestResults"].ToString();

            this.cmbTrainingTestLevel.SelectedItem = dt.Rows[0]["TrainingTestLevel"].ToString();
            this.txtTrainingEvaluation.Text = dt.Rows[0]["TrainingEvaluation"].ToString();
        }

        private Hashtable GetHashtableBase()
        {
            Hashtable ht = new Hashtable();

            ht["FamilyPoliticalStatus"] = this.cmbFamilyPoliticalStatus.SelectedItem.ToString();//下拉框
            ht["SkillLevel"] = this.txtSkillLevel.Text;
            ht["WorkTime"]= this.txtWorkTime.Text;//int
            ht["FamilyBirthDate"] = this.dtpFamilyBirthDate.Text;//日期
            ht.Add("NativePlace", this.txtNativePlace.Text);
            ht["WorkContent"] = this.txtWorkContent.Text;
            ht.Add("EmployeeBirthDate", this.dtpBirthDate.Text);//日期
            ht["SkillName"] = this.txtSkillName.Text;
            ht["GraduatedSchool"] = this.txtGraduatedSchool.Text;
            ht["Email"] = this.txtEmail.Text;

            ht.Add("EmployeeName", this.txtName.Text);
            ht["FamilyWorkPlace"] = this.txtFamilyWorkPlace.Text;
            ht["Profession"] = this.txtProfession.Text;
            ht.Add("EmployeeID", this.txtID.Text);//int
            ht["FormerPosition"] = this.txtFormerPosition.Text;
            ht["StartDate"] = this.dtpStartDate.Text;//日期
            ht.Add("PoliticalStatus", this.cmbPoliticalStatus.SelectedItem.ToString());//下拉框
            ht["CellPhoneNumber"] = this.txtCellPhoneNumber.Text;
            ht["FamilyNumber"] = this.txtFamilyNumber.Text;
            ht["EmployeeAddress"] = this.txtAddress.Text;

            ht.Add("EntryTime", this.dtpEntryTime.Text);//日期          
            ht["EndDate"] = this.dtpEndDate.Text;//日期
            ht.Add("EmployeeSex", this.cmbSex.SelectedItem.ToString());//下拉框
            ht["FamilyMember"] = this.txtFamilyMember.Text;
            ht["Education"] = this.cmbEducation.SelectedItem.ToString();//下拉框           
            ht.Add("EmployeeAge", this.txtAge.Text);//int
            ht["Relationship"] = this.txtRelationship.Text;
            ht["WorkPlace"] = this.txtWorkPlace.Text;
            ht.Add("EmployeeIDCard", this.txtIDCard.Text);
            ht["CurrentDepartment"] = this.cmbDepartment.SelectedItem.ToString();//下拉框
            ht.Add("Ethnic", this.cmbEthnic.SelectedItem.ToString());//下拉框   

            return ht;
        }

        private void SetHashtableBase(DataTable dt)
        {
            this.cmbFamilyPoliticalStatus.SelectedItem=dt.Rows[0]["FamilyPoliticalStatus"].ToString();
            this.txtSkillLevel.Text=dt.Rows[0]["SkillLevel"].ToString();
            this.txtWorkTime.Text = dt.Rows[0]["WorkTime"].ToString();
            this.dtpFamilyBirthDate.Text = dt.Rows[0]["FamilyBirthDate"].ToString();
            this.txtNativePlace.Text= dt.Rows[0]["NativePlace"].ToString();
            this.txtWorkContent.Text= dt.Rows[0]["WorkContent"].ToString();
            this.dtpBirthDate.Text= dt.Rows[0]["EmployeeBirthDate"].ToString();
            this.txtSkillName.Text= dt.Rows[0]["SkillName"].ToString();
            this.txtGraduatedSchool.Text= dt.Rows[0]["GraduatedSchool"].ToString();
            this.txtEmail.Text= dt.Rows[0]["Email"].ToString();

            this.txtName.Text= dt.Rows[0]["EmployeeName"].ToString();
            this.txtFamilyWorkPlace.Text= dt.Rows[0]["FamilyWorkPlace"].ToString();
            this.txtProfession.Text= dt.Rows[0]["Profession"].ToString();
            this.txtID.Text = employeeID;
            this.txtFormerPosition.Text= dt.Rows[0]["FormerPosition"].ToString();
            this.dtpStartDate.Text= dt.Rows[0]["StartDate"].ToString();
            this.cmbPoliticalStatus.SelectedItem= dt.Rows[0]["PoliticalStatus"].ToString();
            this.txtCellPhoneNumber.Text= dt.Rows[0]["CellPhoneNumber"].ToString();
            this.txtFamilyNumber.Text= dt.Rows[0]["FamilyNumber"].ToString();
            this.txtAddress.Text= dt.Rows[0]["EmployeeAddress"].ToString();

            this.dtpEntryTime.Text= dt.Rows[0]["EntryTime"].ToString();       
            this.dtpEndDate.Text= dt.Rows[0]["EndDate"].ToString();
            this.cmbSex.SelectedItem= dt.Rows[0]["EmployeeSex"].ToString();
            this.txtFamilyMember.Text= dt.Rows[0]["FamilyMember"].ToString();
            this.cmbEducation.SelectedItem= dt.Rows[0]["Education"].ToString();
            this.txtAge.Text= dt.Rows[0]["EmployeeAge"].ToString();
            this.txtRelationship.Text= dt.Rows[0]["Relationship"].ToString();
            this.txtWorkPlace.Text= dt.Rows[0]["WorkPlace"].ToString();
            this.txtIDCard.Text= dt.Rows[0]["EmployeeIDCard"].ToString();
            this.cmbDepartment.SelectedItem= dt.Rows[0]["CurrentDepartment"].ToString();
            this.cmbEthnic.SelectedItem= dt.Rows[0]["Ethnic"].ToString();
        }

        private void InfoAdd_Load(object sender, EventArgs e)
        {
            SetSwitchButtonEnable();
            this.InitControlState();
            this.InitTxtType(); 
            this.InitCmbSelected();
            tctlAdd_SelectedIndexChanged(null, null);
            //this.txtID.ReadOnly = true;
            //this.txtID.Text = Model.ModelUserInfo.UserID;
        }

        private void InitControlState()
        {
            string strUpdate = isUpdate ? "修改" : "添加";
            this.Text = string.Format("{0}信息", strUpdate);
            this.btnSave.Text = strUpdate;
            this.btnPre.Visible = isUpdate;
            this.btnNext.Visible = isUpdate;
        }

        private void InitTxtType()
        {
            this.txtWorkTime.Text = "0";
            this.txtAge.Text = "0";
        }

        private void InitCmbSelected()
        {
            //基本信息
            this.cmbSex.SelectedIndex = 0;
            this.cmbDepartment.SelectedIndex = 0;
            this.cmbEducation.SelectedIndex = 0;
            this.cmbEthnic.SelectedIndex = 0;
            this.cmbPoliticalStatus.SelectedIndex = 0;
            this.cmbFamilyPoliticalStatus.SelectedIndex = 0;
            //合同信息
            this.cmbContractState.SelectedIndex = 0;
            this.cmbContractType.SelectedIndex = 0;
            //奖惩信息
            this.cmbRewardandPunishmentProject.SelectedIndex = 0;
            //this.cmbRewardandPunishmentAttribute.SelectedIndex = 0;
            //培训信息
            this.cmbTrainingTestLevel.SelectedIndex = 0;
            this.cmbTrainingType.SelectedIndex = 0;
            this.cmbMechanismType.SelectedIndex = 0;
            this.cmbHostDepartment.SelectedIndex = 0;
            //考核信息
            this.cmbTestType.SelectedIndex = 0;
            this.cmbTestTime.SelectedIndex = 0;
            this.cmbTestLevel.SelectedIndex = 0;
            //调动信息
            this.cmbTransferType.SelectedIndex = 0;
            this.cmbCurrentDepartment.SelectedIndex = 0;
            this.cmbOriginalDepartment.SelectedIndex = 0;        
            this.cmbCurrentWorkType.SelectedIndex = 0;
            this.cmbOriginalWorkType.SelectedIndex = 0;
            this.cmbCurrentAdministrativeLevel.SelectedIndex = 0;
            this.cmbOriginalAdministrativeLevel.SelectedIndex = 0;
            //职称信息
            this.cmbOriginalTitle.SelectedIndex = 0;
            this.cmbCurrentTitle.SelectedIndex = 0;
            //福利信息
            this.cmbWelfareProject.SelectedIndex = 0;
            //考勤信息
            this.cmbLeaveReason.SelectedIndex = 0;
            this.cmbApprovalComments.SelectedIndex = 0;
            //离职信息
            this.cmbQuitTpye.SelectedIndex = 0;
            //复职信息
            this.cmbReinstatementType.SelectedIndex = 0;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLL.Assistant.CheckIsNums(e); 
        }

        private void pnlQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tctlAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isUpdate) return;
            string tableName = this.tctlAdd.SelectedTab.Tag.ToString();
            //int index = this.tctlAdd.SelectedIndex;
            //if (index < 0) return;
            //string dataName = this.tctlAdd.TabPages[index].Tag.ToString();         
            DataTable dt = bll.GetEmployeeInfo(tableName, employeeID);
            if (BLL.Assistant.IsDtNull(dt)) return;
            this.SetDgvDatasource(dt, tableName);
        }

        private void SetDgvDatasource(DataTable dt, string tableName)
        {
            switch (tableName)
            {
                case "Employee":
                    this.SetHashtableBase(dt);
                    break;
                case "EmployeeContract":
                    this.SetHashtableContract(dt);
                    break;
                case "EmployeeMoney":
                    this.SetHashtableMoney(dt);
                    break;
                case "EmployeeTraining":
                    this.SetHashtableTrain(dt);
                    break;
                case "EmployeeTest":
                    this.SetHashtableTest(dt);
                    break;
                case "EmployeeTransfer":
                    this.SetHashtableTransfer(dt);
                    break;
                case "EmployeeInsurance":
                    this.SetHashtableInsurance(dt);
                    break;
                case "EmployeeWelfare":
                    this.SetHashtableWelfare(dt);
                    break;
                case "EmployeeQuitstate":
                    this.SetHashtableQuitstate(dt);
                    break;
                default:
                    break;
            }
        }

        #region 项目切换
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Button btn = sender as Button;
                string opt = btn.Tag.ToString();

                if (opt.Equals("UP"))
                {
                    projectRowHandle--;
                }
                else if (opt.Equals("DOWN"))
                {
                    projectRowHandle++;
                }

                this.ShowProjectDetailInfo();
                this.SetSwitchButtonEnable();
            }
            catch
            {
                Assistant.ShowMessage("数据切换异常!");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowProjectDetailInfo()
        {
            if (projectRowHandle < 0) return;
            if (OnSwitchProject == null) return;

            string dr = OnSwitchProject(projectRowHandle);
            if (dr == null) return;
            employeeID = dr;
            int count = this.tctlAdd.TabPages[this.tctlAdd.SelectedIndex].Controls.Count;
            //Control[] control = null;
            //this.tctlAdd.TabPages[this.tctlAdd.SelectedIndex].Controls.CopyTo(control, 0);
            BLL.Assistant.ClearControls(tctlAdd.TabPages[this.tctlAdd.SelectedIndex]);
            tctlAdd_SelectedIndexChanged(null, null);
        }

        private void SetSwitchButtonEnable()
        {
            btnPre.Enabled = projectRowHandle != 0;
            btnNext.Enabled = projectRowHandle != projectCnt - 1;
        }

        #endregion

        int projectRowHandle = -1;
        /// <summary> 当前项目Index </summary>
        public int ProjectRowHandle
        {
            //get { return projectRowHandle; }
            set { projectRowHandle = value; }
        }

        int projectCnt;
        /// <summary> 项目总数 </summary>
        public int ProjectCnt
        {
            set { projectCnt = value; }
        }

        #region 自定义事件

        /// <summary> 切换项目代理 </summary>
        public delegate string SwitchProjectHandler(int projIndex);
        /// <summary> 切换项目事件 </summary>
        public event SwitchProjectHandler OnSwitchProject;

        #endregion

        private void btntotal_Click(object sender, EventArgs e)//工资结算算法
        {
            int index = this.cmbCurrentTitle.SelectedIndex;
            int baseMoney = this.GetBaseMoney(index);
            this.txtShouldPay.Text = baseMoney.ToString();

            int countReward = this.GetActualMoney();
            baseMoney += countReward;
            string strDays = this.txtActualDays.Text;
            if (!string.IsNullOrEmpty(strDays))
            {
                int countDays = Convert.ToInt32(strDays);
                baseMoney -= countDays * 80;
            }
            if (!string.IsNullOrEmpty(txtOvertimeReward.Text))
            {
                int countOvertime = Convert.ToInt32(txtOvertimeReward.Text);
                baseMoney += countOvertime;
            }
            this.txtActualPay.Text = (baseMoney > 0) ? baseMoney.ToString() : "0";
        }

        private int GetActualMoney()
        {
            string strReward = this.txtRewardandPunishmentMoney.Text;
            int index = this.cmbRewardandPunishmentProject.SelectedIndex;
            int countReward = 0;
            if (!string.IsNullOrEmpty(strReward))
            {
                countReward = Convert.ToInt32(strReward);
                if (index == 1)
                {
                    countReward = -countReward;
                }
            }
            return countReward;
        }

        private int GetBaseMoney(int index)
        {
            int baseMoney = 0;
            switch (index)
            {
                default:
                    baseMoney = 2000;
                    break;
                case 1:
                    baseMoney = 5000;
                    break;
                case 2:
                    baseMoney = 4000;
                    break;
                case 3:
                    baseMoney = 3000;
                    break;
            }
            return baseMoney;
        }

        private void cmbRewardandPunishmentProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cmbRewardandPunishmentProject.SelectedIndex;
            this.txtCount.ReadOnly = index.Equals(1) ? false : true;
            switch (index)
            { 
                case 0:
                    this.txtRewardandPunishmentMoney.Text = "0";
                    break;
                case 2:
                    this.txtRewardandPunishmentMoney.Text = "200";
                    break;
                default:
                    this.txtRewardandPunishmentMoney.Text = string.Empty;
                    break;
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLL.Assistant.CheckIsNums(e);
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            this.txtRewardandPunishmentMoney.Text = SetTextValue(this.txtCount.Text, 30);
        }

        private string SetTextValue(string txtcount,int cost)
        {
            if (string.IsNullOrEmpty(txtcount))
            {
                return string.Empty;
            }
            int count = Convert.ToInt32(txtcount);
            return string.Format("{0}", count * cost);
        }

        private void txtOvertimeHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLL.Assistant.CheckIsNums(e);
        }

        private void txtOvertimeHours_TextChanged(object sender, EventArgs e)
        {
            this.txtOvertimeReward.Text = SetTextValue(this.txtOvertimeHours.Text, 15);
        }

        private void txtActualDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLL.Assistant.CheckIsNums(e);
        }
    }
}