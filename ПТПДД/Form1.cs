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
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public bool log_pass(string login, string password,ref bool p,string path,string path1)
        {
            using (StreamReader sr = new StreamReader(path + path1))
            {
                while (true)
                {
                    string str = sr.ReadLine();
                    if (str==null)
                    {
                        break;
                    }
                    string[] logs = str.Split(' ');
                    if (logs[0] == login && logs[1] == password)
                    {
                        p = true;
                        return p;
                    }
                }
            }
            return p;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string path = @"C:\Users\Honor\Desktop\ПТПДД";
            bool p = false;
            bool p1 = false;
            log_pass(login,password,ref p,path, "\\ученики.txt");
            log_pass(login, password, ref p1, path, "\\учителя.txt");
            if (!p && !p1)
            {
                MessageBox.Show("Неверный логин или пароль, попробуйте заново.");
            }
            else
            {
                switch (comboBox1.Text)
                {
                    case "Ученик":
                        {
                            if (p)
                            {
                                this.Hide();
                                Form2 newForm1 = new Form2(login);
                                newForm1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль, попробуйте заново.");
                            }
                            break;
                        }
                    case "Учитель":
                        {
                            if (p1)
                            {
                                this.Hide();
                                Form3 newForm2 = new Form3();
                                newForm2.Show();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль, попробуйте заново.");
                            }
                            break;
                        }
                    default:
                        MessageBox.Show("Выберите роль.");
                        break;

                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
