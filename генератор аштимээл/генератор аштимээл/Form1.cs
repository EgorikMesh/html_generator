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

namespace генератор_аштимээл
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // \r\n
        {
           
            String[] strLabel = { "First Label", "second Label", "third Label" };
            Random r = new Random();
            int iSelect = r.Next(0, 2);
            textBox1.Text = strLabel[iSelect];

            textBox1.Text = "<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n<head>\r\n<meta charset=\"utf-8\">\r\n<title>Сайт</title>\r\n<style type=\"text/css\"></style>\r\n</head>\r\n<body>\r\n<div>\r\n<p>" + textBox1.Text + r + "</p>\r\n</div>\r\n</body>\r\n</html>";

            saveFileDialog1.FileName = "Новый HTML файл";
            saveFileDialog1.Filter = "HTML File | *.html";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
