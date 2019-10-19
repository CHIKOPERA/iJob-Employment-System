namespace iJob2019
{
    partial class frmManageLabourers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLabourers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLabourerInfo = new System.Windows.Forms.Panel();
            this.txtContact = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtAdditionalInfo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblAdditonalinfo = new System.Windows.Forms.Label();
            this.txtAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.txtLanguage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNationality = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDOB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.picLabImage = new System.Windows.Forms.PictureBox();
            this.dgvLabourers = new System.Windows.Forms.DataGridView();
            this.labourerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLabourer = new iJob2019.dsLabourer();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchLname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labourerTableAdapter = new iJob2019.dsLabourerTableAdapters.LabourerTableAdapter();
            this.panelLabourerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdditionalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            this.groupGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLabImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabourers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLabourer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchLname)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLabourerInfo
            // 
            this.panelLabourerInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLabourerInfo.Controls.Add(this.txtContact);
            this.panelLabourerInfo.Controls.Add(this.txtAdditionalInfo);
            this.panelLabourerInfo.Controls.Add(this.lblAdditonalinfo);
            this.panelLabourerInfo.Controls.Add(this.txtAddress);
            this.panelLabourerInfo.Controls.Add(this.label7);
            this.panelLabourerInfo.Controls.Add(this.label6);
            this.panelLabourerInfo.Controls.Add(this.groupGender);
            this.panelLabourerInfo.Controls.Add(this.txtLanguage);
            this.panelLabourerInfo.Controls.Add(this.label5);
            this.panelLabourerInfo.Controls.Add(this.txtNationality);
            this.panelLabourerInfo.Controls.Add(this.label4);
            this.panelLabourerInfo.Controls.Add(this.txtDOB);
            this.panelLabourerInfo.Controls.Add(this.label3);
            this.panelLabourerInfo.Controls.Add(this.txtLName);
            this.panelLabourerInfo.Controls.Add(this.label1);
            this.panelLabourerInfo.Controls.Add(this.txtFName);
            this.panelLabourerInfo.Controls.Add(this.label2);
            this.panelLabourerInfo.Controls.Add(this.picLabImage);
            this.panelLabourerInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLabourerInfo.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLabourerInfo.Location = new System.Drawing.Point(0, 0);
            this.panelLabourerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLabourerInfo.Name = "panelLabourerInfo";
            this.panelLabourerInfo.Size = new System.Drawing.Size(234, 610);
            this.panelLabourerInfo.TabIndex = 1;
            this.panelLabourerInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenuInfo_Paint);
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtContact.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtContact.BorderColor = System.Drawing.Color.DimGray;
            this.txtContact.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Enabled = false;
            this.txtContact.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtContact.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(11, 393);
            this.txtContact.MaxLength = 10;
            this.txtContact.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(216, 23);
            this.txtContact.TabIndex = 42;
            // 
            // txtAdditionalInfo
            // 
            this.txtAdditionalInfo.BackColor = System.Drawing.Color.White;
            this.txtAdditionalInfo.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtAdditionalInfo.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtAdditionalInfo.BorderColor = System.Drawing.Color.DimGray;
            this.txtAdditionalInfo.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtAdditionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalInfo.Enabled = false;
            this.txtAdditionalInfo.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtAdditionalInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalInfo.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalInfo.Location = new System.Drawing.Point(11, 489);
            this.txtAdditionalInfo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAdditionalInfo.Multiline = true;
            this.txtAdditionalInfo.Name = "txtAdditionalInfo";
            this.txtAdditionalInfo.Size = new System.Drawing.Size(216, 43);
            this.txtAdditionalInfo.TabIndex = 41;
            // 
            // lblAdditonalinfo
            // 
            this.lblAdditonalinfo.AutoSize = true;
            this.lblAdditonalinfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditonalinfo.ForeColor = System.Drawing.Color.Snow;
            this.lblAdditonalinfo.Location = new System.Drawing.Point(9, 471);
            this.lblAdditonalinfo.Name = "lblAdditonalinfo";
            this.lblAdditonalinfo.Size = new System.Drawing.Size(144, 16);
            this.lblAdditonalinfo.TabIndex = 40;
            this.lblAdditonalinfo.Text = "Additional Information";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtAddress.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtAddress.BorderColor = System.Drawing.Color.DimGray;
            this.txtAddress.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Enabled = false;
            this.txtAddress.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(11, 430);
            this.txtAddress.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 41);
            this.txtAddress.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(9, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(9, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Contact";
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.radioOther);
            this.groupGender.Controls.Add(this.radioFemale);
            this.groupGender.Controls.Add(this.radioMale);
            this.groupGender.Enabled = false;
            this.groupGender.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGender.ForeColor = System.Drawing.Color.Snow;
            this.groupGender.Location = new System.Drawing.Point(11, 327);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(215, 44);
            this.groupGender.TabIndex = 35;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOther.Location = new System.Drawing.Point(112, 20);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(50, 18);
            this.radioOther.TabIndex = 2;
            this.radioOther.TabStop = true;
            this.radioOther.Text = "Other";
            this.radioOther.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.Location = new System.Drawing.Point(52, 19);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(57, 18);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.Location = new System.Drawing.Point(5, 19);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(47, 18);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // txtLanguage
            // 
            this.txtLanguage.BackColor = System.Drawing.Color.White;
            this.txtLanguage.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtLanguage.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtLanguage.BorderColor = System.Drawing.Color.DimGray;
            this.txtLanguage.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLanguage.Enabled = false;
            this.txtLanguage.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtLanguage.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.ForeColor = System.Drawing.Color.Black;
            this.txtLanguage.Location = new System.Drawing.Point(10, 302);
            this.txtLanguage.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(216, 23);
            this.txtLanguage.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(8, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Language";
            // 
            // txtNationality
            // 
            this.txtNationality.BackColor = System.Drawing.Color.White;
            this.txtNationality.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtNationality.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtNationality.BorderColor = System.Drawing.Color.DimGray;
            this.txtNationality.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtNationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationality.Enabled = false;
            this.txtNationality.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtNationality.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.Color.Black;
            this.txtNationality.Location = new System.Drawing.Point(10, 260);
            this.txtNationality.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(216, 23);
            this.txtNationality.TabIndex = 32;
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNationality_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(8, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Province";
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.Color.White;
            this.txtDOB.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtDOB.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtDOB.BorderColor = System.Drawing.Color.DimGray;
            this.txtDOB.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOB.Enabled = false;
            this.txtDOB.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtDOB.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.Color.Black;
            this.txtDOB.Location = new System.Drawing.Point(10, 220);
            this.txtDOB.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(216, 23);
            this.txtDOB.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(8, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "DOB";
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.White;
            this.txtLName.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtLName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtLName.BorderColor = System.Drawing.Color.DimGray;
            this.txtLName.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Enabled = false;
            this.txtLName.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtLName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.Black;
            this.txtLName.Location = new System.Drawing.Point(10, 178);
            this.txtLName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(216, 23);
            this.txtLName.TabIndex = 28;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(8, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.White;
            this.txtFName.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtFName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtFName.BorderColor = System.Drawing.Color.DimGray;
            this.txtFName.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Enabled = false;
            this.txtFName.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtFName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.Black;
            this.txtFName.Location = new System.Drawing.Point(10, 138);
            this.txtFName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(216, 23);
            this.txtFName.TabIndex = 26;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name";
            // 
            // picLabImage
            // 
            this.picLabImage.Image = ((System.Drawing.Image)(resources.GetObject("picLabImage.Image")));
            this.picLabImage.Location = new System.Drawing.Point(63, 12);
            this.picLabImage.Name = "picLabImage";
            this.picLabImage.Size = new System.Drawing.Size(95, 95);
            this.picLabImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLabImage.TabIndex = 9;
            this.picLabImage.TabStop = false;
            // 
            // dgvLabourers
            // 
            this.dgvLabourers.AllowUserToAddRows = false;
            this.dgvLabourers.AllowUserToDeleteRows = false;
            this.dgvLabourers.AllowUserToResizeColumns = false;
            this.dgvLabourers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvLabourers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLabourers.AutoGenerateColumns = false;
            this.dgvLabourers.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvLabourers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLabourers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLabourers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLabourers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabourers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labourerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.birthProvinceDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.skillsDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.additionalInformationDataGridViewTextBoxColumn});
            this.dgvLabourers.DataSource = this.labourerBindingSource;
            this.dgvLabourers.Location = new System.Drawing.Point(232, 79);
            this.dgvLabourers.MultiSelect = false;
            this.dgvLabourers.Name = "dgvLabourers";
            this.dgvLabourers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLabourers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLabourers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLabourers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLabourers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLabourers.Size = new System.Drawing.Size(1017, 464);
            this.dgvLabourers.TabIndex = 7;
            this.dgvLabourers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLabourers_RowEnter);
            this.dgvLabourers.SelectionChanged += new System.EventHandler(this.DgvLabourers_SelectionChanged);
            this.dgvLabourers.EnabledChanged += new System.EventHandler(this.DgvLabourers_EnabledChanged);
            // 
            // labourerIDDataGridViewTextBoxColumn
            // 
            this.labourerIDDataGridViewTextBoxColumn.DataPropertyName = "Labourer_ID";
            this.labourerIDDataGridViewTextBoxColumn.HeaderText = "Labourer_ID";
            this.labourerIDDataGridViewTextBoxColumn.Name = "labourerIDDataGridViewTextBoxColumn";
            this.labourerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthProvinceDataGridViewTextBoxColumn
            // 
            this.birthProvinceDataGridViewTextBoxColumn.DataPropertyName = "Birth_Province";
            this.birthProvinceDataGridViewTextBoxColumn.HeaderText = "Birth_Province";
            this.birthProvinceDataGridViewTextBoxColumn.Name = "birthProvinceDataGridViewTextBoxColumn";
            this.birthProvinceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "Street_Address";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "Street_Address";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "Postal_Code";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Postal_Code";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skillsDataGridViewTextBoxColumn
            // 
            this.skillsDataGridViewTextBoxColumn.DataPropertyName = "Skills";
            this.skillsDataGridViewTextBoxColumn.HeaderText = "Skills";
            this.skillsDataGridViewTextBoxColumn.Name = "skillsDataGridViewTextBoxColumn";
            this.skillsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // additionalInformationDataGridViewTextBoxColumn
            // 
            this.additionalInformationDataGridViewTextBoxColumn.DataPropertyName = "Additional_Information";
            this.additionalInformationDataGridViewTextBoxColumn.HeaderText = "Additional_Information";
            this.additionalInformationDataGridViewTextBoxColumn.Name = "additionalInformationDataGridViewTextBoxColumn";
            this.additionalInformationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labourerBindingSource
            // 
            this.labourerBindingSource.DataMember = "Labourer";
            this.labourerBindingSource.DataSource = this.dsLabourer;
            // 
            // dsLabourer
            // 
            this.dsLabourer.DataSetName = "dsLabourer";
            this.dsLabourer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(347, 549);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 49);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(259, 549);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 49);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(440, 549);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(81, 49);
            this.btnAddNew.TabIndex = 19;
            this.btnAddNew.Text = "New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(241, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Manage Labourers";
            // 
            // lblNotification
            // 
            this.lblNotification.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNotification.Location = new System.Drawing.Point(826, 6);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(423, 25);
            this.lblNotification.TabIndex = 27;
            this.lblNotification.Text = ".";
            this.lblNotification.TextChanged += new System.EventHandler(this.LblNotification_TextChanged);
            this.lblNotification.Click += new System.EventHandler(this.LblNotification_Click);
            // 
            // timerMessage
            // 
            this.timerMessage.Enabled = true;
            this.timerMessage.Interval = 3500;
            this.timerMessage.Tick += new System.EventHandler(this.TimerMessage_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(295, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "by Last ID";
            // 
            // txtSearchLname
            // 
            this.txtSearchLname.BackColor = System.Drawing.Color.White;
            this.txtSearchLname.BeforeTouchSize = new System.Drawing.Size(216, 23);
            this.txtSearchLname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearchLname.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtSearchLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchLname.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLname.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSearchLname.Location = new System.Drawing.Point(382, 50);
            this.txtSearchLname.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearchLname.Name = "txtSearchLname";
            this.txtSearchLname.Size = new System.Drawing.Size(213, 23);
            this.txtSearchLname.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSearchLname.TabIndex = 43;
            this.txtSearchLname.TextChanged += new System.EventHandler(this.TxtSearchLname_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(243, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Search";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1222, 549);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 26);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // labourerTableAdapter
            // 
            this.labourerTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageLabourers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 610);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSearchLname);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.panelLabourerInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvLabourers);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageLabourers";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Labourers";
            this.Load += new System.EventHandler(this.FrmManageLabourers_Load);
            this.panelLabourerInfo.ResumeLayout(false);
            this.panelLabourerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdditionalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLabImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabourers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLabourer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchLname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLabourerInfo;
        private System.Windows.Forms.PictureBox picLabImage;
        private System.Windows.Forms.DataGridView dgvLabourers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAdditionalInfo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupGender;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLanguage;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNationality;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDOB;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLName;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        //private System.Windows.Forms.DataGridViewTextBoxColumn labourerIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn skillsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Label lblAdditonalinfo;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Timer timerMessage;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtContact;
        private System.Windows.Forms.Label label11;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearchLname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefresh;
        private dsLabourer dsLabourer;
        private System.Windows.Forms.BindingSource labourerBindingSource;
        private dsLabourerTableAdapters.LabourerTableAdapter labourerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn labourerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
    }
}