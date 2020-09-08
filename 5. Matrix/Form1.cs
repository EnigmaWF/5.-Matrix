using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*5. Дана действительная матрица mxn
                 Напишите программу, которая выводит числа b1,...,bm
                 равные соответственно минимальным значениям элементов в столбцах*/

            //ввод массива
            string s = ""; //для вывода
            int[,] a = new int[Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)]; //[m,n]
            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++) //m строка
            {
                for (int j = 0; j < Convert.ToInt32(textBox3.Text); j++)//n столбец
                {
                    try
                    {
                        a[i, j] = int.Parse(textBox1.Lines[i * Convert.ToInt32(textBox3.Text) + j]);
                        s += a[i, j];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при вводе числа " + ex.Message);
                        return;
                    }
                }
                s += "\n";
            }
            label1.Text = "" + s;
            //              
            int min = 9999999; //минимум
            s = "";
            for (int i = 0; i < Convert.ToInt32(textBox3.Text); i++) //n столбец
            {
                for (int j = 0; j < Convert.ToInt32(textBox2.Text); j++)//m строка
                {
                    if (a[j, i] < min)
                    {
                        min = a[j, i]; //[строка, стобец]
                    }
                }
                s += "  " + min;
                min = 99999999;
            }
            label1.Text += "\n" + s;
        }
    }
}
