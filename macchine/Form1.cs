using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macchine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int velocità = 0;
            Random rand = new Random(85);
            while (pictureBox2.Location.X < pictureBox4.Location.X)
            {

                velocità = rand.Next(0,20);
                pictureBox2.Location = new Point(pictureBox2.Location.X + velocità, pictureBox2.Location.Y);
                System.Threading.Thread.Sleep(100);
            }

            backgroundWorker1.CancelAsync();

        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int velocità = 0;
            Random rand = new Random(95);
            while (pictureBox3.Location.X < pictureBox4.Location.X)
            {

                velocità = rand.Next(0,59);
                pictureBox3.Location = new Point(pictureBox3.Location.X + velocità, pictureBox3.Location.Y);
                System.Threading.Thread.Sleep(100);
            }

            backgroundWorker2.CancelAsync();

        }

       
    }
}
