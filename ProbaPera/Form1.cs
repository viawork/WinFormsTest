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
            /*
            File.Delete(@"c:\users\via\desctop\1.bmp");
            File.Delete(@"c:\users\via\desctop\2.bmp");
            */
            //button1.Text += "А";
           // var coord = new System.Drawing.Point(50, 20);
            System.Drawing.Point Coord = button2.Location;
            Coord.X +=  100;
            button2.Location = Coord;
            if (Coord.X > Size.Width)
            {
                MessageBox.Show("Але, гараж, куда поехал ");
                Coord.X = 10;
                button2.Location = Coord;
            }

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

        

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(450, 50);
            
            button1.Size = new System.Drawing.Size(50, 20);

        }
    }
}
