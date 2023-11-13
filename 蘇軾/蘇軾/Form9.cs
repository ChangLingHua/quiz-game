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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public void show_form8_data(string data)
        {
            label3.Text = data;
        }
        public void show_form8_data2(string data2)
        {
            label4.Text = data2;
        }
        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("答對囉！！！", "好厲害！！！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int score = Convert.ToInt32(label4.Text) + 1;
            label4.Text = score.ToString();

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
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("答錯囉！！！答案：王弗", "再接再厲！！！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            scoreReduce();
            jump();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("答錯囉！！！答案：王弗", "再接再厲！！！", MessageBoxButtons.OK, MessageBoxIcon.Error);

            scoreReduce();
            jump();
        }
        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void scoreReduce() {

            int score = Convert.ToInt32(label4.Text) - 1;
            label4.Text = score.ToString();
        }

        private void jump() {

            Form10 iForm = new Form10();
            iForm.FormClosed += new FormClosedEventHandler(Form10_FormClosed);
            iForm.Show();
            this.Hide();

            iForm.show_form9_data2(label4.Text);
        }
    }
 }

