namespace HRManage
{
    partial class FormAdmin
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("人事部");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("财务部");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("销售部");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("研发部");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("技术部");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("售后服务部");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("公司部门", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.tvDepartment = new System.Windows.Forms.TreeView();
            this.dgvAdminEmployeeInfo = new System.Windows.Forms.DataGridView();
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
            this.tctl = new System.Windows.Forms.TabControl();
            this.EmployeeTransfer = new System.Windows.Forms.TabPage();
            this.dgvTransfer = new System.Windows.Forms.DataGridView();
            this.CurrentDepartment1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentAdministrativeLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalAdministrativeLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTitle = new System.Windows.Forms.TabPage();
            this.dgvTitle = new System.Windows.Forms.DataGridView();
            this.OriginalTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquireWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeQuit = new System.Windows.Forms.TabPage();
            this.dgvQuit = new System.Windows.Forms.DataGridView();
            this.QuitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuitTpye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WageCutOffTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeReinstate = new System.Windows.Forms.TabPage();
            this.dgvReinstatement = new System.Windows.Forms.DataGridView();
            this.Reinstatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReinstatementTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReinstatementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReinstatementDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeContract = new System.Windows.Forms.TabPage();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relieve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelieveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeReward = new System.Windows.Forms.TabPage();
            this.dgvRewardandPunishment = new System.Windows.Forms.DataGridView();
            this.RewardandPunishmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardandPunishmentProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardandPunishmentAttribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardandPunishmentMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTest = new System.Windows.Forms.TabPage();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.TestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCheck = new System.Windows.Forms.TabPage();
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
            this.EmployeePay = new System.Windows.Forms.TabPage();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.ShouldPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeInsurance = new System.Windows.Forms.TabPage();
            this.dgvInsurance = new System.Windows.Forms.DataGridView();
            this.InsuranceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndowmentInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnemploymentInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaternityInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InjuryInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HousingProvidentFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeWelfare = new System.Windows.Forms.TabPage();
            this.dgvWelfare = new System.Windows.Forms.DataGridView();
            this.WelfareProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WelfareItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WelfareAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTraining = new System.Windows.Forms.TabPage();
            this.dgvTrainingDepartment = new System.Windows.Forms.DataGridView();
            this.MechanismID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanismContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTraining2 = new System.Windows.Forms.TabPage();
            this.dgvTrainingCourse = new System.Windows.Forms.DataGridView();
            this.TrainingCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTraining3 = new System.Windows.Forms.TabPage();
            this.dgvTrainingRecord = new System.Windows.Forms.DataGridView();
            this.HostDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingTestResults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingTestLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.lblModify = new System.Windows.Forms.Label();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.lblDel = new System.Windows.Forms.Label();
            this.pnlExport = new System.Windows.Forms.Panel();
            this.lblExport = new System.Windows.Forms.Label();
            this.pnlQuit = new System.Windows.Forms.Panel();
            this.lblQuit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAddInfo = new System.Windows.Forms.Label();
            this.pnlAddInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSkin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminEmployeeInfo)).BeginInit();
            this.tctl.SuspendLayout();
            this.EmployeeTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfer)).BeginInit();
            this.EmployeeTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).BeginInit();
            this.EmployeeQuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuit)).BeginInit();
            this.EmployeeReinstate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReinstatement)).BeginInit();
            this.EmployeeContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.EmployeeReward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewardandPunishment)).BeginInit();
            this.EmployeeTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.EmployeeCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            this.EmployeePay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.EmployeeInsurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).BeginInit();
            this.EmployeeWelfare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWelfare)).BeginInit();
            this.EmployeeTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingDepartment)).BeginInit();
            this.EmployeeTraining2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingCourse)).BeginInit();
            this.EmployeeTraining3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingRecord)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDepartment
            // 
            this.tvDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvDepartment.Location = new System.Drawing.Point(0, 0);
            this.tvDepartment.MinimumSize = new System.Drawing.Size(186, 349);
            this.tvDepartment.Name = "tvDepartment";
            treeNode1.Name = "Child1";
            treeNode1.Text = "人事部";
            treeNode2.Name = "Child2";
            treeNode2.Text = "财务部";
            treeNode3.Name = "Child3";
            treeNode3.Text = "销售部";
            treeNode4.Name = "Child4";
            treeNode4.Text = "研发部";
            treeNode5.Name = "Child5";
            treeNode5.Text = "技术部";
            treeNode6.Name = "Child6";
            treeNode6.Text = "售后服务部";
            treeNode7.Name = "Father";
            treeNode7.Text = "公司部门";
            this.tvDepartment.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.tvDepartment.Size = new System.Drawing.Size(186, 349);
            this.tvDepartment.TabIndex = 1;
            this.tvDepartment.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDepartment_NodeMouseClick);
            this.tvDepartment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvDepartment_MouseDown);
            // 
            // dgvAdminEmployeeInfo
            // 
            this.dgvAdminEmployeeInfo.AllowUserToAddRows = false;
            this.dgvAdminEmployeeInfo.AllowUserToDeleteRows = false;
            this.dgvAdminEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvAdminEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminEmployeeInfo.Location = new System.Drawing.Point(186, 0);
            this.dgvAdminEmployeeInfo.Name = "dgvAdminEmployeeInfo";
            this.dgvAdminEmployeeInfo.ReadOnly = true;
            this.dgvAdminEmployeeInfo.RowTemplate.Height = 23;
            this.dgvAdminEmployeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminEmployeeInfo.Size = new System.Drawing.Size(990, 334);
            this.dgvAdminEmployeeInfo.TabIndex = 0;
            this.dgvAdminEmployeeInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminEmployeeInfo_CellDoubleClick);
            this.dgvAdminEmployeeInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvAdminEmployeeInfo_RowPostPaint);
            this.dgvAdminEmployeeInfo.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAdminEmployeeInfo_RowsRemoved);
            this.dgvAdminEmployeeInfo.SelectionChanged += new System.EventHandler(this.dgvAdminEmployeeInfo_SelectionChanged);
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
            this.FamilyBirthDate.HeaderText = "出生日期(家人)";
            this.FamilyBirthDate.Name = "FamilyBirthDate";
            this.FamilyBirthDate.ReadOnly = true;
            this.FamilyBirthDate.Width = 120;
            // 
            // FamilyPoliticalStatus
            // 
            this.FamilyPoliticalStatus.DataPropertyName = "FamilyPoliticalStatus";
            this.FamilyPoliticalStatus.HeaderText = "政治面貌(家人)";
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
            this.FamilyNumber.HeaderText = "联系方式(家人)";
            this.FamilyNumber.Name = "FamilyNumber";
            this.FamilyNumber.ReadOnly = true;
            this.FamilyNumber.Width = 130;
            // 
            // tctl
            // 
            this.tctl.Controls.Add(this.EmployeeTransfer);
            this.tctl.Controls.Add(this.EmployeeTitle);
            this.tctl.Controls.Add(this.EmployeeQuit);
            this.tctl.Controls.Add(this.EmployeeReinstate);
            this.tctl.Controls.Add(this.EmployeeContract);
            this.tctl.Controls.Add(this.EmployeeReward);
            this.tctl.Controls.Add(this.EmployeeTest);
            this.tctl.Controls.Add(this.EmployeeCheck);
            this.tctl.Controls.Add(this.EmployeePay);
            this.tctl.Controls.Add(this.EmployeeInsurance);
            this.tctl.Controls.Add(this.EmployeeWelfare);
            this.tctl.Controls.Add(this.EmployeeTraining);
            this.tctl.Controls.Add(this.EmployeeTraining2);
            this.tctl.Controls.Add(this.EmployeeTraining3);
            this.tctl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctl.Location = new System.Drawing.Point(0, 0);
            this.tctl.Name = "tctl";
            this.tctl.SelectedIndex = 0;
            this.tctl.Size = new System.Drawing.Size(1176, 168);
            this.tctl.TabIndex = 4;
            this.tctl.SelectedIndexChanged += new System.EventHandler(this.tctl_SelectedIndexChanged);
            // 
            // EmployeeTransfer
            // 
            this.EmployeeTransfer.Controls.Add(this.dgvTransfer);
            this.EmployeeTransfer.Location = new System.Drawing.Point(4, 23);
            this.EmployeeTransfer.Name = "EmployeeTransfer";
            this.EmployeeTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTransfer.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeTransfer.TabIndex = 1;
            this.EmployeeTransfer.Tag = "EmployeeTransfer";
            this.EmployeeTransfer.Text = "人事调动";
            this.EmployeeTransfer.UseVisualStyleBackColor = true;
            // 
            // dgvTransfer
            // 
            this.dgvTransfer.AllowUserToAddRows = false;
            this.dgvTransfer.AllowUserToDeleteRows = false;
            this.dgvTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrentDepartment1,
            this.OriginalDepartment,
            this.CurrentPosition,
            this.OriginalPosition,
            this.CurrentWorkType,
            this.OriginalWorkType,
            this.CurrentAdministrativeLevel,
            this.OriginalAdministrativeLevel,
            this.TransferType,
            this.TransferTime});
            this.dgvTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransfer.Location = new System.Drawing.Point(3, 3);
            this.dgvTransfer.Name = "dgvTransfer";
            this.dgvTransfer.ReadOnly = true;
            this.dgvTransfer.RowTemplate.Height = 23;
            this.dgvTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransfer.Size = new System.Drawing.Size(1162, 135);
            this.dgvTransfer.TabIndex = 1;
            // 
            // CurrentDepartment1
            // 
            this.CurrentDepartment1.DataPropertyName = "CurrentDepartment1";
            this.CurrentDepartment1.HeaderText = "现部门";
            this.CurrentDepartment1.Name = "CurrentDepartment1";
            this.CurrentDepartment1.ReadOnly = true;
            // 
            // OriginalDepartment
            // 
            this.OriginalDepartment.DataPropertyName = "OriginalDepartment";
            this.OriginalDepartment.HeaderText = "原部门";
            this.OriginalDepartment.Name = "OriginalDepartment";
            this.OriginalDepartment.ReadOnly = true;
            // 
            // CurrentPosition
            // 
            this.CurrentPosition.DataPropertyName = "CurrentPosition";
            this.CurrentPosition.HeaderText = "现职务";
            this.CurrentPosition.Name = "CurrentPosition";
            this.CurrentPosition.ReadOnly = true;
            this.CurrentPosition.Width = 80;
            // 
            // OriginalPosition
            // 
            this.OriginalPosition.DataPropertyName = "OriginalPosition";
            this.OriginalPosition.HeaderText = "原职务";
            this.OriginalPosition.Name = "OriginalPosition";
            this.OriginalPosition.ReadOnly = true;
            this.OriginalPosition.Width = 80;
            // 
            // CurrentWorkType
            // 
            this.CurrentWorkType.DataPropertyName = "CurrentWorkType";
            this.CurrentWorkType.HeaderText = "现工种";
            this.CurrentWorkType.Name = "CurrentWorkType";
            this.CurrentWorkType.ReadOnly = true;
            this.CurrentWorkType.Width = 80;
            // 
            // OriginalWorkType
            // 
            this.OriginalWorkType.DataPropertyName = "OriginalWorkType";
            this.OriginalWorkType.HeaderText = "原工种";
            this.OriginalWorkType.Name = "OriginalWorkType";
            this.OriginalWorkType.ReadOnly = true;
            this.OriginalWorkType.Width = 80;
            // 
            // CurrentAdministrativeLevel
            // 
            this.CurrentAdministrativeLevel.DataPropertyName = "CurrentAdministrativeLevel";
            this.CurrentAdministrativeLevel.HeaderText = "现行政等级";
            this.CurrentAdministrativeLevel.Name = "CurrentAdministrativeLevel";
            this.CurrentAdministrativeLevel.ReadOnly = true;
            // 
            // OriginalAdministrativeLevel
            // 
            this.OriginalAdministrativeLevel.DataPropertyName = "OriginalAdministrativeLevel";
            this.OriginalAdministrativeLevel.HeaderText = "原行政等级";
            this.OriginalAdministrativeLevel.Name = "OriginalAdministrativeLevel";
            this.OriginalAdministrativeLevel.ReadOnly = true;
            // 
            // TransferType
            // 
            this.TransferType.DataPropertyName = "TransferType";
            this.TransferType.HeaderText = "调动类型";
            this.TransferType.Name = "TransferType";
            this.TransferType.ReadOnly = true;
            this.TransferType.Width = 80;
            // 
            // TransferTime
            // 
            this.TransferTime.DataPropertyName = "TransferTime";
            this.TransferTime.HeaderText = "调动时间";
            this.TransferTime.Name = "TransferTime";
            this.TransferTime.ReadOnly = true;
            this.TransferTime.Width = 80;
            // 
            // EmployeeTitle
            // 
            this.EmployeeTitle.Controls.Add(this.dgvTitle);
            this.EmployeeTitle.Location = new System.Drawing.Point(4, 23);
            this.EmployeeTitle.Name = "EmployeeTitle";
            this.EmployeeTitle.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTitle.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeTitle.TabIndex = 2;
            this.EmployeeTitle.Tag = "ViewTitle";
            this.EmployeeTitle.Text = "职称评定";
            this.EmployeeTitle.UseVisualStyleBackColor = true;
            // 
            // dgvTitle
            // 
            this.dgvTitle.AllowUserToAddRows = false;
            this.dgvTitle.AllowUserToDeleteRows = false;
            this.dgvTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalTitle,
            this.CurrentTitle,
            this.AcquireWay,
            this.AcquireTime,
            this.Approver});
            this.dgvTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTitle.Location = new System.Drawing.Point(3, 3);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.ReadOnly = true;
            this.dgvTitle.RowTemplate.Height = 23;
            this.dgvTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitle.Size = new System.Drawing.Size(1162, 135);
            this.dgvTitle.TabIndex = 2;
            // 
            // OriginalTitle
            // 
            this.OriginalTitle.DataPropertyName = "OriginalTitle";
            this.OriginalTitle.HeaderText = "原职称";
            this.OriginalTitle.Name = "OriginalTitle";
            this.OriginalTitle.ReadOnly = true;
            // 
            // CurrentTitle
            // 
            this.CurrentTitle.DataPropertyName = "CurrentTitle";
            this.CurrentTitle.HeaderText = "现职称";
            this.CurrentTitle.Name = "CurrentTitle";
            this.CurrentTitle.ReadOnly = true;
            // 
            // AcquireWay
            // 
            this.AcquireWay.DataPropertyName = "AcquireWay";
            this.AcquireWay.HeaderText = "取得方式";
            this.AcquireWay.Name = "AcquireWay";
            this.AcquireWay.ReadOnly = true;
            // 
            // AcquireTime
            // 
            this.AcquireTime.DataPropertyName = "AcquireTime";
            this.AcquireTime.HeaderText = "取得时间";
            this.AcquireTime.Name = "AcquireTime";
            this.AcquireTime.ReadOnly = true;
            // 
            // Approver
            // 
            this.Approver.DataPropertyName = "Approver";
            this.Approver.HeaderText = "批准人";
            this.Approver.Name = "Approver";
            this.Approver.ReadOnly = true;
            // 
            // EmployeeQuit
            // 
            this.EmployeeQuit.Controls.Add(this.dgvQuit);
            this.EmployeeQuit.Location = new System.Drawing.Point(4, 23);
            this.EmployeeQuit.Name = "EmployeeQuit";
            this.EmployeeQuit.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeQuit.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeQuit.TabIndex = 3;
            this.EmployeeQuit.Tag = "ViewQuit";
            this.EmployeeQuit.Text = "离职管理";
            this.EmployeeQuit.UseVisualStyleBackColor = true;
            // 
            // dgvQuit
            // 
            this.dgvQuit.AllowUserToAddRows = false;
            this.dgvQuit.AllowUserToDeleteRows = false;
            this.dgvQuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuitTime,
            this.QuitTpye,
            this.WageCutOffTime,
            this.QuitDescription});
            this.dgvQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuit.Location = new System.Drawing.Point(3, 3);
            this.dgvQuit.Name = "dgvQuit";
            this.dgvQuit.ReadOnly = true;
            this.dgvQuit.RowTemplate.Height = 23;
            this.dgvQuit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuit.Size = new System.Drawing.Size(1162, 135);
            this.dgvQuit.TabIndex = 3;
            // 
            // QuitTime
            // 
            this.QuitTime.DataPropertyName = "QuitTime";
            this.QuitTime.HeaderText = "离职时间";
            this.QuitTime.Name = "QuitTime";
            this.QuitTime.ReadOnly = true;
            this.QuitTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // QuitTpye
            // 
            this.QuitTpye.DataPropertyName = "QuitTpye";
            this.QuitTpye.HeaderText = "离职类型";
            this.QuitTpye.Name = "QuitTpye";
            this.QuitTpye.ReadOnly = true;
            // 
            // WageCutOffTime
            // 
            this.WageCutOffTime.DataPropertyName = "WageCutOffTime";
            this.WageCutOffTime.HeaderText = "工资截止时间";
            this.WageCutOffTime.Name = "WageCutOffTime";
            this.WageCutOffTime.ReadOnly = true;
            this.WageCutOffTime.Width = 120;
            // 
            // QuitDescription
            // 
            this.QuitDescription.DataPropertyName = "QuitDescription";
            this.QuitDescription.HeaderText = "离职说明";
            this.QuitDescription.Name = "QuitDescription";
            this.QuitDescription.ReadOnly = true;
            // 
            // EmployeeReinstate
            // 
            this.EmployeeReinstate.Controls.Add(this.dgvReinstatement);
            this.EmployeeReinstate.Location = new System.Drawing.Point(4, 23);
            this.EmployeeReinstate.Name = "EmployeeReinstate";
            this.EmployeeReinstate.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeReinstate.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeReinstate.TabIndex = 4;
            this.EmployeeReinstate.Tag = "ViewState";
            this.EmployeeReinstate.Text = "复职管理";
            this.EmployeeReinstate.UseVisualStyleBackColor = true;
            // 
            // dgvReinstatement
            // 
            this.dgvReinstatement.AllowUserToAddRows = false;
            this.dgvReinstatement.AllowUserToDeleteRows = false;
            this.dgvReinstatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReinstatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reinstatement,
            this.ReinstatementTime,
            this.ReinstatementType,
            this.ReinstatementDescription});
            this.dgvReinstatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReinstatement.Location = new System.Drawing.Point(3, 3);
            this.dgvReinstatement.Name = "dgvReinstatement";
            this.dgvReinstatement.ReadOnly = true;
            this.dgvReinstatement.RowTemplate.Height = 23;
            this.dgvReinstatement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReinstatement.Size = new System.Drawing.Size(1162, 135);
            this.dgvReinstatement.TabIndex = 4;
            // 
            // Reinstatement
            // 
            this.Reinstatement.DataPropertyName = "Reinstatement";
            this.Reinstatement.HeaderText = "是否复职";
            this.Reinstatement.Name = "Reinstatement";
            this.Reinstatement.ReadOnly = true;
            // 
            // ReinstatementTime
            // 
            this.ReinstatementTime.DataPropertyName = "ReinstatementTime";
            this.ReinstatementTime.HeaderText = "复职时间";
            this.ReinstatementTime.Name = "ReinstatementTime";
            this.ReinstatementTime.ReadOnly = true;
            // 
            // ReinstatementType
            // 
            this.ReinstatementType.DataPropertyName = "ReinstatementType";
            this.ReinstatementType.HeaderText = "复职类型";
            this.ReinstatementType.Name = "ReinstatementType";
            this.ReinstatementType.ReadOnly = true;
            // 
            // ReinstatementDescription
            // 
            this.ReinstatementDescription.DataPropertyName = "ReinstatementDescription";
            this.ReinstatementDescription.HeaderText = "复职说明";
            this.ReinstatementDescription.Name = "ReinstatementDescription";
            this.ReinstatementDescription.ReadOnly = true;
            // 
            // EmployeeContract
            // 
            this.EmployeeContract.Controls.Add(this.dgvContract);
            this.EmployeeContract.Location = new System.Drawing.Point(4, 23);
            this.EmployeeContract.Name = "EmployeeContract";
            this.EmployeeContract.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeContract.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeContract.TabIndex = 5;
            this.EmployeeContract.Tag = "EmployeeContract";
            this.EmployeeContract.Text = "合同管理";
            this.EmployeeContract.UseVisualStyleBackColor = true;
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
            this.dgvContract.Size = new System.Drawing.Size(1162, 135);
            this.dgvContract.TabIndex = 5;
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
            // EmployeeReward
            // 
            this.EmployeeReward.Controls.Add(this.dgvRewardandPunishment);
            this.EmployeeReward.Location = new System.Drawing.Point(4, 23);
            this.EmployeeReward.Name = "EmployeeReward";
            this.EmployeeReward.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeReward.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeReward.TabIndex = 6;
            this.EmployeeReward.Tag = "ViewReward";
            this.EmployeeReward.Text = "奖惩管理";
            this.EmployeeReward.UseVisualStyleBackColor = true;
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
            this.dgvRewardandPunishment.Size = new System.Drawing.Size(1162, 135);
            this.dgvRewardandPunishment.TabIndex = 6;
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
            // EmployeeTest
            // 
            this.EmployeeTest.Controls.Add(this.dgvTest);
            this.EmployeeTest.Location = new System.Drawing.Point(4, 23);
            this.EmployeeTest.Name = "EmployeeTest";
            this.EmployeeTest.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTest.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeTest.TabIndex = 7;
            this.EmployeeTest.Tag = "EmployeeTest";
            this.EmployeeTest.Text = "考核管理";
            this.EmployeeTest.UseVisualStyleBackColor = true;
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
            this.dgvTest.Size = new System.Drawing.Size(1162, 135);
            this.dgvTest.TabIndex = 7;
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
            // EmployeeCheck
            // 
            this.EmployeeCheck.Controls.Add(this.dgvCheck);
            this.EmployeeCheck.Location = new System.Drawing.Point(4, 23);
            this.EmployeeCheck.Name = "EmployeeCheck";
            this.EmployeeCheck.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeCheck.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeCheck.TabIndex = 8;
            this.EmployeeCheck.Tag = "ViewCheck";
            this.EmployeeCheck.Text = "考勤管理";
            this.EmployeeCheck.UseVisualStyleBackColor = true;
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
            this.dgvCheck.Size = new System.Drawing.Size(1162, 135);
            this.dgvCheck.TabIndex = 8;
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
            // EmployeePay
            // 
            this.EmployeePay.Controls.Add(this.dgvPay);
            this.EmployeePay.Location = new System.Drawing.Point(4, 23);
            this.EmployeePay.Name = "EmployeePay";
            this.EmployeePay.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeePay.Size = new System.Drawing.Size(1168, 141);
            this.EmployeePay.TabIndex = 9;
            this.EmployeePay.Tag = "ViewPay";
            this.EmployeePay.Text = "工资管理";
            this.EmployeePay.UseVisualStyleBackColor = true;
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
            this.dgvPay.Size = new System.Drawing.Size(1162, 135);
            this.dgvPay.TabIndex = 9;
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
            // EmployeeInsurance
            // 
            this.EmployeeInsurance.Controls.Add(this.dgvInsurance);
            this.EmployeeInsurance.Location = new System.Drawing.Point(4, 23);
            this.EmployeeInsurance.Name = "EmployeeInsurance";
            this.EmployeeInsurance.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeInsurance.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeInsurance.TabIndex = 10;
            this.EmployeeInsurance.Tag = "EmployeeInsurance";
            this.EmployeeInsurance.Text = "保险管理";
            this.EmployeeInsurance.UseVisualStyleBackColor = true;
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
            this.dgvInsurance.Size = new System.Drawing.Size(1162, 135);
            this.dgvInsurance.TabIndex = 10;
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
            // 
            // EmployeeWelfare
            // 
            this.EmployeeWelfare.Controls.Add(this.dgvWelfare);
            this.EmployeeWelfare.Location = new System.Drawing.Point(4, 23);
            this.EmployeeWelfare.Name = "EmployeeWelfare";
            this.EmployeeWelfare.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeWelfare.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeWelfare.TabIndex = 11;
            this.EmployeeWelfare.Tag = "EmployeeWelfare";
            this.EmployeeWelfare.Text = "福利管理";
            this.EmployeeWelfare.UseVisualStyleBackColor = true;
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
            this.dgvWelfare.Size = new System.Drawing.Size(1162, 135);
            this.dgvWelfare.TabIndex = 11;
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
            // EmployeeTraining
            // 
            this.EmployeeTraining.Controls.Add(this.dgvTrainingDepartment);
            this.EmployeeTraining.Location = new System.Drawing.Point(4, 23);
            this.EmployeeTraining.Name = "EmployeeTraining";
            this.EmployeeTraining.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTraining.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeTraining.TabIndex = 12;
            this.EmployeeTraining.Tag = "EmployeeTraining";
            this.EmployeeTraining.Text = "培训机构";
            this.EmployeeTraining.UseVisualStyleBackColor = true;
            // 
            // dgvTrainingDepartment
            // 
            this.dgvTrainingDepartment.AllowUserToAddRows = false;
            this.dgvTrainingDepartment.AllowUserToDeleteRows = false;
            this.dgvTrainingDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MechanismID,
            this.MechanismName,
            this.MechanismType,
            this.MechanismNumber,
            this.MechanismWebsite,
            this.MechanismAddress,
            this.ContactPeople,
            this.MechanismContactNumber,
            this.ContactMail});
            this.dgvTrainingDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainingDepartment.Location = new System.Drawing.Point(3, 3);
            this.dgvTrainingDepartment.Name = "dgvTrainingDepartment";
            this.dgvTrainingDepartment.ReadOnly = true;
            this.dgvTrainingDepartment.RowTemplate.Height = 23;
            this.dgvTrainingDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainingDepartment.Size = new System.Drawing.Size(1162, 135);
            this.dgvTrainingDepartment.TabIndex = 11;
            // 
            // MechanismID
            // 
            this.MechanismID.DataPropertyName = "MechanismID";
            this.MechanismID.HeaderText = "机构编号";
            this.MechanismID.Name = "MechanismID";
            this.MechanismID.ReadOnly = true;
            // 
            // MechanismName
            // 
            this.MechanismName.DataPropertyName = "MechanismName";
            this.MechanismName.HeaderText = "机构名称";
            this.MechanismName.Name = "MechanismName";
            this.MechanismName.ReadOnly = true;
            // 
            // MechanismType
            // 
            this.MechanismType.DataPropertyName = "MechanismType";
            this.MechanismType.HeaderText = "机构类型";
            this.MechanismType.Name = "MechanismType";
            this.MechanismType.ReadOnly = true;
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
            this.MechanismContactNumber.HeaderText = "联系人电话";
            this.MechanismContactNumber.Name = "MechanismContactNumber";
            this.MechanismContactNumber.ReadOnly = true;
            // 
            // ContactMail
            // 
            this.ContactMail.DataPropertyName = "ContactMail";
            this.ContactMail.HeaderText = "联系人邮箱";
            this.ContactMail.Name = "ContactMail";
            this.ContactMail.ReadOnly = true;
            // 
            // EmployeeTraining2
            // 
            this.EmployeeTraining2.Controls.Add(this.dgvTrainingCourse);
            this.EmployeeTraining2.Location = new System.Drawing.Point(4, 23);
            this.EmployeeTraining2.Name = "EmployeeTraining2";
            this.EmployeeTraining2.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTraining2.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeTraining2.TabIndex = 13;
            this.EmployeeTraining2.Tag = "EmployeeTraining";
            this.EmployeeTraining2.Text = "培训课程";
            this.EmployeeTraining2.UseVisualStyleBackColor = true;
            // 
            // dgvTrainingCourse
            // 
            this.dgvTrainingCourse.AllowUserToAddRows = false;
            this.dgvTrainingCourse.AllowUserToDeleteRows = false;
            this.dgvTrainingCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainingCourseID,
            this.TrainingCourseName,
            this.TrainingType,
            this.TrainingStartTime,
            this.TrainingEndTime});
            this.dgvTrainingCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainingCourse.Location = new System.Drawing.Point(3, 3);
            this.dgvTrainingCourse.Name = "dgvTrainingCourse";
            this.dgvTrainingCourse.ReadOnly = true;
            this.dgvTrainingCourse.RowTemplate.Height = 23;
            this.dgvTrainingCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainingCourse.Size = new System.Drawing.Size(1162, 135);
            this.dgvTrainingCourse.TabIndex = 12;
            // 
            // TrainingCourseID
            // 
            this.TrainingCourseID.DataPropertyName = "TrainingCourseID";
            this.TrainingCourseID.HeaderText = "培训课程编号";
            this.TrainingCourseID.Name = "TrainingCourseID";
            this.TrainingCourseID.ReadOnly = true;
            this.TrainingCourseID.Width = 120;
            // 
            // TrainingCourseName
            // 
            this.TrainingCourseName.DataPropertyName = "TrainingCourseName";
            this.TrainingCourseName.HeaderText = "培训课程名称";
            this.TrainingCourseName.Name = "TrainingCourseName";
            this.TrainingCourseName.ReadOnly = true;
            this.TrainingCourseName.Width = 120;
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
            // EmployeeTraining3
            // 
            this.EmployeeTraining3.Controls.Add(this.dgvTrainingRecord);
            this.EmployeeTraining3.Location = new System.Drawing.Point(4, 23);
            this.EmployeeTraining3.Name = "EmployeeTraining3";
            this.EmployeeTraining3.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTraining3.Size = new System.Drawing.Size(1168, 141);
            this.EmployeeTraining3.TabIndex = 14;
            this.EmployeeTraining3.Tag = "EmployeeTraining";
            this.EmployeeTraining3.Text = "培训记录";
            this.EmployeeTraining3.UseVisualStyleBackColor = true;
            // 
            // dgvTrainingRecord
            // 
            this.dgvTrainingRecord.AllowUserToAddRows = false;
            this.dgvTrainingRecord.AllowUserToDeleteRows = false;
            this.dgvTrainingRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostDepartment,
            this.TrainingMoney,
            this.TrainingAttendance,
            this.TrainingTestResults,
            this.TrainingTestLevel,
            this.TrainingEvaluation});
            this.dgvTrainingRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainingRecord.Location = new System.Drawing.Point(3, 3);
            this.dgvTrainingRecord.Name = "dgvTrainingRecord";
            this.dgvTrainingRecord.ReadOnly = true;
            this.dgvTrainingRecord.RowTemplate.Height = 23;
            this.dgvTrainingRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainingRecord.Size = new System.Drawing.Size(1162, 135);
            this.dgvTrainingRecord.TabIndex = 13;
            // 
            // HostDepartment
            // 
            this.HostDepartment.DataPropertyName = "HostDepartment";
            this.HostDepartment.HeaderText = "主办部门";
            this.HostDepartment.Name = "HostDepartment";
            this.HostDepartment.ReadOnly = true;
            // 
            // TrainingMoney
            // 
            this.TrainingMoney.DataPropertyName = "TrainingMoney";
            this.TrainingMoney.HeaderText = "培训费用";
            this.TrainingMoney.Name = "TrainingMoney";
            this.TrainingMoney.ReadOnly = true;
            // 
            // TrainingAttendance
            // 
            this.TrainingAttendance.DataPropertyName = "TrainingAttendance";
            this.TrainingAttendance.HeaderText = "培训出勤情况";
            this.TrainingAttendance.Name = "TrainingAttendance";
            this.TrainingAttendance.ReadOnly = true;
            this.TrainingAttendance.Width = 120;
            // 
            // TrainingTestResults
            // 
            this.TrainingTestResults.DataPropertyName = "TrainingTestResults";
            this.TrainingTestResults.HeaderText = "培训考核成绩";
            this.TrainingTestResults.Name = "TrainingTestResults";
            this.TrainingTestResults.ReadOnly = true;
            this.TrainingTestResults.Width = 120;
            // 
            // TrainingTestLevel
            // 
            this.TrainingTestLevel.DataPropertyName = "TrainingTestLevel";
            this.TrainingTestLevel.HeaderText = "培训考核等级";
            this.TrainingTestLevel.Name = "TrainingTestLevel";
            this.TrainingTestLevel.ReadOnly = true;
            this.TrainingTestLevel.Width = 120;
            // 
            // TrainingEvaluation
            // 
            this.TrainingEvaluation.DataPropertyName = "TrainingEvaluation";
            this.TrainingEvaluation.HeaderText = "培训评价";
            this.TrainingEvaluation.Name = "TrainingEvaluation";
            this.TrainingEvaluation.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tctl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 168);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAdminEmployeeInfo);
            this.panel2.Controls.Add(this.tvDepartment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 334);
            this.panel2.TabIndex = 6;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAdd.BackgroundImage")));
            this.pnlAdd.Location = new System.Drawing.Point(23, 5);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(66, 55);
            this.pnlAdd.TabIndex = 0;
            this.pnlAdd.Click += new System.EventHandler(this.pnlAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdd.Location = new System.Drawing.Point(24, 63);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(64, 17);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "添加账号";
            // 
            // pnlModify
            // 
            this.pnlModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlModify.BackgroundImage")));
            this.pnlModify.Location = new System.Drawing.Point(247, 5);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(66, 55);
            this.pnlModify.TabIndex = 2;
            this.pnlModify.Click += new System.EventHandler(this.pnlModify_Click);
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModify.Location = new System.Drawing.Point(248, 63);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(64, 17);
            this.lblModify.TabIndex = 3;
            this.lblModify.Text = "修改信息";
            // 
            // pnlDel
            // 
            this.pnlDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDel.BackgroundImage")));
            this.pnlDel.Location = new System.Drawing.Point(359, 5);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(66, 55);
            this.pnlDel.TabIndex = 4;
            this.pnlDel.Click += new System.EventHandler(this.pnlDel_Click);
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDel.Location = new System.Drawing.Point(360, 63);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(64, 17);
            this.lblDel.TabIndex = 5;
            this.lblDel.Text = "删除信息";
            // 
            // pnlExport
            // 
            this.pnlExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExport.BackgroundImage")));
            this.pnlExport.Location = new System.Drawing.Point(471, 5);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(66, 55);
            this.pnlExport.TabIndex = 8;
            this.pnlExport.Click += new System.EventHandler(this.pnlExport_Click);
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExport.Location = new System.Drawing.Point(472, 63);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(64, 17);
            this.lblExport.TabIndex = 9;
            this.lblExport.Text = "导出信息";
            // 
            // pnlQuit
            // 
            this.pnlQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlQuit.BackgroundImage")));
            this.pnlQuit.Location = new System.Drawing.Point(695, 5);
            this.pnlQuit.Name = "pnlQuit";
            this.pnlQuit.Size = new System.Drawing.Size(66, 55);
            this.pnlQuit.TabIndex = 10;
            this.pnlQuit.Click += new System.EventHandler(this.pnlQuit_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuit.Location = new System.Drawing.Point(696, 63);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(64, 17);
            this.lblQuit.TabIndex = 11;
            this.lblQuit.Text = "切换用户";
            this.lblQuit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAddInfo);
            this.panel3.Controls.Add(this.pnlAddInfo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblQuit);
            this.panel3.Controls.Add(this.pnlSkin);
            this.panel3.Controls.Add(this.pnlQuit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblExport);
            this.panel3.Controls.Add(this.pnlUpdate);
            this.panel3.Controls.Add(this.pnlExport);
            this.panel3.Controls.Add(this.lblDel);
            this.panel3.Controls.Add(this.pnlDel);
            this.panel3.Controls.Add(this.lblModify);
            this.panel3.Controls.Add(this.pnlModify);
            this.panel3.Controls.Add(this.lblAdd);
            this.panel3.Controls.Add(this.pnlAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 91);
            this.panel3.TabIndex = 0;
            // 
            // lblAddInfo
            // 
            this.lblAddInfo.AutoSize = true;
            this.lblAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddInfo.Location = new System.Drawing.Point(136, 64);
            this.lblAddInfo.Name = "lblAddInfo";
            this.lblAddInfo.Size = new System.Drawing.Size(64, 17);
            this.lblAddInfo.TabIndex = 15;
            this.lblAddInfo.Text = "添加信息";
            // 
            // pnlAddInfo
            // 
            this.pnlAddInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddInfo.BackgroundImage")));
            this.pnlAddInfo.Location = new System.Drawing.Point(135, 5);
            this.pnlAddInfo.Name = "pnlAddInfo";
            this.pnlAddInfo.Size = new System.Drawing.Size(66, 55);
            this.pnlAddInfo.TabIndex = 14;
            this.pnlAddInfo.Click += new System.EventHandler(this.pnlAddInfo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1092, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "更换皮肤";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSkin
            // 
            this.pnlSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSkin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSkin.BackgroundImage")));
            this.pnlSkin.Location = new System.Drawing.Point(1088, 5);
            this.pnlSkin.Name = "pnlSkin";
            this.pnlSkin.Size = new System.Drawing.Size(66, 55);
            this.pnlSkin.TabIndex = 10;
            this.pnlSkin.Click += new System.EventHandler(this.pnlSkin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(584, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "更新信息";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUpdate.BackgroundImage")));
            this.pnlUpdate.Location = new System.Drawing.Point(583, 5);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(66, 55);
            this.pnlUpdate.TabIndex = 8;
            this.pnlUpdate.Click += new System.EventHandler(this.pnlUpdate_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎来到管理员界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminEmployeeInfo)).EndInit();
            this.tctl.ResumeLayout(false);
            this.EmployeeTransfer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfer)).EndInit();
            this.EmployeeTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).EndInit();
            this.EmployeeQuit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuit)).EndInit();
            this.EmployeeReinstate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReinstatement)).EndInit();
            this.EmployeeContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.EmployeeReward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewardandPunishment)).EndInit();
            this.EmployeeTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.EmployeeCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            this.EmployeePay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.EmployeeInsurance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).EndInit();
            this.EmployeeWelfare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWelfare)).EndInit();
            this.EmployeeTraining.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingDepartment)).EndInit();
            this.EmployeeTraining2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingCourse)).EndInit();
            this.EmployeeTraining3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDepartment;
        private System.Windows.Forms.DataGridView dgvAdminEmployeeInfo;
        private System.Windows.Forms.TabControl tctl;
        private System.Windows.Forms.TabPage EmployeeTransfer;
        private System.Windows.Forms.TabPage EmployeeTitle;
        private System.Windows.Forms.TabPage EmployeeQuit;
        private System.Windows.Forms.TabPage EmployeeReinstate;
        private System.Windows.Forms.TabPage EmployeeContract;
        private System.Windows.Forms.TabPage EmployeeReward;
        private System.Windows.Forms.TabPage EmployeeTest;
        private System.Windows.Forms.TabPage EmployeeCheck;
        private System.Windows.Forms.TabPage EmployeePay;
        private System.Windows.Forms.TabPage EmployeeInsurance;
        private System.Windows.Forms.TabPage EmployeeWelfare;
        private System.Windows.Forms.TabPage EmployeeTraining;
        private System.Windows.Forms.TabPage EmployeeTraining2;
        private System.Windows.Forms.TabPage EmployeeTraining3;
        private System.Windows.Forms.DataGridView dgvTransfer;
        private System.Windows.Forms.DataGridView dgvTitle;
        private System.Windows.Forms.DataGridView dgvQuit;
        private System.Windows.Forms.DataGridView dgvReinstatement;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.DataGridView dgvRewardandPunishment;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.DataGridView dgvInsurance;
        private System.Windows.Forms.DataGridView dgvWelfare;
        private System.Windows.Forms.DataGridView dgvTrainingDepartment;
        private System.Windows.Forms.DataGridView dgvTrainingCourse;
        private System.Windows.Forms.DataGridView dgvTrainingRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel pnlModify;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.Panel pnlExport;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Panel pnlQuit;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAddInfo;
        private System.Windows.Forms.Panel pnlAddInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquireWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reinstatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReinstatementTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReinstatementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReinstatementDescription;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanismContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDepartment1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentAdministrativeLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalAdministrativeLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferTime;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuitTpye;
        private System.Windows.Forms.DataGridViewTextBoxColumn WageCutOffTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingTestResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingTestLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingEvaluation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUpdate;
    }
}

