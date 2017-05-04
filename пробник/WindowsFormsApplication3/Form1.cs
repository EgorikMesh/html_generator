using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // double a;

            String[] strLabel = {"Ананас","Арбуз","Киви","Апельсин","Манго","Яблоко","Виноград","Мандарин"};
            Random r = new Random();
            int iSelect = r.Next(0, 7);
            textBox1.Text = strLabel[iSelect];

            textBox3.Text = "я сожрал много\r\n" + textBox1.Text + "\r\n" + r + "\r\n" + textBox2 + "\r\nи все\r\n" + textBox3;

           // a = Convert.ToDouble(textBox4.Text);


            //for (int i = 0; i == a; i++) {}
            saveFileDialog1.FileName = "Новый HTML файл";
            saveFileDialog1.Filter = "HTML File | *.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, textBox3.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
