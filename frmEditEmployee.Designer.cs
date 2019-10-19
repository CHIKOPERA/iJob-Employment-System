namespace iJob2019
{
    partial class frmEditEmployee
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
            this.picLab = new System.Windows.Forms.PictureBox();
            this.txtPostalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.txtState = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCity = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.errorInpput = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblIDDisplay = new System.Windows.Forms.Label();
            this.txtContact = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new Syncfusion.WinForms.Controls.SfButton();
            this.btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
            this.txtLName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErLastName = new System.Windows.Forms.Label();
            this.lblErCell = new System.Windows.Forms.Label();
            this.lblErStrtAddress = new System.Windows.Forms.Label();
            this.lblErProAndZip = new System.Windows.Forms.Label();
            this.lblErCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInpput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).BeginInit();
            this.SuspendLayout();
            // 
            // picLab
            // 
            this.picLab.Location = new System.Drawing.Point(28, 49);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(134, 125);
            this.picLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLab.TabIndex = 112;
            this.picLab.TabStop = false;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BeforeTouchSize = new System.Drawing.Size(173, 20);
            this.txtPostalCode.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtPostalCode.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPostalCode.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtPostalCode.Location = new System.Drawing.Point(194, 280);
            this.txtPostalCode.MaxLength = 4;
            this.txtPostalCode.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(90, 20);
            this.txtPostalCode.TabIndex = 107;
            this.txtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(189, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 111;
            this.label13.Text = "Postal Code";
            // 
            // txtState
            // 
            this.txtState.BeforeTouchSize = new System.Drawing.Size(173, 20);
            this.txtState.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtState.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtState.Location = new System.Drawing.Point(192, 211);
            this.txtState.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(173, 20);
            this.txtState.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(189, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 110;
            this.label12.Text = "Province";
            // 
            // txtCity
            // 
            this.txtCity.BeforeTouchSize = new System.Drawing.Size(173, 20);
            this.txtCity.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtCity.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCity.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtCity.Location = new System.Drawing.Point(12, 280);
            this.txtCity.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(171, 20);
            this.txtCity.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.BeforeTouchSize = new System.Drawing.Size(173, 20);
            this.txtStreet.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtStreet.BorderColor = System.Drawing.Color.DarkGray;
            this.txtStreet.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtStreet.Location = new System.Drawing.Point(14, 211);
            this.txtStreet.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(172, 20);
            this.txtStreet.TabIndex = 104;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            // 
            // errorInpput
            // 
            this.errorInpput.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(14, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Street Address";
            // 
            // lblIDDisplay
            // 
            this.lblIDDisplay.AutoSize = true;
            this.lblIDDisplay.Location = new System.Drawing.Point(200, 24);
            this.lblIDDisplay.Name = "lblIDDisplay";
            this.lblIDDisplay.Size = new System.Drawing.Size(18, 13);
            this.lblIDDisplay.TabIndex = 103;
            this.lblIDDisplay.Text = "ID";
            // 
            // txtContact
            // 
            this.txtContact.BeforeTouchSize = new System.Drawing.Size(173, 20);
            this.txtContact.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtContact.BorderColor = System.Drawing.Color.DarkGray;
            this.txtContact.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtContact.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(193, 130);
            this.txtContact.MaxLength = 10;
            this.txtContact.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(172, 23);
            this.txtContact.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(190, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Cell Phone Number";
            // 
            // lblNotification
            // 
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(190, 4);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(233, 20);
            this.lblNotification.TabIndex = 98;
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Edit Employee";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "Button";
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(225, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 37);
            this.btnClear.Style.BackColor = System.Drawing.Color.White;
            this.btnClear.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnClear.Style.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnClear.TabIndex = 93;
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
            this.btnUpdate.Location = new System.Drawing.Point(304, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 37);
            this.btnUpdate.Style.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnUpdate.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnUpdate.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnUpdate.Style.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnUpdate.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnUpdate.TabIndex = 92;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtLName
            // 
            this.txtLName.BeforeTouchSize = new System.Drawing.Size(173, 20);
            this.txtLName.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtLName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLName.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.txtLName.Location = new System.Drawing.Point(194, 76);
            this.txtLName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(171, 20);
            this.txtLName.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(191, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Last Name";
            // 
            // lblErLastName
            // 
            this.lblErLastName.AutoSize = true;
            this.lblErLastName.ForeColor = System.Drawing.Color.Red;
            this.lblErLastName.Location = new System.Drawing.Point(190, 99);
            this.lblErLastName.Name = "lblErLastName";
            this.lblErLastName.Size = new System.Drawing.Size(104, 13);
            this.lblErLastName.TabIndex = 113;
            this.lblErLastName.Text = "Please fill empty field";
            this.lblErLastName.Visible = false;
            // 
            // lblErCell
            // 
            this.lblErCell.AutoSize = true;
            this.lblErCell.ForeColor = System.Drawing.Color.Red;
            this.lblErCell.Location = new System.Drawing.Point(190, 161);
            this.lblErCell.Name = "lblErCell";
            this.lblErCell.Size = new System.Drawing.Size(104, 13);
            this.lblErCell.TabIndex = 114;
            this.lblErCell.Text = "Please fill empty field";
            this.lblErCell.Visible = false;
            // 
            // lblErStrtAddress
            // 
            this.lblErStrtAddress.AutoSize = true;
            this.lblErStrtAddress.ForeColor = System.Drawing.Color.Red;
            this.lblErStrtAddress.Location = new System.Drawing.Point(11, 234);
            this.lblErStrtAddress.Name = "lblErStrtAddress";
            this.lblErStrtAddress.Size = new System.Drawing.Size(104, 13);
            this.lblErStrtAddress.TabIndex = 115;
            this.lblErStrtAddress.Text = "Please fill empty field";
            this.lblErStrtAddress.Visible = false;
            // 
            // lblErProAndZip
            // 
            this.lblErProAndZip.AutoSize = true;
            this.lblErProAndZip.ForeColor = System.Drawing.Color.Red;
            this.lblErProAndZip.Location = new System.Drawing.Point(210, 303);
            this.lblErProAndZip.Name = "lblErProAndZip";
            this.lblErProAndZip.Size = new System.Drawing.Size(104, 13);
            this.lblErProAndZip.TabIndex = 116;
            this.lblErProAndZip.Text = "Please fill empty field";
            this.lblErProAndZip.Visible = false;
            // 
            // lblErCity
            // 
            this.lblErCity.AutoSize = true;
            this.lblErCity.ForeColor = System.Drawing.Color.Red;
            this.lblErCity.Location = new System.Drawing.Point(12, 303);
            this.lblErCity.Name = "lblErCity";
            this.lblErCity.Size = new System.Drawing.Size(104, 13);
            this.lblErCity.TabIndex = 117;
            this.lblErCity.Text = "Please fill empty field";
            this.lblErCity.Visible = false;
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 379);
            this.Controls.Add(this.lblErCity);
            this.Controls.Add(this.lblErProAndZip);
            this.Controls.Add(this.lblErStrtAddress);
            this.Controls.Add(this.lblErCell);
            this.Controls.Add(this.lblErLastName);
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
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.FrmEditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInpput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLab;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPostalCode;
        private System.Windows.Forms.Label label13;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtState;
        private System.Windows.Forms.Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCity;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStreet;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ErrorProvider errorInpput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIDDisplay;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Controls.SfButton btnClear;
        private Syncfusion.WinForms.Controls.SfButton btnUpdate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErCity;
        private System.Windows.Forms.Label lblErProAndZip;
        private System.Windows.Forms.Label lblErStrtAddress;
        private System.Windows.Forms.Label lblErCell;
        private System.Windows.Forms.Label lblErLastName;
    }
}