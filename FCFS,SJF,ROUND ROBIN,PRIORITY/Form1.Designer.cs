using System;

namespace FCFS_SJF_ROUND_ROBIN_PRIORITY
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Q = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P3 = new System.Windows.Forms.Label();
            this.P4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_P1 = new System.Windows.Forms.TextBox();
            this.txt_P2 = new System.Windows.Forms.TextBox();
            this.txt_P3 = new System.Windows.Forms.TextBox();
            this.txt_P4 = new System.Windows.Forms.TextBox();
            this.txt_Q = new System.Windows.Forms.TextBox();
            this.txt_CPU = new System.Windows.Forms.TextBox();
            this.checkedListBox1_RAM = new System.Windows.Forms.CheckedListBox();
            this.FCFS = new System.Windows.Forms.Button();
            this.SJF = new System.Windows.Forms.Button();
            this.RR = new System.Windows.Forms.Button();
            this.PRIORITY = new System.Windows.Forms.Button();
            this.Priority_P1 = new System.Windows.Forms.TextBox();
            this.Priority_P2 = new System.Windows.Forms.TextBox();
            this.Priority_P3 = new System.Windows.Forms.TextBox();
            this.Priority_P4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "P2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "P3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "P4";
            // 
            // Label_Q
            // 
            this.Label_Q.AutoSize = true;
            this.Label_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Q.Location = new System.Drawing.Point(45, 229);
            this.Label_Q.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Q.Name = "Label_Q";
            this.Label_Q.Size = new System.Drawing.Size(26, 24);
            this.Label_Q.TabIndex = 4;
            this.Label_Q.Text = "Q";
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.P1.Location = new System.Drawing.Point(135, 66);
            this.P1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(0, 24);
            this.P1.TabIndex = 5;
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.P2.Location = new System.Drawing.Point(135, 106);
            this.P2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(0, 24);
            this.P2.TabIndex = 6;
            // 
            // P3
            // 
            this.P3.AutoSize = true;
            this.P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.P3.Location = new System.Drawing.Point(135, 145);
            this.P3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(0, 24);
            this.P3.TabIndex = 7;
            // 
            // P4
            // 
            this.P4.AutoSize = true;
            this.P4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.P4.Location = new System.Drawing.Point(135, 187);
            this.P4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(0, 24);
            this.P4.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(518, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "RAM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(755, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "CPU";
            // 
            // txt_P1
            // 
            this.txt_P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P1.Location = new System.Drawing.Point(187, 62);
            this.txt_P1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_P1.Name = "txt_P1";
            this.txt_P1.Size = new System.Drawing.Size(139, 28);
            this.txt_P1.TabIndex = 11;
            this.txt_P1.Tag = "";
            // 
            // txt_P2
            // 
            this.txt_P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P2.Location = new System.Drawing.Point(187, 102);
            this.txt_P2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_P2.Name = "txt_P2";
            this.txt_P2.Size = new System.Drawing.Size(139, 28);
            this.txt_P2.TabIndex = 12;
            this.txt_P2.Tag = "";
            // 
            // txt_P3
            // 
            this.txt_P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P3.Location = new System.Drawing.Point(187, 141);
            this.txt_P3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_P3.Name = "txt_P3";
            this.txt_P3.Size = new System.Drawing.Size(139, 28);
            this.txt_P3.TabIndex = 13;
            this.txt_P3.Tag = "";
            // 
            // txt_P4
            // 
            this.txt_P4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P4.Location = new System.Drawing.Point(187, 180);
            this.txt_P4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_P4.Name = "txt_P4";
            this.txt_P4.Size = new System.Drawing.Size(139, 28);
            this.txt_P4.TabIndex = 14;
            this.txt_P4.Tag = "";
            // 
            // txt_Q
            // 
            this.txt_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Q.Location = new System.Drawing.Point(187, 229);
            this.txt_Q.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Q.Name = "txt_Q";
            this.txt_Q.Size = new System.Drawing.Size(139, 28);
            this.txt_Q.TabIndex = 15;
            // 
            // txt_CPU
            // 
            this.txt_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPU.Location = new System.Drawing.Point(673, 32);
            this.txt_CPU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CPU.Multiline = true;
            this.txt_CPU.Name = "txt_CPU";
            this.txt_CPU.Size = new System.Drawing.Size(212, 225);
            this.txt_CPU.TabIndex = 16;
            // 
            // checkedListBox1_RAM
            // 
            this.checkedListBox1_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1_RAM.ForeColor = System.Drawing.Color.Red;
            this.checkedListBox1_RAM.FormattingEnabled = true;
            this.checkedListBox1_RAM.Location = new System.Drawing.Point(445, 32);
            this.checkedListBox1_RAM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1_RAM.Name = "checkedListBox1_RAM";
            this.checkedListBox1_RAM.Size = new System.Drawing.Size(200, 214);
            this.checkedListBox1_RAM.TabIndex = 17;
            // 
            // FCFS
            // 
            this.FCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFS.Location = new System.Drawing.Point(99, 346);
            this.FCFS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FCFS.Name = "FCFS";
            this.FCFS.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FCFS.Size = new System.Drawing.Size(159, 95);
            this.FCFS.TabIndex = 18;
            this.FCFS.Text = "FCFS";
            this.FCFS.UseVisualStyleBackColor = true;
            this.FCFS.Click += new System.EventHandler(this.button1_Click);
            // 
            // SJF
            // 
            this.SJF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJF.Location = new System.Drawing.Point(298, 346);
            this.SJF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SJF.Name = "SJF";
            this.SJF.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SJF.Size = new System.Drawing.Size(159, 95);
            this.SJF.TabIndex = 19;
            this.SJF.Text = "SJP";
            this.SJF.UseVisualStyleBackColor = true;
            this.SJF.Click += new System.EventHandler(this.button2_Click);
            // 
            // RR
            // 
            this.RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR.Location = new System.Drawing.Point(496, 346);
            this.RR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RR.Name = "RR";
            this.RR.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RR.Size = new System.Drawing.Size(159, 95);
            this.RR.TabIndex = 20;
            this.RR.Text = "RR";
            this.RR.UseVisualStyleBackColor = true;
            this.RR.Click += new System.EventHandler(this.button3_Click);
            // 
            // PRIORITY
            // 
            this.PRIORITY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRIORITY.Location = new System.Drawing.Point(683, 346);
            this.PRIORITY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PRIORITY.Name = "PRIORITY";
            this.PRIORITY.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PRIORITY.Size = new System.Drawing.Size(159, 95);
            this.PRIORITY.TabIndex = 21;
            this.PRIORITY.Text = "PRIORITY";
            this.PRIORITY.UseVisualStyleBackColor = true;
            this.PRIORITY.Click += new System.EventHandler(this.button4_Click);
            // 
            // Priority_P1
            // 
            this.Priority_P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_P1.Location = new System.Drawing.Point(336, 62);
            this.Priority_P1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Priority_P1.Name = "Priority_P1";
            this.Priority_P1.Size = new System.Drawing.Size(89, 28);
            this.Priority_P1.TabIndex = 22;
            this.Priority_P1.Tag = "";
            // 
            // Priority_P2
            // 
            this.Priority_P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_P2.Location = new System.Drawing.Point(336, 102);
            this.Priority_P2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Priority_P2.Name = "Priority_P2";
            this.Priority_P2.Size = new System.Drawing.Size(89, 28);
            this.Priority_P2.TabIndex = 23;
            this.Priority_P2.Tag = "";
            // 
            // Priority_P3
            // 
            this.Priority_P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_P3.Location = new System.Drawing.Point(336, 141);
            this.Priority_P3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Priority_P3.Name = "Priority_P3";
            this.Priority_P3.Size = new System.Drawing.Size(89, 28);
            this.Priority_P3.TabIndex = 24;
            this.Priority_P3.Tag = "";
            // 
            // Priority_P4
            // 
            this.Priority_P4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_P4.Location = new System.Drawing.Point(336, 179);
            this.Priority_P4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Priority_P4.Name = "Priority_P4";
            this.Priority_P4.Size = new System.Drawing.Size(89, 28);
            this.Priority_P4.TabIndex = 25;
            this.Priority_P4.Tag = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "PRIORITY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Priority_P4);
            this.Controls.Add(this.Priority_P3);
            this.Controls.Add(this.Priority_P2);
            this.Controls.Add(this.Priority_P1);
            this.Controls.Add(this.PRIORITY);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.SJF);
            this.Controls.Add(this.FCFS);
            this.Controls.Add(this.checkedListBox1_RAM);
            this.Controls.Add(this.txt_CPU);
            this.Controls.Add(this.txt_Q);
            this.Controls.Add(this.txt_P4);
            this.Controls.Add(this.txt_P3);
            this.Controls.Add(this.txt_P2);
            this.Controls.Add(this.txt_P1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.P4);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Label_Q);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Q;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.Label P4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_P1;
        private System.Windows.Forms.TextBox txt_P2;
        private System.Windows.Forms.TextBox txt_P3;
        private System.Windows.Forms.TextBox txt_P4;
        private System.Windows.Forms.TextBox txt_Q;
        private System.Windows.Forms.TextBox txt_CPU;
        private System.Windows.Forms.CheckedListBox checkedListBox1_RAM;
        private System.Windows.Forms.Button FCFS;
        private System.Windows.Forms.Button SJF;
        private System.Windows.Forms.Button RR;
        private System.Windows.Forms.Button PRIORITY;
        private System.Windows.Forms.TextBox Priority_P1;
        private System.Windows.Forms.TextBox Priority_P2;
        private System.Windows.Forms.TextBox Priority_P3;
        private System.Windows.Forms.TextBox Priority_P4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label5;
    }
}

