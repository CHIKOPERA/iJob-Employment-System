using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public partial class frmNetwork : Form
    {
        public frmNetwork()
        {
            InitializeComponent();
        }

        private void FrmNetwork_Load(object sender, EventArgs e)
        {
            lblMessage.Text = frmMain.networkErrorMsg;
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            Form form = new frmMain()
           ;form.Show();
            this.Dispose();
        }
    }
}
