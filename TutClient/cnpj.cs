using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutClient
{
    public partial class cnpj : Form
    {
        public cnpj()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnpj_Load(object sender, EventArgs e)
        {
           // progressBar1.Value = 0;
            //if (progressBar1.Value != 100)
            //{
            //    for (int i = 0; i < progressBar1.Maximum; i++)
            //    {

            ///        progressBar1.Value = i;
           //     }
           // }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
                //| ProgressBarStyle.Continuous;
        }
    }
}
