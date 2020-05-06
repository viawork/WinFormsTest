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


        private void button1_Click(object sender, EventArgs e)
        {
            
           // var coord = new System.Drawing.Point(50, 20);
            System.Drawing.Point coord = button2.Location;
            coord.X +=  100;
            button2.Location = coord;
            if (coord.X > Size.Width)
            {
                if (MessageBox.Show($@"Але, гараж, ширина уже - {Size.Width}\n 
                                    Продолжить ?", "Вопрос", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    coord.X = Size.Width- button2.Size.Width;
                    button2.Location = coord;
                }
                else
                {
                    MessageBox.Show("Кнопка за пределами формы!", "Предупреждение",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    coord.X = 0;
                    button2.Location = coord;
                }
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                int age = 33;
                string textAge = Convert.ToString(age);
                Text = formHeader +$" шириной {Width} pxl";
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
            /*
            button1.Location = new System.Drawing.Point(450, 50);
            button1.Size = new System.Drawing.Size(50, 20);
            */
            string fileName = @"C:\Users\VIA\Desktop\Новый точечный рисунок.bmp";
            if (File.Exists(fileName))
            {
                labelResult.Text = $"Файл {fileName} существует";
                File.Delete(fileName);
            }
            else
            {
                labelResult.Text = $"Файл {fileName} был удален !";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Ширина формы - {Size.Width}
Высота формы - {Size.Height}     ");
            // тоже самое через \n
            MessageBox.Show($"Ширина формы - {Size.Width} \nВысота формы - {Size.Height}");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
;