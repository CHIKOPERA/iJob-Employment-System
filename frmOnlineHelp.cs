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
    public partial class frmOnlineHelp : Form
    {
        public frmOnlineHelp()
        {
            InitializeComponent();
        }

        private void FrmOnlineHelp_Load(object sender, EventArgs e)
        {
            webOnlineHelp.Navigate(@"C:\Users\T4NY4\source\repos\iJob2019\PROJECT BACKUP\iJob2019 08_05_2019\Files\Online help.pdf");
        }
    }
}
