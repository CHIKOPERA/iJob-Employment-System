namespace iJob2019
{
    partial class frmEditLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditLab));
            this.lblNotification = new System.Windows.Forms.Label();
            this.txtNationality = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new Syncfusion.WinForms.Controls.SfButton();
            this.btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
            this.txtAddInfo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSkills = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtFName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLanguae = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIDDisplay = new System.Windows.Forms.Label();
            this.errorInpput = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.txtPostalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.txtState = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCity = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label7 = new System.Windows.Forms.Label();
            this.picLab = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInpput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(192, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(233, 20);
            this.lblNotification.TabIndex = 69;
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNotification.TextChanged += new System.EventHandler(this.LblNotification_TextChanged);
            // 
            // txtNationality
            // 
            this.txtNationality.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtNationality.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtNationality.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNationality.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtNationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationality.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtNationality.Location = new System.Drawing.Point(8, 383);
            this.txtNationality.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(195, 23);
            this.txtNationality.TabIndex = 50;
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCity_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(8, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "Birth Province";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Edit Labourer";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "Button";
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(268, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 53);
            this.btnClear.Style.BackColor = System.Drawing.Color.White;
            this.btnClear.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnClear.Style.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "Button";
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(348, 428);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 53);
            this.btnUpdate.Style.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnUpdate.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnUpdate.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnUpdate.Style.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnUpdate.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtAddInfo.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtAddInfo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAddInfo.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtAddInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddInfo.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtAddInfo.Location = new System.Drawing.Point(229, 285);
            this.txtAddInfo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAddInfo.Multiline = true;
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.Size = new System.Drawing.Size(191, 60);
            this.txtAddInfo.TabIndex = 54;
            this.txtAddInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddInfo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(226, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Additional Information";
            // 
            // txtSkills
            // 
            this.txtSkills.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtSkills.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtSkills.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSkills.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkills.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtSkills.Location = new System.Drawing.Point(227, 187);
            this.txtSkills.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSkills.Multiline = true;
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.Size = new System.Drawing.Size(191, 60);
            this.txtSkills.TabIndex = 53;
            this.txtSkills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSkills_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(224, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Skills";
            // 
            // txtLName
            // 
            this.txtLName.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtLName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtLName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLName.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtLName.Location = new System.Drawing.Point(12, 136);
            this.txtLName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(198, 23);
            this.txtLName.TabIndex = 44;
            this.txtLName.TextChanged += new System.EventHandler(this.TxtLName_TextChanged);
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLName_KeyPress);
            // 
            // txtFName
            // 
            this.txtFName.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtFName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtFName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFName.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtFName.Location = new System.Drawing.Point(12, 90);
            this.txtFName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(201, 23);
            this.txtFName.TabIndex = 43;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "First Name";
            // 
            // txtContact
            // 
            this.txtContact.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtContact.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtContact.BorderColor = System.Drawing.Color.DarkGray;
            this.txtContact.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtContact.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(12, 185);
            this.txtContact.MaxLength = 10;
            this.txtContact.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(201, 23);
            this.txtContact.TabIndex = 72;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContact_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Cell Phone Number";
            // 
            // comboLanguae
            // 
            this.comboLanguae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguae.FormattingEnabled = true;
            this.comboLanguae.Items.AddRange(new object[] {
            "Afrikaan",
            "English",
            "isiNdebele",
            "isiXhosa",
            "isiZulu",
            "Sesotho",
            "Sipedi",
            "Setwana",
            "siSwati",
            "TsiVenda",
            "Xitsonga"});
            this.comboLanguae.Location = new System.Drawing.Point(227, 382);
            this.comboLanguae.Name = "comboLanguae";
            this.comboLanguae.Size = new System.Drawing.Size(200, 24);
            this.comboLanguae.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(226, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Language";
            // 
            // lblIDDisplay
            // 
            this.lblIDDisplay.AutoSize = true;
            this.lblIDDisplay.Location = new System.Drawing.Point(12, 34);
            this.lblIDDisplay.Name = "lblIDDisplay";
            this.lblIDDisplay.Size = new System.Drawing.Size(23, 16);
            this.lblIDDisplay.TabIndex = 75;
            this.lblIDDisplay.Text = "ID";
            // 
            // errorInpput
            // 
            this.errorInpput.ContainerControl = this;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtPostalCode.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtPostalCode.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPostalCode.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtPostalCode.Location = new System.Drawing.Point(138, 330);
            this.txtPostalCode.MaxLength = 4;
            this.txtPostalCode.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(72, 23);
            this.txtPostalCode.TabIndex = 79;
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPostalCode_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(135, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 83;
            this.label13.Text = "Postal Code";
            // 
            // txtState
            // 
            this.txtState.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtState.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtState.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtState.Location = new System.Drawing.Point(15, 330);
            this.txtState.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(115, 23);
            this.txtState.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(12, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "Province";
            // 
            // txtCity
            // 
            this.txtCity.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtCity.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtCity.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCity.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtCity.Location = new System.Drawing.Point(15, 285);
            this.txtCity.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(195, 23);
            this.txtCity.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.BeforeTouchSize = new System.Drawing.Size(201, 23);
            this.txtStreet.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtStreet.BorderColor = System.Drawing.Color.DarkGray;
            this.txtStreet.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtStreet.Location = new System.Drawing.Point(12, 240);
            this.txtStreet.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(198, 23);
            this.txtStreet.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 80;
            this.label7.Text = "Street Address";
            // 
            // picLab
            // 
            this.picLab.Location = new System.Drawing.Point(254, 34);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(134, 125);
            this.picLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLab.TabIndex = 84;
            this.picLab.TabStop = false;
            // 
            // frmEditLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 488);
            this.Controls.Add(this.picLab);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIDDisplay);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboLanguae);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAddInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Labourer";
            this.Load += new System.EventHandler(this.FrmEditLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInpput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotification;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNationality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Controls.SfButton btnClear;
        private Syncfusion.WinForms.Controls.SfButton btnUpdate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAddInfo;
        private System.Windows.Forms.Label label9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSkills;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboLanguae;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIDDisplay;
        private System.Windows.Forms.ErrorProvider errorInpput;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.PictureBox picLab;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPostalCode;
        private System.Windows.Forms.Label label13;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtState;
        private System.Windows.Forms.Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCity;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStreet;
        private System.Windows.Forms.Label label7;
    }
}