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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 aForm = new Form2();
            aForm.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            aForm.Show();
            this.Hide();
            
        }

       
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {

        }
    }
}
