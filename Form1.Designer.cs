namespace iJob2019
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelMenus = new System.Windows.Forms.Panel();
            this.btnSwitch = new Syncfusion.WinForms.Controls.SfButton();
            this.btnLock = new Syncfusion.WinForms.Controls.SfButton();
            this.btnAboutUs = new Syncfusion.WinForms.Controls.SfButton();
            this.btnMailBox = new Syncfusion.WinForms.Controls.SfButton();
            this.btnLabourers = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDashboard = new Syncfusion.WinForms.Controls.SfButton();
            this.picHomeLogo = new System.Windows.Forms.PictureBox();
            this._panelMailBox = new System.Windows.Forms.Panel();
            this.webMail = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOpenJobs = new System.Windows.Forms.Label();
            this._panelDashBoard = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.comboSortJobs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.dgvJobRequests = new System.Windows.Forms.DataGridView();
            this.jobRequestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfLabourersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobSpecificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJobRequestt = new iJob2019.dsJobRequestt();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this._panelOnlineHelp = new System.Windows.Forms.Panel();
            this.webOnlineHelp = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.jobRequestTableAdapter = new iJob2019.dsJobRequesttTableAdapters.JobRequestTableAdapter();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panelMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeLogo)).BeginInit();
            this._panelMailBox.SuspendLayout();
            this._panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobRequestt)).BeginInit();
            this._panelOnlineHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTopBar.Controls.Add(this.pictureBox1);
            this.panelTopBar.Controls.Add(this.picUser);
            this.panelTopBar.Controls.Add(this.label3);
            this.panelTopBar.Controls.Add(this.lblUserName);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1304, 44);
            this.panelTopBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1278, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(1227, 0);
            this.picUser.Margin = new System.Windows.Forms.Padding(4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(43, 44);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(476, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "iJob Employment System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(1073, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(147, 24);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Tanya Chikopera";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMenus
            // 
            this.panelMenus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenus.Controls.Add(this.btnSwitch);
            this.panelMenus.Controls.Add(this.btnLock);
            this.panelMenus.Controls.Add(this.btnAboutUs);
            this.panelMenus.Controls.Add(this.btnMailBox);
            this.panelMenus.Controls.Add(this.btnLabourers);
            this.panelMenus.Controls.Add(this.btnDashboard);
            this.panelMenus.Controls.Add(this.picHomeLogo);
            this.panelMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenus.Location = new System.Drawing.Point(0, 44);
            this.panelMenus.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenus.Name = "panelMenus";
            this.panelMenus.Size = new System.Drawing.Size(220, 685);
            this.panelMenus.TabIndex = 1;
            // 
            // btnSwitch
            // 
            this.btnSwitch.AccessibleName = "Button";
            this.btnSwitch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSwitch.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.ForeColor = System.Drawing.Color.Snow;
            this.btnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitch.Image")));
            this.btnSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitch.Location = new System.Drawing.Point(-1, 404);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(213, 56);
            this.btnSwitch.Style.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSwitch.Style.DisabledBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSwitch.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnSwitch.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnSwitch.Style.ForeColor = System.Drawing.Color.Snow;
            this.btnSwitch.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnSwitch.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnSwitch.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnSwitch.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnSwitch.TabIndex = 14;
            this.btnSwitch.Text = "Go To  Admin";
            this.btnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // btnLock
            // 
            this.btnLock.AccessibleName = "Button";
            this.btnLock.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLock.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.Snow;
            this.btnLock.Image = ((System.Drawing.Image)(resources.GetObject("btnLock.Image")));
            this.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.Location = new System.Drawing.Point(-1, 460);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(213, 56);
            this.btnLock.Style.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLock.Style.DisabledBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLock.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnLock.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnLock.Style.ForeColor = System.Drawing.Color.Snow;
            this.btnLock.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnLock.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnLock.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnLock.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnLock.TabIndex = 8;
            this.btnLock.Text = "Sign Out";
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.BtnLock_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.AccessibleName = "Button";
            this.btnAboutUs.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAboutUs.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.Snow;
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(-1, 348);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(213, 56);
            this.btnAboutUs.Style.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAboutUs.Style.DisabledBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAboutUs.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnAboutUs.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAboutUs.Style.ForeColor = System.Drawing.Color.Snow;
            this.btnAboutUs.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnAboutUs.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAboutUs.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnAboutUs.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnAboutUs.TabIndex = 2;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.BtnAboutUs_Click);
            // 
            // btnMailBox
            // 
            this.btnMailBox.AccessibleName = "Button";
            this.btnMailBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMailBox.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailBox.ForeColor = System.Drawing.Color.Snow;
            this.btnMailBox.Image = ((System.Drawing.Image)(resources.GetObject("btnMailBox.Image")));
            this.btnMailBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailBox.Location = new System.Drawing.Point(-1, 292);
            this.btnMailBox.Name = "btnMailBox";
            this.btnMailBox.Size = new System.Drawing.Size(213, 56);
            this.btnMailBox.Style.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMailBox.Style.DisabledBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMailBox.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnMailBox.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnMailBox.Style.ForeColor = System.Drawing.Color.Snow;
            this.btnMailBox.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnMailBox.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnMailBox.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnMailBox.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnMailBox.TabIndex = 5;
            this.btnMailBox.Text = "Mail Box";
            this.btnMailBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailBox.UseVisualStyleBackColor = false;
            this.btnMailBox.Click += new System.EventHandler(this.BtnMailBox_Click);
            // 
            // btnLabourers
            // 
            this.btnLabourers.AccessibleName = "Button";
            this.btnLabourers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLabourers.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabourers.ForeColor = System.Drawing.Color.Snow;
            this.btnLabourers.Image = ((System.Drawing.Image)(resources.GetObject("btnLabourers.Image")));
            this.btnLabourers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabourers.Location = new System.Drawing.Point(-1, 236);
            this.btnLabourers.Name = "btnLabourers";
            this.btnLabourers.Size = new System.Drawing.Size(213, 56);
            this.btnLabourers.Style.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLabourers.Style.DisabledBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLabourers.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnLabourers.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnLabourers.Style.ForeColor = System.Drawing.Color.Snow;
            this.btnLabourers.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnLabourers.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnLabourers.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnLabourers.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnLabourers.TabIndex = 4;
            this.btnLabourers.Text = "Labourers";
            this.btnLabourers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabourers.UseVisualStyleBackColor = false;
            this.btnLabourers.Click += new System.EventHandler(this.BtnLabourers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AccessibleName = "Button";
            this.btnDashboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Snow;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-1, 180);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(213, 56);
            this.btnDashboard.Style.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.Style.DisabledBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnDashboard.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnDashboard.Style.ForeColor = System.Drawing.Color.Snow;
            this.btnDashboard.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnDashboard.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnDashboard.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnDashboard.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Job Listing";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // picHomeLogo
            // 
            this.picHomeLogo.Image = ((System.Drawing.Image)(resources.GetObject("picHomeLogo.Image")));
            this.picHomeLogo.Location = new System.Drawing.Point(46, 27);
            this.picHomeLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picHomeLogo.Name = "picHomeLogo";
            this.picHomeLogo.Size = new System.Drawing.Size(119, 112);
            this.picHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHomeLogo.TabIndex = 0;
            this.picHomeLogo.TabStop = false;
            // 
            // _panelMailBox
            // 
            this._panelMailBox.Controls.Add(this.webMail);
            this._panelMailBox.Controls.Add(this.label2);
            this._panelMailBox.Location = new System.Drawing.Point(227, 51);
            this._panelMailBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._panelMailBox.Name = "_panelMailBox";
            this._panelMailBox.Size = new System.Drawing.Size(1081, 662);
            this._panelMailBox.TabIndex = 3;
            // 
            // webMail
            // 
            this.webMail.Location = new System.Drawing.Point(0, 24);
            this.webMail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMail.Name = "webMail";
            this.webMail.ScriptErrorsSuppressed = true;
            this.webMail.Size = new System.Drawing.Size(1074, 633);
            this.webMail.TabIndex = 2;
            this.webMail.Url = new System.Uri("https://mail.zoho.com/zm/#mail/folder/inbox", System.UriKind.Absolute);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail Box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(969, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(92, 24);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "12:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(888, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(173, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "1 January 2019";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOpenJobs
            // 
            this.lblOpenJobs.AutoSize = true;
            this.lblOpenJobs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenJobs.Location = new System.Drawing.Point(15, 601);
            this.lblOpenJobs.Name = "lblOpenJobs";
            this.lblOpenJobs.Size = new System.Drawing.Size(100, 20);
            this.lblOpenJobs.TabIndex = 5;
            this.lblOpenJobs.Text = "Open Jobs : ";
            // 
            // _panelDashBoard
            // 
            this._panelDashBoard.Controls.Add(this.btnRefresh);
            this._panelDashBoard.Controls.Add(this.lblNotification);
            this._panelDashBoard.Controls.Add(this.comboSortJobs);
            this._panelDashBoard.Controls.Add(this.label4);
            this._panelDashBoard.Controls.Add(this.btnDelete);
            this._panelDashBoard.Controls.Add(this.btnAssignJob);
            this._panelDashBoard.Controls.Add(this.dgvJobRequests);
            this._panelDashBoard.Controls.Add(this.lblOpenJobs);
            this._panelDashBoard.Controls.Add(this.lblDate);
            this._panelDashBoard.Controls.Add(this.lblTime);
            this._panelDashBoard.Controls.Add(this.label1);
            this._panelDashBoard.Location = new System.Drawing.Point(227, 53);
            this._panelDashBoard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._panelDashBoard.Name = "_panelDashBoard";
            this._panelDashBoard.Size = new System.Drawing.Size(1081, 662);
            this._panelDashBoard.TabIndex = 2;
            this._panelDashBoard.Paint += new System.Windows.Forms.PaintEventHandler(this._panelDashBoard_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(850, 601);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 49);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNotification.Location = new System.Drawing.Point(540, 10);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(423, 25);
            this.lblNotification.TabIndex = 28;
            this.lblNotification.Text = ".";
            // 
            // comboSortJobs
            // 
            this.comboSortJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboSortJobs.ForeColor = System.Drawing.Color.Black;
            this.comboSortJobs.FormattingEnabled = true;
            this.comboSortJobs.Items.AddRange(new object[] {
            "None",
            "Welding",
            "Gardening",
            "Plumbing",
            "Carpentry",
            "Laundry",
            "Painting"});
            this.comboSortJobs.Location = new System.Drawing.Point(126, 30);
            this.comboSortJobs.Name = "comboSortJobs";
            this.comboSortJobs.Size = new System.Drawing.Size(160, 25);
            this.comboSortJobs.TabIndex = 22;
            this.comboSortJobs.SelectionChangeCommitted += new System.EventHandler(this.ComboSortJobs_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sort Jobs By";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(742, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 49);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Job";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignJob.Location = new System.Drawing.Point(962, 601);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(99, 49);
            this.btnAssignJob.TabIndex = 16;
            this.btnAssignJob.Text = "Assign Job";
            this.btnAssignJob.UseVisualStyleBackColor = false;
            this.btnAssignJob.Click += new System.EventHandler(this.BtnAssignJob_Click);
            // 
            // dgvJobRequests
            // 
            this.dgvJobRequests.AllowUserToAddRows = false;
            this.dgvJobRequests.AllowUserToDeleteRows = false;
            this.dgvJobRequests.AllowUserToResizeColumns = false;
            this.dgvJobRequests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvJobRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobRequests.AutoGenerateColumns = false;
            this.dgvJobRequests.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvJobRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJobRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobRequestIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeStartDataGridViewTextBoxColumn,
            this.timeEndDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.numOfLabourersDataGridViewTextBoxColumn,
            this.jobSpecificationDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.transportStatusDataGridViewCheckBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.assignedStatusDataGridViewCheckBoxColumn});
            this.dgvJobRequests.DataSource = this.jobRequestBindingSource;
            this.dgvJobRequests.Location = new System.Drawing.Point(7, 60);
            this.dgvJobRequests.MultiSelect = false;
            this.dgvJobRequests.Name = "dgvJobRequests";
            this.dgvJobRequests.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJobRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJobRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobRequests.Size = new System.Drawing.Size(1054, 515);
            this.dgvJobRequests.TabIndex = 6;
            this.dgvJobRequests.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJobRequests_RowEnter);
            // 
            // jobRequestIDDataGridViewTextBoxColumn
            // 
            this.jobRequestIDDataGridViewTextBoxColumn.DataPropertyName = "Job_Request_ID";
            this.jobRequestIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.jobRequestIDDataGridViewTextBoxColumn.Name = "jobRequestIDDataGridViewTextBoxColumn";
            this.jobRequestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobRequestIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStartDataGridViewTextBoxColumn
            // 
            this.timeStartDataGridViewTextBoxColumn.DataPropertyName = "Time_Start";
            this.timeStartDataGridViewTextBoxColumn.HeaderText = "Start";
            this.timeStartDataGridViewTextBoxColumn.Name = "timeStartDataGridViewTextBoxColumn";
            this.timeStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStartDataGridViewTextBoxColumn.Width = 60;
            // 
            // timeEndDataGridViewTextBoxColumn
            // 
            this.timeEndDataGridViewTextBoxColumn.DataPropertyName = "Time_End";
            this.timeEndDataGridViewTextBoxColumn.HeaderText = "End";
            this.timeEndDataGridViewTextBoxColumn.Name = "timeEndDataGridViewTextBoxColumn";
            this.timeEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeEndDataGridViewTextBoxColumn.Width = 60;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfLabourersDataGridViewTextBoxColumn
            // 
            this.numOfLabourersDataGridViewTextBoxColumn.DataPropertyName = "Num_Of_Labourers";
            this.numOfLabourersDataGridViewTextBoxColumn.HeaderText = "Labourers";
            this.numOfLabourersDataGridViewTextBoxColumn.Name = "numOfLabourersDataGridViewTextBoxColumn";
            this.numOfLabourersDataGridViewTextBoxColumn.ReadOnly = true;
            this.numOfLabourersDataGridViewTextBoxColumn.Width = 70;
            // 
            // jobSpecificationDataGridViewTextBoxColumn
            // 
            this.jobSpecificationDataGridViewTextBoxColumn.DataPropertyName = "Job_Specification";
            this.jobSpecificationDataGridViewTextBoxColumn.HeaderText = "Job_Specification";
            this.jobSpecificationDataGridViewTextBoxColumn.Name = "jobSpecificationDataGridViewTextBoxColumn";
            this.jobSpecificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobSpecificationDataGridViewTextBoxColumn.Width = 180;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 200;
            // 
            // transportStatusDataGridViewCheckBoxColumn
            // 
            this.transportStatusDataGridViewCheckBoxColumn.DataPropertyName = "Transport_Status";
            this.transportStatusDataGridViewCheckBoxColumn.HeaderText = "Transport_Status";
            this.transportStatusDataGridViewCheckBoxColumn.Name = "transportStatusDataGridViewCheckBoxColumn";
            this.transportStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.transportStatusDataGridViewCheckBoxColumn.Width = 110;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Payout";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignedStatusDataGridViewCheckBoxColumn
            // 
            this.assignedStatusDataGridViewCheckBoxColumn.DataPropertyName = "Assigned_Status";
            this.assignedStatusDataGridViewCheckBoxColumn.HeaderText = "Assigned_Status";
            this.assignedStatusDataGridViewCheckBoxColumn.Name = "assignedStatusDataGridViewCheckBoxColumn";
            this.assignedStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // jobRequestBindingSource
            // 
            this.jobRequestBindingSource.DataMember = "JobRequest";
            this.jobRequestBindingSource.DataSource = this.dsJobRequestt;
            // 
            // dsJobRequestt
            // 
            this.dsJobRequestt.DataSetName = "dsJobRequestt";
            this.dsJobRequestt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // _panelOnlineHelp
            // 
            this._panelOnlineHelp.Controls.Add(this.webOnlineHelp);
            this._panelOnlineHelp.Controls.Add(this.label5);
            this._panelOnlineHelp.Location = new System.Drawing.Point(227, 51);
            this._panelOnlineHelp.Name = "_panelOnlineHelp";
            this._panelOnlineHelp.Size = new System.Drawing.Size(1081, 662);
            this._panelOnlineHelp.TabIndex = 15;
            // 
            // webOnlineHelp
            // 
            this.webOnlineHelp.Location = new System.Drawing.Point(0, 34);
            this.webOnlineHelp.MinimumSize = new System.Drawing.Size(20, 20);
            this.webOnlineHelp.Name = "webOnlineHelp";
            this.webOnlineHelp.Size = new System.Drawing.Size(1081, 625);
            this.webOnlineHelp.TabIndex = 3;
            this.webOnlineHelp.Url = new System.Uri("file:///C:/Users/T4NY4/source/repos/iJob/Online%20help%20Html/OnlineHelpHtml.html" +
        "", System.UriKind.Absolute);
            this.webOnlineHelp.WebBrowserShortcutsEnabled = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Online Help";
            // 
            // jobRequestTableAdapter
            // 
            this.jobRequestTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 729);
            this.Controls.Add(this.panelMenus);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this._panelDashBoard);
            this.Controls.Add(this._panelMailBox);
            this.Controls.Add(this._panelOnlineHelp);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iJob Employment System";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panelMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHomeLogo)).EndInit();
            this._panelMailBox.ResumeLayout(false);
            this._panelMailBox.PerformLayout();
            this._panelDashBoard.ResumeLayout(false);
            this._panelDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobRequestt)).EndInit();
            this._panelOnlineHelp.ResumeLayout(false);
            this._panelOnlineHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelMenus;
        private System.Windows.Forms.PictureBox picHomeLogo;
        private Syncfusion.WinForms.Controls.SfButton btnDashboard;
        private Syncfusion.WinForms.Controls.SfButton btnLock;
        private Syncfusion.WinForms.Controls.SfButton btnMailBox;
        private Syncfusion.WinForms.Controls.SfButton btnLabourers;
        private Syncfusion.WinForms.Controls.SfButton btnAboutUs;
        private System.Windows.Forms.Panel _panelMailBox;
        private System.Windows.Forms.WebBrowser webMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOpenJobs;
        private System.Windows.Forms.Panel _panelDashBoard;
        private System.Windows.Forms.DataGridView dgvJobRequests;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboSortJobs;
        private System.Windows.Forms.Label label4;
        private Syncfusion.WinForms.Controls.SfButton btnSwitch;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel _panelOnlineHelp;
        private System.Windows.Forms.WebBrowser webOnlineHelp;
        private System.Windows.Forms.Label label5;
        private dsJobRequestt dsJobRequestt;
        private System.Windows.Forms.BindingSource jobRequestBindingSource;
        private dsJobRequesttTableAdapters.JobRequestTableAdapter jobRequestTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobRequestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfLabourersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobSpecificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transportStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn assignedStatusDataGridViewCheckBoxColumn;
    }
}

