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
    public partial class Form5 : Form
    {
        public string pathBegin = "";
        string str;
        string str1;
        public string pathEnd = @"C:\Users\Honor\Desktop\ПТПДД";
        int count;
        private void lol()
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames;
                pathBegin = sFileName;
            }
            int tpcount = pathBegin.Length;
            string tp = "";
            tp = Convert.ToString(pathBegin[tpcount-3])+Convert.ToString(pathBegin[tpcount-2])+Convert.ToString(pathBegin[tpcount-1]);
            if (tp != "jpg"){
                MessageBox.Show("Нужно выбрать файл формата jpg.");
            }
        }
        private void kek()
        {
            if (pathBegin == "")
            {
                DialogResult result = MessageBox.Show("Не выбрана картинка, вопрос без картинки?","Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DirectoryInfo di = Directory.CreateDirectory(pathEnd+str);
                    File.Copy("C:\\Users\\Honor\\Desktop\\ПТПДД\\image.jpg", pathEnd + str + "\\image.jpg");
                    FileStream fi = File.Create(pathEnd + str + "\\вопрос.txt");
                    StreamWriter streamWriter = new StreamWriter(fi);
                    streamWriter.WriteLine(textBox1.Text);
                    streamWriter.Close();
                    fi.Close();
                    FileStream ot = File.Create(pathEnd+str+"\\1.txt");
                    StreamWriter sw = new StreamWriter(ot);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(textBox4.Text);
                    sw.WriteLine(textBox5.Text);
                    sw.WriteLine(textBox6.Text);
                    if (radioButton1.Checked)
                    {
                        sw.WriteLine(textBox3.Text);
                    }
                    else if (radioButton2.Checked)
                    {
                        sw.WriteLine(textBox4.Text);
                    }
                    else if (radioButton3.Checked)
                    {
                        sw.WriteLine(textBox5.Text);
                    }
                    else if (radioButton4.Checked)
                    {
                        sw.WriteLine(textBox6.Text);
                    }
                    sw.Close();
                    ot.Close();
                }
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(pathEnd+str);
                File.Move(pathBegin, pathEnd + str + "\\image.jpg");
                FileStream fi = File.Create(pathEnd + str + "\\вопрос.txt");
                StreamWriter streamWriter = new StreamWriter(fi);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
                fi.Close();
                FileStream ot = File.Create(pathEnd+str+"\\1.txt");
                StreamWriter sw = new StreamWriter(ot);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
                sw.WriteLine(textBox5.Text);
                sw.WriteLine(textBox6.Text);
                if (radioButton1.Checked)
                {
                    sw.WriteLine(textBox3.Text);
                }
                else if (radioButton2.Checked)
                {
                    sw.WriteLine(textBox4.Text);
                }
                else if (radioButton3.Checked)
                {
                    sw.WriteLine(textBox5.Text);
                }
                else if (radioButton4.Checked)
                {
                    sw.WriteLine(textBox6.Text);
                }
                sw.Close();
                ot.Close();
            }
        }
        public Form5(string s)
        {
            InitializeComponent();
            str=s;
            str1 = s;
            List<string> list = new List<string>(Directory.GetDirectories(pathEnd+str));
            count=list.Count()+1;
            str = str + "\\"+ Convert.ToString(count);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lol();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""||textBox3.Text== "" || textBox4.Text == ""|| textBox5.Text == ""|| textBox6.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                {
                    MessageBox.Show("Не выбран правильный ответ");
                }
                else
                {
                    kek();
                    MessageBox.Show("Вопрос добавлен.");
                    this.Hide();
                    Form5 newForm = new Form5(str1);
                    newForm.Show();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
