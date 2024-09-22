namespace lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text1number1 = new System.Windows.Forms.TextBox();
            this.text2operation1 = new System.Windows.Forms.TextBox();
            this.text3number2 = new System.Windows.Forms.TextBox();
            this.text4operation2 = new System.Windows.Forms.TextBox();
            this.text6result = new System.Windows.Forms.TextBox();
            this.text5number3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(201, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "count";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(13, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text1number1
            // 
            this.text1number1.Location = new System.Drawing.Point(14, 35);
            this.text1number1.Name = "text1number1";
            this.text1number1.Size = new System.Drawing.Size(100, 24);
            this.text1number1.TabIndex = 2;
            this.text1number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.text1number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text1number1_KeyPress);
            // 
            // text2operation1
            // 
            this.text2operation1.Location = new System.Drawing.Point(14, 89);
            this.text2operation1.Name = "text2operation1";
            this.text2operation1.Size = new System.Drawing.Size(100, 24);
            this.text2operation1.TabIndex = 3;
            this.text2operation1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.text2operation1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text2operation1_KeyPress);
            // 
            // text3number2
            // 
            this.text3number2.Location = new System.Drawing.Point(13, 134);
            this.text3number2.Name = "text3number2";
            this.text3number2.Size = new System.Drawing.Size(100, 24);
            this.text3number2.TabIndex = 4;
            this.text3number2.TextChanged += new System.EventHandler(this.text3number2_TextChanged);
            this.text3number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text3number2_KeyPress);
            // 
            // text4operation2
            // 
            this.text4operation2.Location = new System.Drawing.Point(13, 191);
            this.text4operation2.Name = "text4operation2";
            this.text4operation2.Size = new System.Drawing.Size(100, 24);
            this.text4operation2.TabIndex = 5;
            this.text4operation2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.text4operation2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text4operation2_KeyPress);
            // 
            // text6result
            // 
            this.text6result.Location = new System.Drawing.Point(13, 322);
            this.text6result.Name = "text6result";
            this.text6result.Size = new System.Drawing.Size(100, 24);
            this.text6result.TabIndex = 6;
            this.text6result.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // text5number3
            // 
            this.text5number3.Location = new System.Drawing.Point(13, 255);
            this.text5number3.Name = "text5number3";
            this.text5number3.Size = new System.Drawing.Size(100, 24);
            this.text5number3.TabIndex = 7;
            this.text5number3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.text5number3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text5number3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(180, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "number one";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(184, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "opreation_one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(180, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "number two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(188, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "opreation_two";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(187, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "number three";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(194, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "the result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 446);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text5number3);
            this.Controls.Add(this.text6result);
            this.Controls.Add(this.text4operation2);
            this.Controls.Add(this.text3number2);
            this.Controls.Add(this.text2operation1);
            this.Controls.Add(this.text1number1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text1number1;
        private System.Windows.Forms.TextBox text2operation1;
        private System.Windows.Forms.TextBox text3number2;
        private System.Windows.Forms.TextBox text4operation2;
        private System.Windows.Forms.TextBox text6result;
        private System.Windows.Forms.TextBox text5number3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

