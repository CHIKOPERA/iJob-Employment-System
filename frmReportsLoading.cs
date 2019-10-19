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
    public partial class frmReportsLoading : Form
    {
        public frmReportsLoading()
        {
            InitializeComponent();
        }
        int counter = 12;
        private void TimerLoading_Tick(object sender, EventArgs e)
        {

            if (counter>0)
            {
                if (counter % 2 == 0)
                {
                    lblLoading.Text = $"{counter} seconds remaining \\";
                }
                else
                {
                    lblLoading.Text = $"{counter} seconds remaining /";
                }
                counter--;
            }
            else
            {
                this.Close();
            }
        }
    }
}
