namespace SearchForm
{
    partial class PersonSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSeria = new System.Windows.Forms.TextBox();
            this.dtpTrust = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.cmbEyeColor = new System.Windows.Forms.ComboBox();
            this.cmbNational = new System.Windows.Forms.ComboBox();
            this.cmbWar = new System.Windows.Forms.ComboBox();
            this.lblNational = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.dtpGivenDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtBorn = new System.Windows.Forms.TextBox();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gpbName = new System.Windows.Forms.GroupBox();
            this.txtAuthority = new System.Windows.Forms.TextBox();
            this.lblSeria = new System.Windows.Forms.Label();
            this.lblGivenDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTrust = new System.Windows.Forms.Label();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblWar = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBorn = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthOfDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MartialStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MilitaryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EyeColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivingPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuingAuthority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.gpbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(539, 281);
            this.nudHeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(94, 31);
            this.nudHeight.TabIndex = 70;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(450, 521);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(184, 31);
            this.txtNumber.TabIndex = 62;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtSeria
            // 
            this.txtSeria.Location = new System.Drawing.Point(279, 522);
            this.txtSeria.Name = "txtSeria";
            this.txtSeria.Size = new System.Drawing.Size(100, 31);
            this.txtSeria.TabIndex = 61;
            this.txtSeria.TextChanged += new System.EventHandler(this.txtSeria_TextChanged);
            // 
            // dtpTrust
            // 
            this.dtpTrust.CustomFormat = "dd.MM.yyyy";
            this.dtpTrust.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTrust.Location = new System.Drawing.Point(534, 475);
            this.dtpTrust.Name = "dtpTrust";
            this.dtpTrust.Size = new System.Drawing.Size(100, 31);
            this.dtpTrust.TabIndex = 60;
            this.dtpTrust.ValueChanged += new System.EventHandler(this.dtpTrust_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Cinsi:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(552, 192);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(82, 33);
            this.cmbGender.TabIndex = 47;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Location = new System.Drawing.Point(552, 372);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(82, 33);
            this.cmbBloodGroup.TabIndex = 56;
            this.cmbBloodGroup.SelectedIndexChanged += new System.EventHandler(this.cmbBloodGroup_SelectedIndexChanged);
            // 
            // cmbFamily
            // 
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Location = new System.Drawing.Point(279, 284);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.Size = new System.Drawing.Size(150, 33);
            this.cmbFamily.TabIndex = 49;
            this.cmbFamily.SelectedIndexChanged += new System.EventHandler(this.cmbFamily_SelectedIndexChanged);
            // 
            // cmbEyeColor
            // 
            this.cmbEyeColor.FormattingEnabled = true;
            this.cmbEyeColor.Location = new System.Drawing.Point(279, 377);
            this.cmbEyeColor.Name = "cmbEyeColor";
            this.cmbEyeColor.Size = new System.Drawing.Size(150, 33);
            this.cmbEyeColor.TabIndex = 55;
            this.cmbEyeColor.SelectedIndexChanged += new System.EventHandler(this.cmbEyeColor_SelectedIndexChanged);
            // 
            // cmbNational
            // 
            this.cmbNational.FormattingEnabled = true;
            this.cmbNational.Location = new System.Drawing.Point(279, 242);
            this.cmbNational.Name = "cmbNational";
            this.cmbNational.Size = new System.Drawing.Size(355, 33);
            this.cmbNational.TabIndex = 48;
            this.cmbNational.SelectedIndexChanged += new System.EventHandler(this.cmbNational_SelectedIndexChanged);
            // 
            // cmbWar
            // 
            this.cmbWar.FormattingEnabled = true;
            this.cmbWar.Location = new System.Drawing.Point(294, 330);
            this.cmbWar.Name = "cmbWar";
            this.cmbWar.Size = new System.Drawing.Size(340, 33);
            this.cmbWar.TabIndex = 53;
            this.cmbWar.SelectedIndexChanged += new System.EventHandler(this.cmbWar_SelectedIndexChanged);
            // 
            // lblNational
            // 
            this.lblNational.AutoSize = true;
            this.lblNational.Location = new System.Drawing.Point(85, 245);
            this.lblNational.Name = "lblNational";
            this.lblNational.Size = new System.Drawing.Size(136, 25);
            this.lblNational.TabIndex = 54;
            this.lblNational.Text = "Vetendasligi:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(410, 528);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(33, 25);
            this.lblNumber.TabIndex = 52;
            this.lblNumber.Text = "№";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.Location = new System.Drawing.Point(435, 377);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(119, 25);
            this.lblBlood.TabIndex = 51;
            this.lblBlood.Text = "Qan qrupu:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(466, 287);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(67, 25);
            this.lblLength.TabIndex = 50;
            this.lblLength.Text = "Boyu:";
            // 
            // dtpGivenDate
            // 
            this.dtpGivenDate.CustomFormat = "dd.MM.yyyy";
            this.dtpGivenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGivenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGivenDate.Location = new System.Drawing.Point(279, 474);
            this.dtpGivenDate.Name = "dtpGivenDate";
            this.dtpGivenDate.Size = new System.Drawing.Size(100, 31);
            this.dtpGivenDate.TabIndex = 58;
            this.dtpGivenDate.Value = new System.DateTime(2019, 4, 19, 0, 0, 0, 0);
            this.dtpGivenDate.ValueChanged += new System.EventHandler(this.dtpGivenDate_ValueChanged);
            // 
            // dtpBorn
            // 
            this.dtpBorn.CustomFormat = "dd.MM.yyyy";
            this.dtpBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorn.Location = new System.Drawing.Point(279, 188);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(150, 31);
            this.dtpBorn.TabIndex = 46;
            this.dtpBorn.Value = new System.DateTime(2019, 4, 19, 0, 0, 0, 0);
            this.dtpBorn.ValueChanged += new System.EventHandler(this.dtpBorn_ValueChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(279, 426);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(355, 31);
            this.txtLocation.TabIndex = 57;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // txtBorn
            // 
            this.txtBorn.Location = new System.Drawing.Point(279, 140);
            this.txtBorn.Name = "txtBorn";
            this.txtBorn.Size = new System.Drawing.Size(355, 31);
            this.txtBorn.TabIndex = 33;
            this.txtBorn.TextChanged += new System.EventHandler(this.txtBorn_TextChanged);
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(279, 101);
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(355, 31);
            this.txtFather.TabIndex = 32;
            this.txtFather.TextChanged += new System.EventHandler(this.txtFather_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(279, 64);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(355, 31);
            this.txtSurname.TabIndex = 30;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(355, 31);
            this.txtName.TabIndex = 29;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // gpbName
            // 
            this.gpbName.Controls.Add(this.txtAuthority);
            this.gpbName.Location = new System.Drawing.Point(88, 578);
            this.gpbName.Name = "gpbName";
            this.gpbName.Size = new System.Drawing.Size(546, 88);
            this.gpbName.TabIndex = 45;
            this.gpbName.TabStop = false;
            this.gpbName.Text = "Vesiqe veren orqanin adi";
            // 
            // txtAuthority
            // 
            this.txtAuthority.Location = new System.Drawing.Point(6, 39);
            this.txtAuthority.Name = "txtAuthority";
            this.txtAuthority.Size = new System.Drawing.Size(534, 31);
            this.txtAuthority.TabIndex = 18;
            this.txtAuthority.TextChanged += new System.EventHandler(this.txtAuthority_TextChanged);
            // 
            // lblSeria
            // 
            this.lblSeria.AutoSize = true;
            this.lblSeria.Location = new System.Drawing.Point(83, 529);
            this.lblSeria.Name = "lblSeria";
            this.lblSeria.Size = new System.Drawing.Size(79, 25);
            this.lblSeria.TabIndex = 34;
            this.lblSeria.Text = "Seriya:";
            // 
            // lblGivenDate
            // 
            this.lblGivenDate.AutoSize = true;
            this.lblGivenDate.Location = new System.Drawing.Point(83, 482);
            this.lblGivenDate.Name = "lblGivenDate";
            this.lblGivenDate.Size = new System.Drawing.Size(142, 25);
            this.lblGivenDate.TabIndex = 36;
            this.lblGivenDate.Text = "Verilme tarixi:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(83, 432);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(136, 25);
            this.lblLocation.TabIndex = 35;
            this.lblLocation.Text = "Yasayis yeri:";
            // 
            // lblTrust
            // 
            this.lblTrust.AutoSize = true;
            this.lblTrust.Location = new System.Drawing.Point(410, 480);
            this.lblTrust.Name = "lblTrust";
            this.lblTrust.Size = new System.Drawing.Size(108, 25);
            this.lblTrust.TabIndex = 43;
            this.lblTrust.Text = "Etibarlidir:";
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(83, 376);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(111, 25);
            this.lblEyeColor.TabIndex = 37;
            this.lblEyeColor.Text = "Goz rengi:";
            // 
            // lblWar
            // 
            this.lblWar.AutoSize = true;
            this.lblWar.Location = new System.Drawing.Point(83, 333);
            this.lblWar.Name = "lblWar";
            this.lblWar.Size = new System.Drawing.Size(205, 25);
            this.lblWar.TabIndex = 38;
            this.lblWar.Text = "Herbi mukellefiyyeti:";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(83, 279);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(144, 25);
            this.lblFamily.TabIndex = 44;
            this.lblFamily.Text = "Aile veziyyeti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Dogum tarixi:";
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(83, 147);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(158, 25);
            this.lblBorn.TabIndex = 41;
            this.lblBorn.Text = "Doguldugu yer:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(83, 109);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(130, 25);
            this.lblFatherName.TabIndex = 40;
            this.lblFatherName.Text = "Atasinin adi:";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(83, 71);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(84, 25);
            this.lblSurName.TabIndex = 39;
            this.lblSurName.Text = "Soyadi:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(83, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 25);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Adi:";
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FLF,
            this.BirthPlace,
            this.BirthOfDate,
            this.GenderName,
            this.NationalityName,
            this.MartialStatusName,
            this.Height,
            this.MilitaryStatus,
            this.EyeColorName,
            this.BloodGroupName,
            this.LivingPlace,
            this.IssueDate,
            this.ExpiryDate,
            this.Seria,
            this.Number,
            this.IssuingAuthority,
            this.DeletedDateTime});
            this.dgvMain.Location = new System.Drawing.Point(663, 27);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 33;
            this.dgvMain.Size = new System.Drawing.Size(1097, 639);
            this.dgvMain.TabIndex = 71;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 70;
            this.Id.Name = "Id";
            // 
            // FLF
            // 
            this.FLF.DataPropertyName = "FLF";
            this.FLF.HeaderText = "ASA";
            this.FLF.MinimumWidth = 140;
            this.FLF.Name = "FLF";
            // 
            // BirthPlace
            // 
            this.BirthPlace.DataPropertyName = "BirthPlace";
            this.BirthPlace.FillWeight = 54.02262F;
            this.BirthPlace.HeaderText = "Dogum yeri";
            this.BirthPlace.MinimumWidth = 70;
            this.BirthPlace.Name = "BirthPlace";
            // 
            // BirthOfDate
            // 
            this.BirthOfDate.DataPropertyName = "BirthOfDate";
            this.BirthOfDate.FillWeight = 54.02262F;
            this.BirthOfDate.HeaderText = "Dogum tarixi";
            this.BirthOfDate.MinimumWidth = 70;
            this.BirthOfDate.Name = "BirthOfDate";
            // 
            // GenderName
            // 
            this.GenderName.DataPropertyName = "GenderName";
            this.GenderName.FillWeight = 54.02262F;
            this.GenderName.HeaderText = "Cins";
            this.GenderName.MinimumWidth = 70;
            this.GenderName.Name = "GenderName";
            // 
            // NationalityName
            // 
            this.NationalityName.DataPropertyName = "Citizenship";
            this.NationalityName.FillWeight = 54.02262F;
            this.NationalityName.HeaderText = "Vetendasliq";
            this.NationalityName.MinimumWidth = 70;
            this.NationalityName.Name = "NationalityName";
            // 
            // MartialStatusName
            // 
            this.MartialStatusName.DataPropertyName = "MartialStatusName";
            this.MartialStatusName.FillWeight = 54.02262F;
            this.MartialStatusName.HeaderText = "Aile veziyyet";
            this.MartialStatusName.MinimumWidth = 70;
            this.MartialStatusName.Name = "MartialStatusName";
            // 
            // Height
            // 
            this.Height.DataPropertyName = "Height";
            this.Height.FillWeight = 54.02262F;
            this.Height.HeaderText = "Boy";
            this.Height.MinimumWidth = 70;
            this.Height.Name = "Height";
            // 
            // MilitaryStatus
            // 
            this.MilitaryStatus.DataPropertyName = "MilitaryStatusName";
            this.MilitaryStatus.FillWeight = 54.02262F;
            this.MilitaryStatus.HeaderText = "Herbi mukellefiyyet";
            this.MilitaryStatus.MinimumWidth = 70;
            this.MilitaryStatus.Name = "MilitaryStatus";
            // 
            // EyeColorName
            // 
            this.EyeColorName.DataPropertyName = "EyeColorName";
            this.EyeColorName.FillWeight = 54.02262F;
            this.EyeColorName.HeaderText = "Goz rengi";
            this.EyeColorName.MinimumWidth = 70;
            this.EyeColorName.Name = "EyeColorName";
            // 
            // BloodGroupName
            // 
            this.BloodGroupName.DataPropertyName = "BloodGroupName";
            this.BloodGroupName.FillWeight = 54.02262F;
            this.BloodGroupName.HeaderText = "Qan qrupu";
            this.BloodGroupName.MinimumWidth = 70;
            this.BloodGroupName.Name = "BloodGroupName";
            // 
            // LivingPlace
            // 
            this.LivingPlace.DataPropertyName = "LivingPlace";
            this.LivingPlace.FillWeight = 54.02262F;
            this.LivingPlace.HeaderText = "Yasayis yeri";
            this.LivingPlace.MinimumWidth = 70;
            this.LivingPlace.Name = "LivingPlace";
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.FillWeight = 54.02262F;
            this.IssueDate.HeaderText = "Verilme tarixi";
            this.IssueDate.MinimumWidth = 70;
            this.IssueDate.Name = "IssueDate";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.FillWeight = 54.02262F;
            this.ExpiryDate.HeaderText = "Etibarliliq tarixi";
            this.ExpiryDate.MinimumWidth = 70;
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // Seria
            // 
            this.Seria.DataPropertyName = "Series";
            this.Seria.FillWeight = 54.02262F;
            this.Seria.HeaderText = "Seriya";
            this.Seria.MinimumWidth = 70;
            this.Seria.Name = "Seria";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Nomre";
            this.Number.MinimumWidth = 70;
            this.Number.Name = "Number";
            // 
            // IssuingAuthority
            // 
            this.IssuingAuthority.DataPropertyName = "IssuingAuthority";
            this.IssuingAuthority.FillWeight = 54.02262F;
            this.IssuingAuthority.HeaderText = "Vesiqeni veren orqanin adi";
            this.IssuingAuthority.MinimumWidth = 70;
            this.IssuingAuthority.Name = "IssuingAuthority";
            // 
            // DeletedDateTime
            // 
            this.DeletedDateTime.FillWeight = 54.02262F;
            this.DeletedDateTime.HeaderText = "Silinme vaxti";
            this.DeletedDateTime.MinimumWidth = 70;
            this.DeletedDateTime.Name = "DeletedDateTime";
            // 
            // PersonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 730);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtSeria);
            this.Controls.Add(this.dtpTrust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.cmbFamily);
            this.Controls.Add(this.cmbEyeColor);
            this.Controls.Add(this.cmbNational);
            this.Controls.Add(this.cmbWar);
            this.Controls.Add(this.lblNational);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblBlood);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.dtpGivenDate);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtBorn);
            this.Controls.Add(this.txtFather);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gpbName);
            this.Controls.Add(this.lblSeria);
            this.Controls.Add(this.lblGivenDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTrust);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.lblWar);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBorn);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.lblName);
            this.Name = "PersonSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.gpbName.ResumeLayout(false);
            this.gpbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSeria;
        private System.Windows.Forms.DateTimePicker dtpTrust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.ComboBox cmbEyeColor;
        private System.Windows.Forms.ComboBox cmbNational;
        private System.Windows.Forms.ComboBox cmbWar;
        private System.Windows.Forms.Label lblNational;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.DateTimePicker dtpGivenDate;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtBorn;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gpbName;
        private System.Windows.Forms.TextBox txtAuthority;
        private System.Windows.Forms.Label lblSeria;
        private System.Windows.Forms.Label lblGivenDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTrust;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblWar;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLF;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthOfDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MartialStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn MilitaryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn EyeColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivingPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuingAuthority;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedDateTime;
    }
}