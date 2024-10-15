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

namespace ПТПДД
{
    public partial class Form4 : Form
    {
        int i = 0;
        string login1;
        List<string> q;//список путей к вопросам
        List<string> a;//правильные ответы
        List<string> o;//ответы пользователя
        List<string> vopros;//вопросы для отчета

        public Form4(List<string> list, string login)
        {
            InitializeComponent();
            login1=login;
            q = new List<string>(list);
            a = new List<string>(list);
            o = new List<string>(list);
            vopros = new List<string>(list);
            prohod();
            test();
        }

        public void prohod()
        {
            for (int jjj = 0; jjj < q.Count(); jjj++)
            {
                string path = q[jjj];
                vopros[jjj] = File.ReadAllText(path + "\\вопрос.txt");
                using (StreamReader sr = new StreamReader(path + "\\1.txt"))
                {
                    string str = sr.ReadLine();
                    str = sr.ReadLine();
                    str = sr.ReadLine();
                    str = sr.ReadLine();
                    str = sr.ReadLine();//правильный ответ
                    a[jjj] = str;
                }
                o[jjj] = " ";
            }
        }

        public void test()
        {
            string path = q[i];
            label10.Text = File.ReadAllText(path+"\\вопрос.txt");

            using (StreamReader sr = new StreamReader(path + "\\1.txt"))
            {
                string str = sr.ReadLine();
                radioButton1.Text = str;
                str = sr.ReadLine();
                radioButton2.Text = str;
                str = sr.ReadLine();
                radioButton3.Text = str;
                str = sr.ReadLine();
                radioButton4.Text = str;
            }
            pictureBox10.ImageLocation=path+"\\image.jpg";// доделать если не будет изображения

            if (i == q.Count() - 1)
                button1.Hide();
            else
                button1.Show();

            if (i == 0)
                button2.Hide();
            else
                button2.Show();
            if (o[i]==radioButton1.Text)
                radioButton1.Checked=true;
            if (o[i]==radioButton2.Text)
                radioButton2.Checked=true;
            if (o[i]==radioButton3.Text)
                radioButton3.Checked=true;
            if (o[i]==radioButton4.Text)
                radioButton4.Checked=true;
        }

        private void button41_Click_1(object sender, EventArgs e) //завершение теста
        {
            this.Hide();
            Form2 newForm = new Form2(login1);
            newForm.Show();
            FileStream fs = File.Create(@"C:\Users\Honor\Desktop\ПТПДД\отчет\" + login1+".txt");
            StreamWriter sr = new StreamWriter(fs);

            int result = 0;
            for (int u = 0; u < q.Count(); u++)
            {
                sr.WriteLine((u+1)+".");
                sr.WriteLine(vopros[u]);
                sr.WriteLine("Правильный ответ: "+a[u]);
                sr.WriteLine("Ответ пользователя: "+o[u]+"\n");
                if (o[u] == a[u])
                    result++;
            }
            sr.WriteLine(result+" / "+q.Count());
            sr.Close();
            fs.Close();
            MessageBox.Show("Результат: "+result+" правильных ответов из "+q.Count());

        }

        private void button1_Click_1(object sender, EventArgs e) //-> переход по тесту
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            i++;
            test();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // <-
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            i--;
            test();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = (RadioButton)sender;
            if (radioButton1.Checked)
            {
                o[i] = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton2 = (RadioButton)sender;
            if (radioButton2.Checked)
            {
                o[i] = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton3 = (RadioButton)sender;
            if (radioButton3.Checked)
            {
                o[i] = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton4 = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                o[i] = radioButton4.Text;
            }
        }
    }
}