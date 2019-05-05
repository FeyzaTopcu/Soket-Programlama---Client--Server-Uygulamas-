namespace WindowsFormsApp3
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblıp = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(31, 25);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(20, 17);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "IP";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(105, 25);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(124, 22);
            this.txt1.TabIndex = 1;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btn1);
            this.pnl1.Controls.Add(this.lbl3);
            this.pnl1.Controls.Add(this.txt2);
            this.pnl1.Controls.Add(this.lbl2);
            this.pnl1.Controls.Add(this.txt1);
            this.pnl1.Location = new System.Drawing.Point(45, 41);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1115, 87);
            this.pnl1.TabIndex = 2;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(458, 30);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "PORT";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(532, 30);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(123, 22);
            this.txt2.TabIndex = 3;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btn2);
            this.pnl2.Controls.Add(this.lbl5);
            this.pnl2.Controls.Add(this.txt4);
            this.pnl2.Controls.Add(this.lbl4);
            this.pnl2.Controls.Add(this.txt3);
            this.pnl2.Location = new System.Drawing.Point(45, 178);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1115, 87);
            this.pnl2.TabIndex = 3;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(458, 30);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(47, 17);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "PORT";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(532, 30);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(123, 22);
            this.txt4.TabIndex = 3;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(31, 25);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(20, 17);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "IP";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(105, 25);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(124, 22);
            this.txt3.TabIndex = 1;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(45, 331);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(1115, 162);
            this.txt5.TabIndex = 4;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(45, 544);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(971, 41);
            this.txt6.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(987, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 38);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Başla";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(987, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(113, 38);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Bağlan";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1047, 536);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(113, 38);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Gönder";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(42, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 17);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Server";
            // 
            // lblıp
            // 
            this.lblıp.AutoSize = true;
            this.lblıp.Location = new System.Drawing.Point(42, 158);
            this.lblıp.Name = "lblıp";
            this.lblıp.Size = new System.Drawing.Size(43, 17);
            this.lblıp.TabIndex = 8;
            this.lblıp.Text = "Client";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 643);
            this.Controls.Add(this.lblıp);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblıp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

