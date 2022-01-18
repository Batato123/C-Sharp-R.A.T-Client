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
    public partial class Form10 : Form
    {
        public Form10()
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < progressBar1.Maximum; i++)
            {

                progressBar1.Value = i;
            }
        }
    }
}
