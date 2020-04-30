using System;
using System.IO;
using System.Windows.Forms;

namespace ProbaPera
{
    public partial class MainForm : Form
    {
        string formHeader = "Заголовок формы";
        public MainForm()
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
            */
           // var coord = new System.Drawing.Point(50, 20);
            System.Drawing.Point Coord = button2.Location;
            Coord.X +=  100;
            button2.Location = Coord;
            if (Coord.X > Size.Width)
            {
                MessageBox.Show($@"Але, гараж, ширина уже - {Size.Width} 
                                    куда поехал ?");
                Coord.X = 10;
                button2.Location = Coord;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
/*            
            double num = 123.456;
            var simpleVar = "переменная строкового типа";
            button3.Text =""+num;
            label1.Text = simpleVar;
            button1.Text += "А";
            Text = formHeader;
            */
            {
                int age = 33;
                string textAge = Convert.ToString(age);

            }

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

        private void button3_Click(object sender, EventArgs e)
        {

            //MessageBox.Show($"Ширина формы - {Size.Width}     ");
            MessageBox.Show($@"Ширина формы - {Size.Width}
Высота формы - {Size.Height}     ");

            // тоже самое через \n
            MessageBox.Show($"Ширина формы - {Size.Width} \nВысота формы - {Size.Height}");


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
;