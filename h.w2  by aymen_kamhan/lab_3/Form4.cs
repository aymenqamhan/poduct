using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        double x;
        private void btnsum_Click(object sender, EventArgs e)
        {
           
            x = Convert.ToDouble(textBox1.Text);
            double sum = 0;
            sum=x * (x + 1) / 2;//قنون المجموع
            //for (int i = 1; i <= x; i++)
            //{
            //    sum=sum+i;
            //}
            label1.Text= sum.ToString();
        }

        private void btnfact_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            double f = 1;
            for(int i = 1; i<=x; i++)
            {
                f = f * i;
            }
            label2.Text = f.ToString();
        }

        private void btnsqr_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                double s;
                s = Math.Sqrt(x);
                label3.Text = s.ToString();
            }
            catch(Exception )
            {
                MessageBox.Show("the frist enter number");
                textBox1.Focus();
                return;
            }
            
        }
    }
}
