using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 蘇軾
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public void show_form3_data(string data)
        {
            label3.Text = data;
        }
        public void show_form3_data2(string data2)
        {
            label4.Text = data2;
        }
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("答錯囉！！！答案：王弗", "再接再厲！！！", MessageBoxButtons.OK, MessageBoxIcon.Error);

            scoreReduce();
            jump();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("答對囉！！！", "好厲害！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int score = Convert.ToInt32(label4.Text) + 1;
            label4.Text = score.ToString();

            jump();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("答錯囉！！！答案：王弗", "再接再厲！！！", MessageBoxButtons.OK, MessageBoxIcon.Error);

            scoreReduce();
            jump();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label3.Text) - 1;
            label3.Text = count.ToString();
            if (count == 0)
            {
                timer1.Stop();
                scoreReduce();
                jump();
            }
        }
     
        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void scoreReduce() {

            int score = Convert.ToInt32(label4.Text) - 1;
            label4.Text = score.ToString();
        }

        private void jump() {

            Form5 dForm = new Form5();
            dForm.FormClosed += new FormClosedEventHandler(Form5_FormClosed);
            dForm.Show();
            this.Hide();

            dForm.show_form4_data2(label4.Text);
        }
    }
}
