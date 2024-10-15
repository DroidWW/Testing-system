using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПТПДД
{
    public partial class Form2 : Form
    {
        string login1;
        public Form2(string login)
        {
            InitializeComponent();
            login1 = login;
        }
        List<string> quelist;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//назад
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)//знаки
        {
            quelist = Тест.Вопросы("знаки");
            if (quelist.Count() < 10)
            {
                MessageBox.Show("Вопросов меньше 10. Следует добавить вопросы в данный раздел.");
            }
            else
            {
                this.Hide();
                Form4 newForm1 = new Form4(quelist, login1);
                newForm1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            quelist = Тест.Вопросы("разметка");
            if (quelist.Count() < 10)
            {
                MessageBox.Show("Вопросов меньше 10. Следует добавить вопросы в данный раздел.");
            }
            else
            {
                this.Hide();
                Form4 newForm1 = new Form4(quelist, login1);
                newForm1.Show();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            quelist = Тест.Разное();
            if (quelist.Count() < 10)
            {
                MessageBox.Show("Вопросов меньше 10. Следует добавить вопросы в данный раздел.");
            }
            else
            {
                this.Hide();
                Form4 newForm1 = new Form4(quelist, login1);
                newForm1.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            quelist = Тест.Вопросы("сигналы");
            if (quelist.Count() < 10)
            {
                MessageBox.Show("Вопросов меньше 10. Следует добавить вопросы в данный раздел.");
            }
            else
            {
                this.Hide();
                Form4 newForm1 = new Form4(quelist, login1);
                newForm1.Show();
            }
        }
    }
}
