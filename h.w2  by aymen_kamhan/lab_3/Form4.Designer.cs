namespace lab_3
{
    partial class Form4
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
            this.btnsum = new System.Windows.Forms.Button();
            this.btnfact = new System.Windows.Forms.Button();
            this.btnsqr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(126, 111);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(75, 35);
            this.btnsum.TabIndex = 0;
            this.btnsum.Text = "المجموع";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnfact
            // 
            this.btnfact.Location = new System.Drawing.Point(126, 176);
            this.btnfact.Name = "btnfact";
            this.btnfact.Size = new System.Drawing.Size(75, 32);
            this.btnfact.TabIndex = 1;
            this.btnfact.Text = "المضروب";
            this.btnfact.UseVisualStyleBackColor = true;
            this.btnfact.Click += new System.EventHandler(this.btnfact_Click);
            // 
            // btnsqr
            // 
            this.btnsqr.Location = new System.Drawing.Point(126, 241);
            this.btnsqr.Name = "btnsqr";
            this.btnsqr.Size = new System.Drawing.Size(75, 32);
            this.btnsqr.TabIndex = 2;
            this.btnsqr.Text = "الجذر";
            this.btnsqr.UseVisualStyleBackColor = true;
            this.btnsqr.Click += new System.EventHandler(this.btnsqr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ادخل العدد هنا<";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsqr);
            this.Controls.Add(this.btnfact);
            this.Controls.Add(this.btnsum);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnfact;
        private System.Windows.Forms.Button btnsqr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}