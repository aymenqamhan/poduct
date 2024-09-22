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
    public partial class sender : Form
    {
        public sender()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //لم ينفذ ينتج بشكل صحيح
        //public void traingforplay(object sender, EventArgs e)
        // {
        //    //Button clickedButton = sender as Button;
        //    if (sender == btnred)
        //    {
        //       btncolor.BackColor=Color.Red;
        //    }
        //    else if(sender == btngreen) 
        //    {
        //        btncolor.BackColor= Color.Green;
        //    }
        //    else if(sender == btnblue)
        //    {
        //        btncolor.BackColor= Color.Blue;
        //    }
        //    else
        //    {
        //        MessageBox.Show("push any box!");
        //    }

        //}

        private void btnred_Click(object sender, EventArgs e)
        {
            btncolor.BackColor = Color.Red;
            //MessageBox.Show("textbox1");
            labtypecolor.Text = "textbox1";
        }

        private void btngreen_Click(object sender, EventArgs e)
        {
            btncolor.BackColor = Color.Green;
            //MessageBox.Show("textbox2");
            labtypecolor.Text = "textbox2";
        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            btncolor.BackColor = Color.Green;
            //MessageBox.Show("textbox3");
            labtypecolor.Text = "textbox3";
        }

        private void yllowform_Click(object sender, EventArgs e)
        {
          this.BackColor= Color.Yellow;
            labtypecolor.Text = "label1";
        }

        private void brownform_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
            labtypecolor.Text = "label2";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            labtypecolor.Text= "button1";
        }
    }
}
