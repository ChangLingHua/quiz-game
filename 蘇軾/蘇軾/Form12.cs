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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

       
        public void show_form11_data1(string data2)
        {
            label3.Text = data2;
        }
        public void show_form2_data2(string data2)
        {

            label3.Text = data2;
        }
        public void show_form3_data3(string data2)
        {
            label3.Text = data2;
        }

        public void show_form4_data4(string data2)
        {
            label3.Text = data2;
        }
        public void show_form5_data5(string data2)
        {
            label3.Text = data2;
        }
        public void show_form6_data6(string data2)
        {
            label3.Text = data2;
        }
        public void show_form7_data7(string data2)
        {
            label3.Text = data2;
        }
        public void show_form8_data8(string data2)
        {
            label3.Text = data2;
        }
        public void show_form9_data9(string data2)
        {
            label3.Text = data2;
        }
        public void show_form10_data10(string data2)
        {
            label3.Text = data2;
        }
        private void Form12_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("確定要離開嗎？", "離開", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                //MessageBox.Show("掰掰！！！", "結束", MessageBoxButtons.OK);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            lForm.Show();
            this.Hide();
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
