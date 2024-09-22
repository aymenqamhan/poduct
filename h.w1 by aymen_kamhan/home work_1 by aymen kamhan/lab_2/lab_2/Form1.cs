using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 46))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//تم التاشير عليه
        {
        }

            private void button1_Click(object sender, EventArgs e)
            {

            textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();    

            }

        private void textBox1_TextChanged(object sender, EventArgs e)//للتخفيف من الاكواد نقوم بكتابه textbox1 الذي يوشر على جميع خصائص ال textboks2
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "0")
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
            }
            else
            {
                MessageBox.Show("divided by zero!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)

        {
            
            textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += textBox2_TextChanged;// خصائص البوتون الاول للثاني
            textBox1.KeyPress += textBox2_KeyPress;
            textBox3.ReadOnly = true;
            this.Text = "calculater";
            textBox3.ForeColor = Color.RoyalBlue;
        }
    }
}
