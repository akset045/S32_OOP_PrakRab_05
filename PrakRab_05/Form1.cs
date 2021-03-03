using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrakRab_05
{
    public partial class Form1 : Form
    {
        private Stopwatch st;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            st = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", st.Elapsed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            st.Stop();
        }
    }
}
