using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            text1number1.Focus();
            text6result.ReadOnly = true;
            text2operation1.Enabled = text3number2.Enabled = text4operation2.Enabled =text5number3.Enabled= false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (text1number1.Text != null && text1number1.Text != "")
            {
                text2operation1.Enabled = true;
            }
            else
            {
                text2operation1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (text2operation1.Text != null && text2operation1.Text != "")
            {
                text3number2.Enabled = true;
            }
            else
            {
                text3number2.Enabled = false;
            }

        }

       
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (text4operation2.Text != null && text4operation2.Text != "")
            {
                text5number3.Enabled = true;
            }
            else
            {
                text5number3.Enabled = false;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string operation1 = text2operation1.Text;
            string operation2 = text4operation2.Text;
            string intermediateresult = "";
            string finalresult = "";



            if (double.TryParse(text1number1.Text, out number1) && double.TryParse(text3number2.Text, out number2) && double.TryParse(text5number3.Text, out number3))
            {
                double result1 = preformoperation(number2, number3, operation2); // تنفيذ العملية الثانية أولاً

                if (double.IsNaN(result1))
                {
                    MessageBox.Show("العملية الحسابيه الثانية غير صحيحة!");
                    text4operation2.Focus();
                    return;
                }

                double result2 = preformoperation(number1, result1, operation1); // تنفيذ العملية الأولى

                if (double.IsNaN(result2))
                {
                    MessageBox.Show("العملية الحسابيه الأولى غير صحيحة!");
                    text2operation1.Focus();
                    return;
                }

                text6result.Text = result2.ToString();
            }
            else
            {
                MessageBox.Show("يرجى إدخال أرقام صحيحة!");
            }
        }
        
            private double preformoperation(double num1,double num2, string operation) 
            {
             switch(operation)
                {
                    case "+":
                        return num1+num2;
                        case "-":
                        return num1-num2;
                        case "*": 
                        return num1*num2;
                        case  "/":
                        return num2!=0 ?  num1/num2 : double.NaN;
                        default:

                        return double.NaN;

                }
            }

        private void text1number1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("ارقام فقط");
            }
        }

        private void text3number2_TextChanged(object sender, EventArgs e)
        {
            if (text3number2.Text != null && text3number2.Text != "")
                text4operation2.Enabled = true;
            else
                text4operation2.Enabled = false;

            
        }

        private void text3number2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("ارقام فقط");
            }
        }

        private void text5number3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("ارقام فقط");
            }
        }

        private void text2operation1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar != '+' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar !=8) 
            {
                e.Handled = true;
                MessageBox.Show("الرجاء إدخال علامات الجمع اوالضرب اوالقسمة او الطرح فقط");
            }
        }

        private void text4operation2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar != '+' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar !=8)
            {
                e.Handled = true;
                MessageBox.Show("الرجاء إدخال علامات الجمع اوالضرب اوالقسمة او الطرح فقط");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

