namespace iJob2019
{
    partial class frmJobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobs));
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAssignedTo = new System.Windows.Forms.GroupBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picLabourer = new System.Windows.Forms.PictureBox();
            this.groupAssignedBy = new System.Windows.Forms.GroupBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmpSurname = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.groupTransDetails = new System.Windows.Forms.GroupBox();
            this.lblTransportProvider = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.groupAssignedTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLabourer)).BeginInit();
            this.groupAssignedBy.SuspendLayout();
            this.groupTransDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(720, 515);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(83, 32);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "Reverse ";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(631, 515);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AllowUserToResizeColumns = false;
            this.dgvJobs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobs.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvJobs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJobs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(3, 34);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJobs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(807, 326);
            this.dgvJobs.TabIndex = 7;
            this.dgvJobs.SelectionChanged += new System.EventHandler(this.dgvJobs_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jobs in Transit :)";
            // 
            // groupAssignedTo
            // 
            this.groupAssignedTo.Controls.Add(this.lblSkill);
            this.groupAssignedTo.Controls.Add(this.lblSurname);
            this.groupAssignedTo.Controls.Add(this.lblName);
            this.groupAssignedTo.Controls.Add(this.picLabourer);
            this.groupAssignedTo.Location = new System.Drawing.Point(3, 366);
            this.groupAssignedTo.Name = "groupAssignedTo";
            this.groupAssignedTo.Size = new System.Drawing.Size(257, 143);
            this.groupAssignedTo.TabIndex = 9;
            this.groupAssignedTo.TabStop = false;
            this.groupAssignedTo.Text = "Assigned To:";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSkill.Location = new System.Drawing.Point(103, 86);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(41, 18);
            this.lblSkill.TabIndex = 49;
            this.lblSkill.Text = "Skill";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSurname.Location = new System.Drawing.Point(103, 54);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 18);
            this.lblSurname.TabIndex = 48;
            this.lblSurname.Text = "Last name";
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblName.Location = new System.Drawing.Point(103, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 28);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Name";
            // 
            // picLabourer
            // 
            this.picLabourer.Location = new System.Drawing.Point(7, 26);
            this.picLabourer.Name = "picLabourer";
            this.picLabourer.Size = new System.Drawing.Size(90, 88);
            this.picLabourer.TabIndex = 0;
            this.picLabourer.TabStop = false;
            // 
            // groupAssignedBy
            // 
            this.groupAssignedBy.Controls.Add(this.lblEmpID);
            this.groupAssignedBy.Controls.Add(this.lblEmpSurname);
            this.groupAssignedBy.Controls.Add(this.lblEmpName);
            this.groupAssignedBy.Location = new System.Drawing.Point(280, 366);
            this.groupAssignedBy.Name = "groupAssignedBy";
            this.groupAssignedBy.Size = new System.Drawing.Size(257, 143);
            this.groupAssignedBy.TabIndex = 50;
            this.groupAssignedBy.TabStop = false;
            this.groupAssignedBy.Text = "Assigned By:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmpID.Location = new System.Drawing.Point(6, 26);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(100, 18);
            this.lblEmpID.TabIndex = 49;
            this.lblEmpID.Text = "Employee ID";
            // 
            // lblEmpSurname
            // 
            this.lblEmpSurname.AutoSize = true;
            this.lblEmpSurname.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmpSurname.Location = new System.Drawing.Point(6, 82);
            this.lblEmpSurname.Name = "lblEmpSurname";
            this.lblEmpSurname.Size = new System.Drawing.Size(81, 18);
            this.lblEmpSurname.TabIndex = 48;
            this.lblEmpSurname.Text = "Last name";
            // 
            // lblEmpName
            // 
            this.lblEmpName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmpName.Location = new System.Drawing.Point(6, 54);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(141, 28);
            this.lblEmpName.TabIndex = 47;
            this.lblEmpName.Text = "Name";
            // 
            // groupTransDetails
            // 
            this.groupTransDetails.Controls.Add(this.lblTransportProvider);
            this.groupTransDetails.Controls.Add(this.lblDriverName);
            this.groupTransDetails.Location = new System.Drawing.Point(566, 366);
            this.groupTransDetails.Name = "groupTransDetails";
            this.groupTransDetails.Size = new System.Drawing.Size(257, 143);
            this.groupTransDetails.TabIndex = 51;
            this.groupTransDetails.TabStop = false;
            this.groupTransDetails.Text = "Transport Provider";
            // 
            // lblTransportProvider
            // 
            this.lblTransportProvider.AutoSize = true;
            this.lblTransportProvider.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTransportProvider.Location = new System.Drawing.Point(6, 26);
            this.lblTransportProvider.Name = "lblTransportProvider";
            this.lblTransportProvider.Size = new System.Drawing.Size(100, 18);
            this.lblTransportProvider.TabIndex = 49;
            this.lblTransportProvider.Text = "Employee ID";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDriverName.Location = new System.Drawing.Point(6, 54);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(81, 18);
            this.lblDriverName.TabIndex = 48;
            this.lblDriverName.Text = "Last name";
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 558);
            this.Controls.Add(this.groupTransDetails);
            this.Controls.Add(this.groupAssignedBy);
            this.Controls.Add(this.groupAssignedTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReverse);
            this.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJobs";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Jobs";
            this.Load += new System.EventHandler(this.frmJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.groupAssignedTo.ResumeLayout(false);
            this.groupAssignedTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLabourer)).EndInit();
            this.groupAssignedBy.ResumeLayout(false);
            this.groupAssignedBy.PerformLayout();
            this.groupTransDetails.ResumeLayout(false);
            this.groupTransDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupAssignedTo;
        private System.Windows.Forms.PictureBox picLabourer;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupAssignedBy;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblEmpSurname;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.GroupBox groupTransDetails;
        private System.Windows.Forms.Label lblTransportProvider;
        private System.Windows.Forms.Label lblDriverName;
    }
}