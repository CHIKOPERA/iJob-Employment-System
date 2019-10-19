namespace iJob2019
{
    partial class frmCameraCapcs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Reports = new System.Windows.Forms.TabControl();
            this.jobRequests = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabJobRequest = new System.Windows.Forms.TabPage();
            this.reportViewerJobR = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.chartRequests = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWeeklyRequests = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWeelyPayment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumofClients = new System.Windows.Forms.Label();
            this.lbllNumofLabourers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumofEmp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumofRequest = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChrtRX_axis = new System.Windows.Forms.Label();
            this.lblChrtPayXaxis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Reports.SuspendLayout();
            this.jobRequests.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabJobRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeeklyRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeelyPayment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.jobRequests);
            this.Reports.Controls.Add(this.tabPage2);
            this.Reports.Controls.Add(this.tabJobRequest);
            this.Reports.Location = new System.Drawing.Point(12, 12);
            this.Reports.Name = "Reports";
            this.Reports.SelectedIndex = 0;
            this.Reports.Size = new System.Drawing.Size(1235, 498);
            this.Reports.TabIndex = 1;
            // 
            // jobRequests
            // 
            this.jobRequests.Controls.Add(this.groupBox4);
            this.jobRequests.Controls.Add(this.groupBox3);
            this.jobRequests.Controls.Add(this.groupBox2);
            this.jobRequests.Controls.Add(this.groupBox1);
            this.jobRequests.Location = new System.Drawing.Point(4, 22);
            this.jobRequests.Name = "jobRequests";
            this.jobRequests.Padding = new System.Windows.Forms.Padding(3);
            this.jobRequests.Size = new System.Drawing.Size(1227, 472);
            this.jobRequests.TabIndex = 0;
            this.jobRequests.Text = "Report Dashboard";
            this.jobRequests.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.crystalReportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1227, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Financial Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1221, 466);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabJobRequest
            // 
            this.tabJobRequest.Controls.Add(this.reportViewerJobR);
            this.tabJobRequest.Location = new System.Drawing.Point(4, 22);
            this.tabJobRequest.Name = "tabJobRequest";
            this.tabJobRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobRequest.Size = new System.Drawing.Size(1227, 472);
            this.tabJobRequest.TabIndex = 2;
            this.tabJobRequest.Text = "Job Request";
            this.tabJobRequest.UseVisualStyleBackColor = true;
            // 
            // reportViewerJobR
            // 
            this.reportViewerJobR.ActiveViewIndex = -1;
            this.reportViewerJobR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewerJobR.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewerJobR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerJobR.Location = new System.Drawing.Point(3, 3);
            this.reportViewerJobR.Name = "reportViewerJobR";
            this.reportViewerJobR.Size = new System.Drawing.Size(1221, 466);
            this.reportViewerJobR.TabIndex = 0;
            this.reportViewerJobR.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // chartRequests
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRequests.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRequests.Legends.Add(legend3);
            this.chartRequests.Location = new System.Drawing.Point(6, 19);
            this.chartRequests.Name = "chartRequests";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Requests";
            this.chartRequests.Series.Add(series3);
            this.chartRequests.Size = new System.Drawing.Size(396, 304);
            this.chartRequests.TabIndex = 1;
            this.chartRequests.Text = "Job Request";
            this.chartRequests.Click += new System.EventHandler(this.ChartRequests_Click);
            // 
            // chartWeeklyRequests
            // 
            chartArea2.Name = "ChartArea1";
            this.chartWeeklyRequests.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWeeklyRequests.Legends.Add(legend2);
            this.chartWeeklyRequests.Location = new System.Drawing.Point(53, 36);
            this.chartWeeklyRequests.Name = "chartWeeklyRequests";
            this.chartWeeklyRequests.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Request";
            this.chartWeeklyRequests.Series.Add(series2);
            this.chartWeeklyRequests.Size = new System.Drawing.Size(336, 249);
            this.chartWeeklyRequests.TabIndex = 2;
            this.chartWeeklyRequests.Text = "Request";
            // 
            // chartWeelyPayment
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeelyPayment.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeelyPayment.Legends.Add(legend1);
            this.chartWeelyPayment.Location = new System.Drawing.Point(47, 48);
            this.chartWeelyPayment.Name = "chartWeelyPayment";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Payments";
            this.chartWeelyPayment.Series.Add(series1);
            this.chartWeelyPayment.Size = new System.Drawing.Size(311, 237);
            this.chartWeelyPayment.TabIndex = 3;
            this.chartWeelyPayment.Text = "Request";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumofEmp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbllNumofLabourers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNumofClients);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(448, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iJob Statics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered Clients";
            // 
            // lblNumofClients
            // 
            this.lblNumofClients.AutoSize = true;
            this.lblNumofClients.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumofClients.Location = new System.Drawing.Point(163, 20);
            this.lblNumofClients.Name = "lblNumofClients";
            this.lblNumofClients.Size = new System.Drawing.Size(22, 16);
            this.lblNumofClients.TabIndex = 1;
            this.lblNumofClients.Text = "53";
            // 
            // lbllNumofLabourers
            // 
            this.lbllNumofLabourers.AutoSize = true;
            this.lbllNumofLabourers.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllNumofLabourers.Location = new System.Drawing.Point(163, 43);
            this.lbllNumofLabourers.Name = "lbllNumofLabourers";
            this.lbllNumofLabourers.Size = new System.Drawing.Size(22, 16);
            this.lbllNumofLabourers.TabIndex = 3;
            this.lbllNumofLabourers.Text = "64";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Registered Labourers";
            // 
            // lblNumofEmp
            // 
            this.lblNumofEmp.AutoSize = true;
            this.lblNumofEmp.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumofEmp.Location = new System.Drawing.Point(163, 65);
            this.lblNumofEmp.Name = "lblNumofEmp";
            this.lblNumofEmp.Size = new System.Drawing.Size(15, 16);
            this.lblNumofEmp.TabIndex = 5;
            this.lblNumofEmp.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Employees";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(95, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "TOTAL REQUESTS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumofRequest
            // 
            this.lblNumofRequest.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumofRequest.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNumofRequest.Location = new System.Drawing.Point(107, 151);
            this.lblNumofRequest.Name = "lblNumofRequest";
            this.lblNumofRequest.Size = new System.Drawing.Size(58, 32);
            this.lblNumofRequest.TabIndex = 8;
            this.lblNumofRequest.Text = "25";
            this.lblNumofRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblNumofRequest);
            this.groupBox2.Controls.Add(this.chartRequests);
            this.groupBox2.Location = new System.Drawing.Point(6, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 429);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job Request";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblChrtRX_axis);
            this.groupBox3.Controls.Add(this.chartWeeklyRequests);
            this.groupBox3.Location = new System.Drawing.Point(448, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 323);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daily Job Request";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblChrtPayXaxis);
            this.groupBox4.Controls.Add(this.chartWeelyPayment);
            this.groupBox4.Location = new System.Drawing.Point(847, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 323);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payments Per Week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Requests";
            // 
            // lblChrtRX_axis
            // 
            this.lblChrtRX_axis.AutoSize = true;
            this.lblChrtRX_axis.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChrtRX_axis.Location = new System.Drawing.Point(163, 269);
            this.lblChrtRX_axis.Name = "lblChrtRX_axis";
            this.lblChrtRX_axis.Size = new System.Drawing.Size(38, 16);
            this.lblChrtRX_axis.TabIndex = 6;
            this.lblChrtRX_axis.Text = "Days";
            // 
            // lblChrtPayXaxis
            // 
            this.lblChrtPayXaxis.AutoSize = true;
            this.lblChrtPayXaxis.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChrtPayXaxis.Location = new System.Drawing.Point(128, 269);
            this.lblChrtPayXaxis.Name = "lblChrtPayXaxis";
            this.lblChrtPayXaxis.Size = new System.Drawing.Size(38, 16);
            this.lblChrtPayXaxis.TabIndex = 7;
            this.lblChrtPayXaxis.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount R";
            // 
            // frmCameraCapcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 544);
            this.Controls.Add(this.Reports);
            this.Name = "frmCameraCapcs";
            this.Text = "frmCameraCapcs";
            this.Load += new System.EventHandler(this.FrmCameraCapcs_Load);
            this.Reports.ResumeLayout(false);
            this.jobRequests.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabJobRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeeklyRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeelyPayment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Reports;
        private System.Windows.Forms.TabPage jobRequests;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TabPage tabJobRequest;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewerJobR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRequests;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeeklyRequests;
        private System.Windows.Forms.Label lblNumofRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumofEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbllNumofLabourers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumofClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeelyPayment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChrtRX_axis;
        private System.Windows.Forms.Label lblChrtPayXaxis;
        private System.Windows.Forms.Label label3;
    }
}