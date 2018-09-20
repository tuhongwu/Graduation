namespace HRManage
{
    partial class FormEmployee
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btnModifyPassword = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NativePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ethnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoliticalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GraduatedSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormerPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyPoliticalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyWorkPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tctl = new System.Windows.Forms.TabControl();
            this.PEmployeeContract = new System.Windows.Forms.TabPage();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relieve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelieveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmployeeReward = new System.Windows.Forms.TabPage();
            this.dgvRewardandPunishment = new System.Windows.Forms.DataGridView();
            this.RewardandPunishmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardandPunishmentProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardandPunishmentAttribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardandPunishmentMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmployeeTraining = new System.Windows.Forms.TabPage();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.HostDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingTestResults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingTestLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmployeeTest = new System.Windows.Forms.TabPage();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.TestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmployeeCheck = new System.Windows.Forms.TabPage();
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.LeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveApprover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OvertimeHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OvertimeReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OvertimePeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShouldArriveDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmployeePay = new System.Windows.Forms.TabPage();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.ShouldPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmployeeInsurance = new System.Windows.Forms.TabPage();
            this.dgvInsurance = new System.Windows.Forms.DataGridView();
            this.InsuranceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndowmentInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnemploymentInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaternityInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InjuryInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HousingProvidentFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmployeeWelfare = new System.Windows.Forms.TabPage();
            this.dgvWelfare = new System.Windows.Forms.DataGridView();
            this.WelfareProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WelfareItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WelfareAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tctl.SuspendLayout();
            this.PEmployeeContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.PEmployeeReward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewardandPunishment)).BeginInit();
            this.PEmployeeTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.PEmployeeTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.PEmployeeCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            this.PEmployeePay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.PEmployeeInsurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).BeginInit();
            this.PEmployeeWelfare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWelfare)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuery
            // 
            this.pnlQuery.Controls.Add(this.btnSwitch);
            this.pnlQuery.Controls.Add(this.btnModifyPassword);
            this.pnlQuery.Controls.Add(this.txtEmployeeID);
            this.pnlQuery.Controls.Add(this.lblEmployeeID);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 0);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(915, 49);
            this.pnlQuery.TabIndex = 0;
            // 
            // btnModifyPassword
            // 
            this.btnModifyPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModifyPassword.Location = new System.Drawing.Point(698, 9);
            this.btnModifyPassword.Name = "btnModifyPassword";
            this.btnModifyPassword.Size = new System.Drawing.Size(87, 27);
            this.btnModifyPassword.TabIndex = 3;
            this.btnModifyPassword.Text = "修改密码";
            this.btnModifyPassword.UseVisualStyleBackColor = true;
            this.btnModifyPassword.Click += new System.EventHandler(this.btnModifyPassword_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmployeeID.Location = new System.Drawing.Point(78, 10);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(257, 23);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmployeeID.Location = new System.Drawing.Point(20, 14);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(44, 17);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "工号 :";
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.AllowUserToAddRows = false;
            this.dgvEmployeeInfo.AllowUserToDeleteRows = false;
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeIDCard,
            this.EmployeeSex,
            this.EmployeeBirthDate,
            this.EmployeeAge,
            this.NativePlace,
            this.Ethnic,
            this.PoliticalStatus,
            this.CellPhoneNumber,
            this.Email,
            this.EmployeeAddress,
            this.EntryTime,
            this.WorkTime,
            this.Education,
            this.GraduatedSchool,
            this.Profession,
            this.CurrentDepartment,
            this.StartDate,
            this.EndDate,
            this.FormerPosition,
            this.WorkPlace,
            this.WorkContent,
            this.SkillName,
            this.SkillLevel,
            this.FamilyMember,
            this.Relationship,
            this.FamilyBirthDate,
            this.FamilyPoliticalStatus,
            this.FamilyWorkPlace,
            this.FamilyNumber});
            this.dgvEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(0, 49);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.ReadOnly = true;
            this.dgvEmployeeInfo.RowTemplate.Height = 23;
            this.dgvEmployeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(915, 424);
            this.dgvEmployeeInfo.TabIndex = 1;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "工号";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 70;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "姓名";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 80;
            // 
            // EmployeeIDCard
            // 
            this.EmployeeIDCard.DataPropertyName = "EmployeeIDCard";
            this.EmployeeIDCard.HeaderText = "身份证号";
            this.EmployeeIDCard.Name = "EmployeeIDCard";
            this.EmployeeIDCard.ReadOnly = true;
            this.EmployeeIDCard.Width = 140;
            // 
            // EmployeeSex
            // 
            this.EmployeeSex.DataPropertyName = "EmployeeSex";
            this.EmployeeSex.HeaderText = "性别";
            this.EmployeeSex.Name = "EmployeeSex";
            this.EmployeeSex.ReadOnly = true;
            this.EmployeeSex.Width = 40;
            // 
            // EmployeeBirthDate
            // 
            this.EmployeeBirthDate.DataPropertyName = "EmployeeBirthDate";
            this.EmployeeBirthDate.HeaderText = "出生年月";
            this.EmployeeBirthDate.Name = "EmployeeBirthDate";
            this.EmployeeBirthDate.ReadOnly = true;
            this.EmployeeBirthDate.Width = 80;
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.DataPropertyName = "EmployeeAge";
            this.EmployeeAge.HeaderText = "年龄";
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.ReadOnly = true;
            this.EmployeeAge.Width = 40;
            // 
            // NativePlace
            // 
            this.NativePlace.DataPropertyName = "NativePlace";
            this.NativePlace.HeaderText = "籍贯";
            this.NativePlace.Name = "NativePlace";
            this.NativePlace.ReadOnly = true;
            this.NativePlace.Width = 40;
            // 
            // Ethnic
            // 
            this.Ethnic.DataPropertyName = "Ethnic";
            this.Ethnic.HeaderText = "民族";
            this.Ethnic.Name = "Ethnic";
            this.Ethnic.ReadOnly = true;
            this.Ethnic.Width = 70;
            // 
            // PoliticalStatus
            // 
            this.PoliticalStatus.DataPropertyName = "PoliticalStatus";
            this.PoliticalStatus.HeaderText = "政治面貌";
            this.PoliticalStatus.Name = "PoliticalStatus";
            this.PoliticalStatus.ReadOnly = true;
            this.PoliticalStatus.Width = 80;
            // 
            // CellPhoneNumber
            // 
            this.CellPhoneNumber.DataPropertyName = "CellPhoneNumber";
            this.CellPhoneNumber.HeaderText = "手机号码";
            this.CellPhoneNumber.Name = "CellPhoneNumber";
            this.CellPhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮箱";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 120;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.DataPropertyName = "EmployeeAddress";
            this.EmployeeAddress.HeaderText = "家庭住址";
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.ReadOnly = true;
            this.EmployeeAddress.Width = 160;
            // 
            // EntryTime
            // 
            this.EntryTime.DataPropertyName = "EntryTime";
            this.EntryTime.HeaderText = "入职时间";
            this.EntryTime.Name = "EntryTime";
            this.EntryTime.ReadOnly = true;
            this.EntryTime.Width = 80;
            // 
            // WorkTime
            // 
            this.WorkTime.DataPropertyName = "WorkTime";
            this.WorkTime.HeaderText = "总工龄";
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.ReadOnly = true;
            this.WorkTime.Width = 70;
            // 
            // Education
            // 
            this.Education.DataPropertyName = "Education";
            this.Education.HeaderText = "学历";
            this.Education.Name = "Education";
            this.Education.ReadOnly = true;
            this.Education.Width = 60;
            // 
            // GraduatedSchool
            // 
            this.GraduatedSchool.DataPropertyName = "GraduatedSchool";
            this.GraduatedSchool.HeaderText = "毕业院校";
            this.GraduatedSchool.Name = "GraduatedSchool";
            this.GraduatedSchool.ReadOnly = true;
            this.GraduatedSchool.Width = 150;
            // 
            // Profession
            // 
            this.Profession.DataPropertyName = "Profession";
            this.Profession.HeaderText = "专业";
            this.Profession.Name = "Profession";
            this.Profession.ReadOnly = true;
            this.Profession.Width = 90;
            // 
            // CurrentDepartment
            // 
            this.CurrentDepartment.DataPropertyName = "CurrentDepartment";
            this.CurrentDepartment.HeaderText = "部门";
            this.CurrentDepartment.Name = "CurrentDepartment";
            this.CurrentDepartment.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "开始日期";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "结束日期";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // FormerPosition
            // 
            this.FormerPosition.DataPropertyName = "FormerPosition";
            this.FormerPosition.HeaderText = "曾任职位";
            this.FormerPosition.Name = "FormerPosition";
            this.FormerPosition.ReadOnly = true;
            // 
            // WorkPlace
            // 
            this.WorkPlace.DataPropertyName = "WorkPlace";
            this.WorkPlace.HeaderText = "工作单位";
            this.WorkPlace.Name = "WorkPlace";
            this.WorkPlace.ReadOnly = true;
            // 
            // WorkContent
            // 
            this.WorkContent.DataPropertyName = "WorkContent";
            this.WorkContent.HeaderText = "工作内容";
            this.WorkContent.Name = "WorkContent";
            this.WorkContent.ReadOnly = true;
            // 
            // SkillName
            // 
            this.SkillName.DataPropertyName = "SkillName";
            this.SkillName.HeaderText = "技能名称";
            this.SkillName.Name = "SkillName";
            this.SkillName.ReadOnly = true;
            // 
            // SkillLevel
            // 
            this.SkillLevel.DataPropertyName = "SkillLevel";
            this.SkillLevel.HeaderText = "级别";
            this.SkillLevel.Name = "SkillLevel";
            this.SkillLevel.ReadOnly = true;
            // 
            // FamilyMember
            // 
            this.FamilyMember.DataPropertyName = "FamilyMember";
            this.FamilyMember.HeaderText = "家庭成员";
            this.FamilyMember.Name = "FamilyMember";
            this.FamilyMember.ReadOnly = true;
            // 
            // Relationship
            // 
            this.Relationship.DataPropertyName = "Relationship";
            this.Relationship.HeaderText = "与本人关系";
            this.Relationship.Name = "Relationship";
            this.Relationship.ReadOnly = true;
            // 
            // FamilyBirthDate
            // 
            this.FamilyBirthDate.DataPropertyName = "FamilyBirthDate";
            this.FamilyBirthDate.HeaderText = "出生日期（家人）";
            this.FamilyBirthDate.Name = "FamilyBirthDate";
            this.FamilyBirthDate.ReadOnly = true;
            this.FamilyBirthDate.Width = 130;
            // 
            // FamilyPoliticalStatus
            // 
            this.FamilyPoliticalStatus.DataPropertyName = "FamilyPoliticalStatus";
            this.FamilyPoliticalStatus.HeaderText = "政治面貌（家人）";
            this.FamilyPoliticalStatus.Name = "FamilyPoliticalStatus";
            this.FamilyPoliticalStatus.ReadOnly = true;
            this.FamilyPoliticalStatus.Width = 130;
            // 
            // FamilyWorkPlace
            // 
            this.FamilyWorkPlace.DataPropertyName = "FamilyWorkPlace";
            this.FamilyWorkPlace.HeaderText = "工作单位(家人)";
            this.FamilyWorkPlace.Name = "FamilyWorkPlace";
            this.FamilyWorkPlace.ReadOnly = true;
            this.FamilyWorkPlace.Width = 120;
            // 
            // FamilyNumber
            // 
            this.FamilyNumber.DataPropertyName = "FamilyNumber";
            this.FamilyNumber.HeaderText = "联系方式（家人）";
            this.FamilyNumber.Name = "FamilyNumber";
            this.FamilyNumber.ReadOnly = true;
            this.FamilyNumber.Width = 130;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tctl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 183);
            this.panel1.TabIndex = 5;
            // 
            // tctl
            // 
            this.tctl.Controls.Add(this.PEmployeeContract);
            this.tctl.Controls.Add(this.PEmployeeReward);
            this.tctl.Controls.Add(this.PEmployeeTraining);
            this.tctl.Controls.Add(this.PEmployeeTest);
            this.tctl.Controls.Add(this.PEmployeeCheck);
            this.tctl.Controls.Add(this.PEmployeePay);
            this.tctl.Controls.Add(this.PEmployeeInsurance);
            this.tctl.Controls.Add(this.PEmployeeWelfare);
            this.tctl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tctl.Location = new System.Drawing.Point(0, 0);
            this.tctl.Name = "tctl";
            this.tctl.SelectedIndex = 0;
            this.tctl.Size = new System.Drawing.Size(915, 183);
            this.tctl.TabIndex = 3;
            this.tctl.SelectedIndexChanged += new System.EventHandler(this.tctl_SelectedIndexChanged);
            // 
            // PEmployeeContract
            // 
            this.PEmployeeContract.Controls.Add(this.dgvContract);
            this.PEmployeeContract.Location = new System.Drawing.Point(4, 26);
            this.PEmployeeContract.Name = "PEmployeeContract";
            this.PEmployeeContract.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeeContract.Size = new System.Drawing.Size(907, 153);
            this.PEmployeeContract.TabIndex = 0;
            this.PEmployeeContract.Tag = "EmployeeContract";
            this.PEmployeeContract.Text = "合同信息";
            this.PEmployeeContract.UseVisualStyleBackColor = true;
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractID,
            this.ContractType,
            this.SigningTime,
            this.ExpireTime,
            this.Relieve,
            this.RelieveTime,
            this.ContractState});
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.Location = new System.Drawing.Point(3, 3);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.ReadOnly = true;
            this.dgvContract.RowTemplate.Height = 23;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.Size = new System.Drawing.Size(901, 147);
            this.dgvContract.TabIndex = 0;
            // 
            // ContractID
            // 
            this.ContractID.DataPropertyName = "ContractID";
            this.ContractID.HeaderText = "合同号";
            this.ContractID.Name = "ContractID";
            this.ContractID.ReadOnly = true;
            // 
            // ContractType
            // 
            this.ContractType.DataPropertyName = "ContractType";
            this.ContractType.HeaderText = "合同类型";
            this.ContractType.Name = "ContractType";
            this.ContractType.ReadOnly = true;
            // 
            // SigningTime
            // 
            this.SigningTime.DataPropertyName = "SigningTime";
            this.SigningTime.HeaderText = "签约时间";
            this.SigningTime.Name = "SigningTime";
            this.SigningTime.ReadOnly = true;
            // 
            // ExpireTime
            // 
            this.ExpireTime.DataPropertyName = "ExpireTime";
            this.ExpireTime.HeaderText = "到期时间";
            this.ExpireTime.Name = "ExpireTime";
            this.ExpireTime.ReadOnly = true;
            // 
            // Relieve
            // 
            this.Relieve.DataPropertyName = "Relieve";
            this.Relieve.HeaderText = "是否解除";
            this.Relieve.Name = "Relieve";
            this.Relieve.ReadOnly = true;
            // 
            // RelieveTime
            // 
            this.RelieveTime.DataPropertyName = "RelieveTime";
            this.RelieveTime.HeaderText = "解除时间";
            this.RelieveTime.Name = "RelieveTime";
            this.RelieveTime.ReadOnly = true;
            // 
            // ContractState
            // 
            this.ContractState.DataPropertyName = "ContractState";
            this.ContractState.HeaderText = "状态";
            this.ContractState.Name = "ContractState";
            this.ContractState.ReadOnly = true;
            // 
            // PEmployeeReward
            // 
            this.PEmployeeReward.Controls.Add(this.dgvRewardandPunishment);
            this.PEmployeeReward.Location = new System.Drawing.Point(4, 26);
            this.PEmployeeReward.Name = "PEmployeeReward";
            this.PEmployeeReward.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeeReward.Size = new System.Drawing.Size(907, 153);
            this.PEmployeeReward.TabIndex = 1;
            this.PEmployeeReward.Tag = "ViewReward";
            this.PEmployeeReward.Text = "奖惩信息";
            this.PEmployeeReward.UseVisualStyleBackColor = true;
            // 
            // dgvRewardandPunishment
            // 
            this.dgvRewardandPunishment.AllowUserToAddRows = false;
            this.dgvRewardandPunishment.AllowUserToDeleteRows = false;
            this.dgvRewardandPunishment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRewardandPunishment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RewardandPunishmentTime,
            this.RewardandPunishmentProject,
            this.RewardandPunishmentAttribute,
            this.RewardandPunishmentMoney});
            this.dgvRewardandPunishment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRewardandPunishment.Location = new System.Drawing.Point(3, 3);
            this.dgvRewardandPunishment.Name = "dgvRewardandPunishment";
            this.dgvRewardandPunishment.ReadOnly = true;
            this.dgvRewardandPunishment.RowTemplate.Height = 23;
            this.dgvRewardandPunishment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRewardandPunishment.Size = new System.Drawing.Size(901, 147);
            this.dgvRewardandPunishment.TabIndex = 1;
            // 
            // RewardandPunishmentTime
            // 
            this.RewardandPunishmentTime.DataPropertyName = "RewardandPunishmentTime";
            this.RewardandPunishmentTime.HeaderText = "奖惩时间";
            this.RewardandPunishmentTime.Name = "RewardandPunishmentTime";
            this.RewardandPunishmentTime.ReadOnly = true;
            // 
            // RewardandPunishmentProject
            // 
            this.RewardandPunishmentProject.DataPropertyName = "RewardandPunishmentProject";
            this.RewardandPunishmentProject.HeaderText = "奖惩项目";
            this.RewardandPunishmentProject.Name = "RewardandPunishmentProject";
            this.RewardandPunishmentProject.ReadOnly = true;
            // 
            // RewardandPunishmentAttribute
            // 
            this.RewardandPunishmentAttribute.DataPropertyName = "RewardandPunishmentAttribute";
            this.RewardandPunishmentAttribute.HeaderText = "奖惩属性";
            this.RewardandPunishmentAttribute.Name = "RewardandPunishmentAttribute";
            this.RewardandPunishmentAttribute.ReadOnly = true;
            // 
            // RewardandPunishmentMoney
            // 
            this.RewardandPunishmentMoney.DataPropertyName = "RewardandPunishmentMoney";
            this.RewardandPunishmentMoney.HeaderText = "奖惩金额";
            this.RewardandPunishmentMoney.Name = "RewardandPunishmentMoney";
            this.RewardandPunishmentMoney.ReadOnly = true;
            // 
            // PEmployeeTraining
            // 
            this.PEmployeeTraining.Controls.Add(this.dgvTraining);
            this.PEmployeeTraining.Location = new System.Drawing.Point(4, 26);
            this.PEmployeeTraining.Name = "PEmployeeTraining";
            this.PEmployeeTraining.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeeTraining.Size = new System.Drawing.Size(907, 153);
            this.PEmployeeTraining.TabIndex = 2;
            this.PEmployeeTraining.Tag = "EmployeeTraining";
            this.PEmployeeTraining.Text = "培训信息";
            this.PEmployeeTraining.UseVisualStyleBackColor = true;
            // 
            // dgvTraining
            // 
            this.dgvTraining.AllowUserToAddRows = false;
            this.dgvTraining.AllowUserToDeleteRows = false;
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostDepartment,
            this.TrainingMember,
            this.TrainingMoney,
            this.MechanismName,
            this.MechanismNumber,
            this.MechanismWebsite,
            this.MechanismAddress,
            this.ContactPeople,
            this.MechanismContactNumber,
            this.TrainingCourseName,
            this.TrainingType,
            this.TrainingStartTime,
            this.TrainingEndTime,
            this.TrainingAttendance,
            this.TrainingTestResults,
            this.TrainingTestLevel,
            this.TrainingEvaluation});
            this.dgvTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraining.Location = new System.Drawing.Point(3, 3);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.ReadOnly = true;
            this.dgvTraining.RowTemplate.Height = 23;
            this.dgvTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraining.Size = new System.Drawing.Size(901, 147);
            this.dgvTraining.TabIndex = 2;
            // 
            // HostDepartment
            // 
            this.HostDepartment.DataPropertyName = "HostDepartment";
            this.HostDepartment.HeaderText = "主办部门";
            this.HostDepartment.Name = "HostDepartment";
            this.HostDepartment.ReadOnly = true;
            // 
            // TrainingMember
            // 
            this.TrainingMember.DataPropertyName = "TrainingMember";
            this.TrainingMember.HeaderText = "培训对象";
            this.TrainingMember.Name = "TrainingMember";
            this.TrainingMember.ReadOnly = true;
            // 
            // TrainingMoney
            // 
            this.TrainingMoney.DataPropertyName = "TrainingMoney";
            this.TrainingMoney.HeaderText = "培训费用";
            this.TrainingMoney.Name = "TrainingMoney";
            this.TrainingMoney.ReadOnly = true;
            // 
            // MechanismName
            // 
            this.MechanismName.DataPropertyName = "MechanismName";
            this.MechanismName.HeaderText = "机构名称";
            this.MechanismName.Name = "MechanismName";
            this.MechanismName.ReadOnly = true;
            // 
            // MechanismNumber
            // 
            this.MechanismNumber.DataPropertyName = "MechanismNumber";
            this.MechanismNumber.HeaderText = "机构电话";
            this.MechanismNumber.Name = "MechanismNumber";
            this.MechanismNumber.ReadOnly = true;
            // 
            // MechanismWebsite
            // 
            this.MechanismWebsite.DataPropertyName = "MechanismWebsite";
            this.MechanismWebsite.HeaderText = "机构网站";
            this.MechanismWebsite.Name = "MechanismWebsite";
            this.MechanismWebsite.ReadOnly = true;
            // 
            // MechanismAddress
            // 
            this.MechanismAddress.DataPropertyName = "MechanismAddress";
            this.MechanismAddress.HeaderText = "机构地址";
            this.MechanismAddress.Name = "MechanismAddress";
            this.MechanismAddress.ReadOnly = true;
            // 
            // ContactPeople
            // 
            this.ContactPeople.DataPropertyName = "ContactPeople";
            this.ContactPeople.HeaderText = "联系人";
            this.ContactPeople.Name = "ContactPeople";
            this.ContactPeople.ReadOnly = true;
            // 
            // MechanismContactNumber
            // 
            this.MechanismContactNumber.DataPropertyName = "MechanismContactNumber";
            this.MechanismContactNumber.HeaderText = "联系电话";
            this.MechanismContactNumber.Name = "MechanismContactNumber";
            this.MechanismContactNumber.ReadOnly = true;
            // 
            // TrainingCourseName
            // 
            this.TrainingCourseName.DataPropertyName = "TrainingCourseName";
            this.TrainingCourseName.HeaderText = "培训课程名称";
            this.TrainingCourseName.Name = "TrainingCourseName";
            this.TrainingCourseName.ReadOnly = true;
            this.TrainingCourseName.Width = 140;
            // 
            // TrainingType
            // 
            this.TrainingType.DataPropertyName = "TrainingType";
            this.TrainingType.HeaderText = "培训形式";
            this.TrainingType.Name = "TrainingType";
            this.TrainingType.ReadOnly = true;
            // 
            // TrainingStartTime
            // 
            this.TrainingStartTime.DataPropertyName = "TrainingStartTime";
            this.TrainingStartTime.HeaderText = "开课时间";
            this.TrainingStartTime.Name = "TrainingStartTime";
            this.TrainingStartTime.ReadOnly = true;
            // 
            // TrainingEndTime
            // 
            this.TrainingEndTime.DataPropertyName = "TrainingEndTime";
            this.TrainingEndTime.HeaderText = "结束时间";
            this.TrainingEndTime.Name = "TrainingEndTime";
            this.TrainingEndTime.ReadOnly = true;
            // 
            // TrainingAttendance
            // 
            this.TrainingAttendance.DataPropertyName = "TrainingAttendance";
            this.TrainingAttendance.HeaderText = "培训出勤情况";
            this.TrainingAttendance.Name = "TrainingAttendance";
            this.TrainingAttendance.ReadOnly = true;
            this.TrainingAttendance.Width = 140;
            // 
            // TrainingTestResults
            // 
            this.TrainingTestResults.DataPropertyName = "TrainingTestResults";
            this.TrainingTestResults.HeaderText = "培训考核成绩";
            this.TrainingTestResults.Name = "TrainingTestResults";
            this.TrainingTestResults.ReadOnly = true;
            this.TrainingTestResults.Width = 140;
            // 
            // TrainingTestLevel
            // 
            this.TrainingTestLevel.DataPropertyName = "TrainingTestLevel";
            this.TrainingTestLevel.HeaderText = "培训考核等级";
            this.TrainingTestLevel.Name = "TrainingTestLevel";
            this.TrainingTestLevel.ReadOnly = true;
            this.TrainingTestLevel.Width = 140;
            // 
            // TrainingEvaluation
            // 
            this.TrainingEvaluation.DataPropertyName = "TrainingEvaluation";
            this.TrainingEvaluation.HeaderText = "培训评价";
            this.TrainingEvaluation.Name = "TrainingEvaluation";
            this.TrainingEvaluation.ReadOnly = true;
            // 
            // PEmployeeTest
            // 
            this.PEmployeeTest.Controls.Add(this.dgvTest);
            this.PEmployeeTest.Location = new System.Drawing.Point(4, 26);
            this.PEmployeeTest.Name = "PEmployeeTest";
            this.PEmployeeTest.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeeTest.Size = new System.Drawing.Size(907, 153);
            this.PEmployeeTest.TabIndex = 3;
            this.PEmployeeTest.Tag = "EmployeeTest";
            this.PEmployeeTest.Text = "考核信息";
            this.PEmployeeTest.UseVisualStyleBackColor = true;
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestType,
            this.TestTime,
            this.TestScore,
            this.TestLevel,
            this.TestEvaluation,
            this.EvaluationPeople});
            this.dgvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTest.Location = new System.Drawing.Point(3, 3);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.RowTemplate.Height = 23;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(901, 147);
            this.dgvTest.TabIndex = 3;
            // 
            // TestType
            // 
            this.TestType.DataPropertyName = "TestType";
            this.TestType.HeaderText = "考核类型";
            this.TestType.Name = "TestType";
            this.TestType.ReadOnly = true;
            // 
            // TestTime
            // 
            this.TestTime.DataPropertyName = "TestTime";
            this.TestTime.HeaderText = "考核期间";
            this.TestTime.Name = "TestTime";
            this.TestTime.ReadOnly = true;
            // 
            // TestScore
            // 
            this.TestScore.DataPropertyName = "TestScore";
            this.TestScore.HeaderText = "考核成绩";
            this.TestScore.Name = "TestScore";
            this.TestScore.ReadOnly = true;
            // 
            // TestLevel
            // 
            this.TestLevel.DataPropertyName = "TestLevel";
            this.TestLevel.HeaderText = "考核等级";
            this.TestLevel.Name = "TestLevel";
            this.TestLevel.ReadOnly = true;
            // 
            // TestEvaluation
            // 
            this.TestEvaluation.DataPropertyName = "TestEvaluation";
            this.TestEvaluation.HeaderText = "考核评价";
            this.TestEvaluation.Name = "TestEvaluation";
            this.TestEvaluation.ReadOnly = true;
            // 
            // EvaluationPeople
            // 
            this.EvaluationPeople.DataPropertyName = "EvaluationPeople";
            this.EvaluationPeople.HeaderText = "评价人";
            this.EvaluationPeople.Name = "EvaluationPeople";
            this.EvaluationPeople.ReadOnly = true;
            // 
            // PEmployeeCheck
            // 
            this.PEmployeeCheck.Controls.Add(this.dgvCheck);
            this.PEmployeeCheck.Location = new System.Drawing.Point(4, 26);
            this.PEmployeeCheck.Name = "PEmployeeCheck";
            this.PEmployeeCheck.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeeCheck.Size = new System.Drawing.Size(907, 153);
            this.PEmployeeCheck.TabIndex = 4;
            this.PEmployeeCheck.Tag = "ViewCheck";
            this.PEmployeeCheck.Text = "考勤信息";
            this.PEmployeeCheck.UseVisualStyleBackColor = true;
            // 
            // dgvCheck
            // 
            this.dgvCheck.AllowUserToAddRows = false;
            this.dgvCheck.AllowUserToDeleteRows = false;
            this.dgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveDate,
            this.LeaveReason,
            this.LeaveApprover,
            this.ApprovalComments,
            this.OvertimeHours,
            this.OvertimeReward,
            this.OvertimePeople,
            this.ShouldArriveDays,
            this.ActualDays});
            this.dgvCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheck.Location = new System.Drawing.Point(3, 3);
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.ReadOnly = true;
            this.dgvCheck.RowTemplate.Height = 23;
            this.dgvCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheck.Size = new System.Drawing.Size(901, 147);
            this.dgvCheck.TabIndex = 4;
            // 
            // LeaveDate
            // 
            this.LeaveDate.DataPropertyName = "LeaveDate";
            this.LeaveDate.HeaderText = "请假日期";
            this.LeaveDate.Name = "LeaveDate";
            this.LeaveDate.ReadOnly = true;
            // 
            // LeaveReason
            // 
            this.LeaveReason.DataPropertyName = "LeaveReason";
            this.LeaveReason.HeaderText = "请假事由";
            this.LeaveReason.Name = "LeaveReason";
            this.LeaveReason.ReadOnly = true;
            // 
            // LeaveApprover
            // 
            this.LeaveApprover.DataPropertyName = "LeaveApprover";
            this.LeaveApprover.HeaderText = "审批人";
            this.LeaveApprover.Name = "LeaveApprover";
            this.LeaveApprover.ReadOnly = true;
            // 
            // ApprovalComments
            // 
            this.ApprovalComments.DataPropertyName = "ApprovalComments";
            this.ApprovalComments.HeaderText = "审批意见";
            this.ApprovalComments.Name = "ApprovalComments";
            this.ApprovalComments.ReadOnly = true;
            // 
            // OvertimeHours
            // 
            this.OvertimeHours.DataPropertyName = "OvertimeHours";
            this.OvertimeHours.HeaderText = "加班时长";
            this.OvertimeHours.Name = "OvertimeHours";
            this.OvertimeHours.ReadOnly = true;
            // 
            // OvertimeReward
            // 
            this.OvertimeReward.DataPropertyName = "OvertimeReward";
            this.OvertimeReward.HeaderText = "加班报酬";
            this.OvertimeReward.Name = "OvertimeReward";
            this.OvertimeReward.ReadOnly = true;
            // 
            // OvertimePeople
            // 
            this.OvertimePeople.DataPropertyName = "OvertimePeople";
            this.OvertimePeople.HeaderText = "审核人";
            this.OvertimePeople.Name = "OvertimePeople";
            this.OvertimePeople.ReadOnly = true;
            // 
            // ShouldArriveDays
            // 
            this.ShouldArriveDays.DataPropertyName = "ShouldArriveDays";
            this.ShouldArriveDays.HeaderText = "应到天数";
            this.ShouldArriveDays.Name = "ShouldArriveDays";
            this.ShouldArriveDays.ReadOnly = true;
            // 
            // ActualDays
            // 
            this.ActualDays.DataPropertyName = "ActualDays";
            this.ActualDays.HeaderText = "实到天数";
            this.ActualDays.Name = "ActualDays";
            this.ActualDays.ReadOnly = true;
            // 
            // PEmployeePay
            // 
            this.PEmployeePay.Controls.Add(this.dgvPay);
            this.PEmployeePay.Location = new System.Drawing.Point(4, 26);
            this.PEmployeePay.Name = "PEmployeePay";
            this.PEmployeePay.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeePay.Size = new System.Drawing.Size(907, 153);
            this.PEmployeePay.TabIndex = 5;
            this.PEmployeePay.Tag = "ViewPay";
            this.PEmployeePay.Text = "工资信息";
            this.PEmployeePay.UseVisualStyleBackColor = true;
            // 
            // dgvPay
            // 
            this.dgvPay.AllowUserToAddRows = false;
            this.dgvPay.AllowUserToDeleteRows = false;
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShouldPay,
            this.ActualPay});
            this.dgvPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPay.Location = new System.Drawing.Point(3, 3);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.ReadOnly = true;
            this.dgvPay.RowTemplate.Height = 23;
            this.dgvPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPay.Size = new System.Drawing.Size(901, 147);
            this.dgvPay.TabIndex = 5;
            // 
            // ShouldPay
            // 
            this.ShouldPay.DataPropertyName = "ShouldPay";
            this.ShouldPay.HeaderText = "应发工资";
            this.ShouldPay.Name = "ShouldPay";
            this.ShouldPay.ReadOnly = true;
            // 
            // ActualPay
            // 
            this.ActualPay.DataPropertyName = "ActualPay";
            this.ActualPay.HeaderText = "实发工资";
            this.ActualPay.Name = "ActualPay";
            this.ActualPay.ReadOnly = true;
            // 
            // PEmployeeInsurance
            // 
            this.PEmployeeInsurance.Controls.Add(this.dgvInsurance);
            this.PEmployeeInsurance.Location = new System.Drawing.Point(4, 26);
            this.PEmployeeInsurance.Name = "PEmployeeInsurance";
            this.PEmployeeInsurance.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeeInsurance.Size = new System.Drawing.Size(907, 153);
            this.PEmployeeInsurance.TabIndex = 6;
            this.PEmployeeInsurance.Tag = "EmployeeInsurance";
            this.PEmployeeInsurance.Text = "保险信息";
            this.PEmployeeInsurance.UseVisualStyleBackColor = true;
            // 
            // dgvInsurance
            // 
            this.dgvInsurance.AllowUserToAddRows = false;
            this.dgvInsurance.AllowUserToDeleteRows = false;
            this.dgvInsurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InsuranceDate,
            this.ExpirationDate,
            this.EndowmentInsurance,
            this.MedicalInsurance,
            this.UnemploymentInsurance,
            this.MaternityInsurance,
            this.InjuryInsurance,
            this.HousingProvidentFund});
            this.dgvInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsurance.Location = new System.Drawing.Point(3, 3);
            this.dgvInsurance.Name = "dgvInsurance";
            this.dgvInsurance.ReadOnly = true;
            this.dgvInsurance.RowTemplate.Height = 23;
            this.dgvInsurance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsurance.Size = new System.Drawing.Size(901, 147);
            this.dgvInsurance.TabIndex = 6;
            // 
            // InsuranceDate
            // 
            this.InsuranceDate.DataPropertyName = "InsuranceDate";
            this.InsuranceDate.HeaderText = "投保日期";
            this.InsuranceDate.Name = "InsuranceDate";
            this.InsuranceDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "到期日期";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // EndowmentInsurance
            // 
            this.EndowmentInsurance.DataPropertyName = "EndowmentInsurance";
            this.EndowmentInsurance.HeaderText = "养老保险";
            this.EndowmentInsurance.Name = "EndowmentInsurance";
            this.EndowmentInsurance.ReadOnly = true;
            // 
            // MedicalInsurance
            // 
            this.MedicalInsurance.DataPropertyName = "MedicalInsurance";
            this.MedicalInsurance.HeaderText = "医疗保险";
            this.MedicalInsurance.Name = "MedicalInsurance";
            this.MedicalInsurance.ReadOnly = true;
            // 
            // UnemploymentInsurance
            // 
            this.UnemploymentInsurance.DataPropertyName = "UnemploymentInsurance";
            this.UnemploymentInsurance.HeaderText = "失业保险";
            this.UnemploymentInsurance.Name = "UnemploymentInsurance";
            this.UnemploymentInsurance.ReadOnly = true;
            // 
            // MaternityInsurance
            // 
            this.MaternityInsurance.DataPropertyName = "MaternityInsurance";
            this.MaternityInsurance.HeaderText = "生育保险";
            this.MaternityInsurance.Name = "MaternityInsurance";
            this.MaternityInsurance.ReadOnly = true;
            // 
            // InjuryInsurance
            // 
            this.InjuryInsurance.DataPropertyName = "InjuryInsurance";
            this.InjuryInsurance.HeaderText = "工伤保险";
            this.InjuryInsurance.Name = "InjuryInsurance";
            this.InjuryInsurance.ReadOnly = true;
            // 
            // HousingProvidentFund
            // 
            this.HousingProvidentFund.DataPropertyName = "HousingProvidentFund";
            this.HousingProvidentFund.HeaderText = "住房公积金";
            this.HousingProvidentFund.Name = "HousingProvidentFund";
            this.HousingProvidentFund.ReadOnly = true;
            this.HousingProvidentFund.Width = 120;
            // 
            // PEmployeeWelfare
            // 
            this.PEmployeeWelfare.Controls.Add(this.dgvWelfare);
            this.PEmployeeWelfare.Location = new System.Drawing.Point(4, 26);
            this.PEmployeeWelfare.Name = "PEmployeeWelfare";
            this.PEmployeeWelfare.Padding = new System.Windows.Forms.Padding(3);
            this.PEmployeeWelfare.Size = new System.Drawing.Size(907, 153);
            this.PEmployeeWelfare.TabIndex = 7;
            this.PEmployeeWelfare.Tag = "EmployeeWelfare";
            this.PEmployeeWelfare.Text = "福利信息";
            this.PEmployeeWelfare.UseVisualStyleBackColor = true;
            // 
            // dgvWelfare
            // 
            this.dgvWelfare.AllowUserToAddRows = false;
            this.dgvWelfare.AllowUserToDeleteRows = false;
            this.dgvWelfare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWelfare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WelfareProject,
            this.WelfareItems,
            this.WelfareAmount});
            this.dgvWelfare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWelfare.Location = new System.Drawing.Point(3, 3);
            this.dgvWelfare.Name = "dgvWelfare";
            this.dgvWelfare.ReadOnly = true;
            this.dgvWelfare.RowTemplate.Height = 23;
            this.dgvWelfare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWelfare.Size = new System.Drawing.Size(901, 147);
            this.dgvWelfare.TabIndex = 7;
            // 
            // WelfareProject
            // 
            this.WelfareProject.DataPropertyName = "WelfareProject";
            this.WelfareProject.HeaderText = "福利项目";
            this.WelfareProject.Name = "WelfareProject";
            this.WelfareProject.ReadOnly = true;
            // 
            // WelfareItems
            // 
            this.WelfareItems.DataPropertyName = "WelfareItems";
            this.WelfareItems.HeaderText = "福利物品";
            this.WelfareItems.Name = "WelfareItems";
            this.WelfareItems.ReadOnly = true;
            // 
            // WelfareAmount
            // 
            this.WelfareAmount.DataPropertyName = "WelfareAmount";
            this.WelfareAmount.HeaderText = "福利金额";
            this.WelfareAmount.Name = "WelfareAmount";
            this.WelfareAmount.ReadOnly = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitch.Location = new System.Drawing.Point(791, 9);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(87, 27);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "切换用户";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 656);
            this.Controls.Add(this.dgvEmployeeInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎进入员工界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployee_FormClosing);
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tctl.ResumeLayout(false);
            this.PEmployeeContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.PEmployeeReward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewardandPunishment)).EndInit();
            this.PEmployeeTraining.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.PEmployeeTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.PEmployeeCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            this.PEmployeePay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.PEmployeeInsurance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).EndInit();
            this.PEmployeeWelfare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWelfare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tctl;
        private System.Windows.Forms.TabPage PEmployeeContract;
        private System.Windows.Forms.TabPage PEmployeeReward;
        private System.Windows.Forms.TabPage PEmployeeTraining;
        private System.Windows.Forms.TabPage PEmployeeTest;
        private System.Windows.Forms.TabPage PEmployeeCheck;
        private System.Windows.Forms.TabPage PEmployeePay;
        private System.Windows.Forms.TabPage PEmployeeInsurance;
        private System.Windows.Forms.TabPage PEmployeeWelfare;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.DataGridView dgvRewardandPunishment;
        private System.Windows.Forms.DataGridView dgvTraining;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.DataGridView dgvInsurance;
        private System.Windows.Forms.DataGridView dgvWelfare;
        private System.Windows.Forms.Button btnModifyPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn NativePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ethnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoliticalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn GraduatedSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormerPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyPoliticalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyWorkPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relieve;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelieveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractState;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardandPunishmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardandPunishmentProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardandPunishmentAttribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardandPunishmentMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingTestResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingTestLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveApprover;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn OvertimeHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn OvertimeReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn OvertimePeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShouldArriveDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShouldPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndowmentInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnemploymentInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaternityInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn InjuryInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn HousingProvidentFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn WelfareProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn WelfareItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn WelfareAmount;
        private System.Windows.Forms.Button btnSwitch;
    }
}

