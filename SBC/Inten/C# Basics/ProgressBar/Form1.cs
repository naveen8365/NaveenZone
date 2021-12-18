using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = true;           //Visible
            ToolTip toolTip = new ToolTip();        //ToolTipText
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(progressBar1, "ITAG");


            progressBar1.Minimum = 0;        //min
            progressBar1.Value = 60;         //value
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Top = 20;        //Top
            progressBar1.Width = 100;        //Width
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }
    }
}
