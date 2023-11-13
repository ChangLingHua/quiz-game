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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
            MessageBox.Show("答對囉！！！", "好厲害！！！",MessageBoxButtons.OK, MessageBoxIcon.Information);
            int score = Convert.ToInt32(label4.Text) + 1;
            label4.Text = score.ToString();

            jump();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("答錯囉！！！答案：王弗","認真一點！！！",MessageBoxButtons.OK, MessageBoxIcon.Error);

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
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 時間倒數
            int count = Convert.ToInt32(label3.Text) - 1;
            label3.Text = count.ToString();
            if(count==0)
            {
                timer1.Stop();
                scoreReduce();
                jump();

            }
            
        }
        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // 扣分
        private void scoreReduce() {

            int score = Convert.ToInt32(label4.Text) - 1;
            label4.Text = score.ToString();
        }

        // 下一頁
        private void jump() {

            Form3 kForm = new Form3();
            kForm.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
            kForm.Show();
            this.Hide();

            kForm.show_form2_data2(label4.Text);
        }
        
    }
}
