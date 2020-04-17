using System;
using System.IO;
using System.Windows.Forms;

namespace ProbaPera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // MessageBox("ткнул сюда");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(@"c:\users\via\desctop\1.bmp");
            File.Delete(@"c:\users\via\desctop\2.bmp");
            //button1.Text += "А";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text += "А";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ткнули в галку");
        }

        private void примерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("выбрали меня");
        }
    }
}
