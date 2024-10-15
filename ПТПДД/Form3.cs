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
    public partial class Form3 : Form
    {
    
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //назад
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) //знаки
        {
            this.Hide();
            Form5 newForm = new Form5("\\знаки");
            newForm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e) //разметка
        {
            this.Hide();
            Form5 newForm = new Form5("\\разметка");
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e) // сигналы
        {
            this.Hide();
            Form5 newForm = new Form5("\\сигналы");
            newForm.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
