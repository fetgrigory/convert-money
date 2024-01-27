using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convert_money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                string from, to;

                from = listBox1.SelectedItem.ToString(); // выбранная валюта в 1 списке
                to = listBox2.SelectedItem.ToString(); // выбранная валюта во 2 списке

                if (from == to)
                {
                    MessageBox.Show("Это одна и та же валюта!", "Внимание!");
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите количество валюты!", "Внимание!");
                }
                else
                {
                    webBrowser1.Navigate("https://yandex.ru/search/?text=" + textBox1.Text +"" + from + " %D0%B2 " + to);
                }
            }
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Выход
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Феткулин Григорий - Конвертатор валют 1.0, 2019", "О программе");
        }
    }
}
