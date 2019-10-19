namespace iJob2019
{
    partial class frmOnlineHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOnlineHelp));
            this.webOnlineHelp = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webOnlineHelp
            // 
            this.webOnlineHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webOnlineHelp.Location = new System.Drawing.Point(0, 0);
            this.webOnlineHelp.MinimumSize = new System.Drawing.Size(20, 20);
            this.webOnlineHelp.Name = "webOnlineHelp";
            this.webOnlineHelp.Size = new System.Drawing.Size(1130, 722);
            this.webOnlineHelp.TabIndex = 0;
            // 
            // frmOnlineHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 722);
            this.Controls.Add(this.webOnlineHelp);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOnlineHelp";
            this.Text = "Online Help";
            this.Load += new System.EventHandler(this.FrmOnlineHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webOnlineHelp;
    }
}