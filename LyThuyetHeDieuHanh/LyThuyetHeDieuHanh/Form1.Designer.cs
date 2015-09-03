namespace LyThuyetHeDieuHanh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radWF = new System.Windows.Forms.RadioButton();
            this.radFF = new System.Windows.Forms.RadioButton();
            this.radBF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBlock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.butSlow = new System.Windows.Forms.Button();
            this.butFast = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.butHelp = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butLock = new System.Windows.Forms.Button();
            this.butRun = new System.Windows.Forms.Button();
            this.butPause = new System.Windows.Forms.Button();
            this.radHole = new System.Windows.Forms.RadioButton();
            this.butAdd = new System.Windows.Forms.Button();
            this.radEnd = new System.Windows.Forms.RadioButton();
            this.radProcess = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(198, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 302);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(203, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Display";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Algorithms";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.radWF);
            this.panel2.Controls.Add(this.radFF);
            this.panel2.Controls.Add(this.radBF);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 97);
            this.panel2.TabIndex = 1;
            // 
            // radWF
            // 
            this.radWF.AutoSize = true;
            this.radWF.Location = new System.Drawing.Point(3, 67);
            this.radWF.Name = "radWF";
            this.radWF.Size = new System.Drawing.Size(67, 17);
            this.radWF.TabIndex = 3;
            this.radWF.Text = "Worst Fit";
            this.radWF.UseVisualStyleBackColor = true;
            this.radWF.CheckedChanged += new System.EventHandler(this.radWF_CheckedChanged);
            // 
            // radFF
            // 
            this.radFF.AutoSize = true;
            this.radFF.Checked = true;
            this.radFF.Location = new System.Drawing.Point(3, 20);
            this.radFF.Name = "radFF";
            this.radFF.Size = new System.Drawing.Size(58, 17);
            this.radFF.TabIndex = 1;
            this.radFF.TabStop = true;
            this.radFF.Text = "First Fit";
            this.radFF.UseVisualStyleBackColor = true;
            this.radFF.CheckedChanged += new System.EventHandler(this.radFF_CheckedChanged);
            // 
            // radBF
            // 
            this.radBF.AutoSize = true;
            this.radBF.Location = new System.Drawing.Point(3, 44);
            this.radBF.Name = "radBF";
            this.radBF.Size = new System.Drawing.Size(60, 17);
            this.radBF.TabIndex = 2;
            this.radBF.Text = "Best Fit";
            this.radBF.UseVisualStyleBackColor = true;
            this.radBF.CheckedChanged += new System.EventHandler(this.radBF_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightPink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lab3);
            this.panel3.Controls.Add(this.lab2);
            this.panel3.Controls.Add(this.listView2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(12, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 301);
            this.panel3.TabIndex = 2;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab3.ForeColor = System.Drawing.Color.Red;
            this.lab3.Location = new System.Drawing.Point(124, 158);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(50, 15);
            this.lab3.TabIndex = 7;
            this.lab3.Text = "Inputting";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab2.ForeColor = System.Drawing.Color.Red;
            this.lab2.Location = new System.Drawing.Point(124, 12);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(50, 15);
            this.lab2.TabIndex = 6;
            this.lab2.Text = "Inputting";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(4, 174);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(173, 115);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Block";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MB";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beginning Status";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumber,
            this.colBlock,
            this.colMB});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(173, 115);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colNumber
            // 
            this.colNumber.Text = "No.";
            this.colNumber.Width = 32;
            // 
            // colBlock
            // 
            this.colBlock.Text = "Block";
            this.colBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBlock.Width = 96;
            // 
            // colMB
            // 
            this.colMB.Text = "MB";
            this.colMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMB.Width = 39;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(92, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 97);
            this.panel4.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "???";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.butSlow);
            this.panel6.Controls.Add(this.butFast);
            this.panel6.Controls.Add(this.butReset);
            this.panel6.Controls.Add(this.butHelp);
            this.panel6.Controls.Add(this.butExit);
            this.panel6.Controls.Add(this.butLock);
            this.panel6.Controls.Add(this.butRun);
            this.panel6.Controls.Add(this.butPause);
            this.panel6.Controls.Add(this.radHole);
            this.panel6.Controls.Add(this.butAdd);
            this.panel6.Controls.Add(this.radEnd);
            this.panel6.Controls.Add(this.radProcess);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Location = new System.Drawing.Point(198, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(523, 75);
            this.panel6.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butSlow
            // 
            this.butSlow.Location = new System.Drawing.Point(326, 42);
            this.butSlow.Name = "butSlow";
            this.butSlow.Size = new System.Drawing.Size(49, 23);
            this.butSlow.TabIndex = 10;
            this.butSlow.Text = "Slower";
            this.butSlow.UseVisualStyleBackColor = true;
            this.butSlow.Click += new System.EventHandler(this.butSlow_Click);
            // 
            // butFast
            // 
            this.butFast.Location = new System.Drawing.Point(326, 9);
            this.butFast.Name = "butFast";
            this.butFast.Size = new System.Drawing.Size(49, 23);
            this.butFast.TabIndex = 0;
            this.butFast.Text = "Faster";
            this.butFast.UseVisualStyleBackColor = true;
            this.butFast.Click += new System.EventHandler(this.butFast_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(381, 9);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(50, 23);
            this.butReset.TabIndex = 1;
            this.butReset.Text = "Restart";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butHelp
            // 
            this.butHelp.Location = new System.Drawing.Point(437, 9);
            this.butHelp.Name = "butHelp";
            this.butHelp.Size = new System.Drawing.Size(76, 23);
            this.butHelp.TabIndex = 1;
            this.butHelp.Text = "Help";
            this.butHelp.UseVisualStyleBackColor = true;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(437, 42);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(76, 23);
            this.butExit.TabIndex = 5;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butLock
            // 
            this.butLock.Location = new System.Drawing.Point(200, 42);
            this.butLock.Name = "butLock";
            this.butLock.Size = new System.Drawing.Size(57, 23);
            this.butLock.TabIndex = 9;
            this.butLock.Text = "Confirm";
            this.butLock.UseVisualStyleBackColor = true;
            this.butLock.Click += new System.EventHandler(this.butLock_Click);
            // 
            // butRun
            // 
            this.butRun.Enabled = false;
            this.butRun.Location = new System.Drawing.Point(263, 9);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(57, 23);
            this.butRun.TabIndex = 3;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // butPause
            // 
            this.butPause.Enabled = false;
            this.butPause.Location = new System.Drawing.Point(263, 42);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(57, 23);
            this.butPause.TabIndex = 4;
            this.butPause.Text = "Pause";
            this.butPause.UseVisualStyleBackColor = true;
            this.butPause.Click += new System.EventHandler(this.butPause_Click);
            // 
            // radHole
            // 
            this.radHole.AutoSize = true;
            this.radHole.Location = new System.Drawing.Point(76, 48);
            this.radHole.Name = "radHole";
            this.radHole.Size = new System.Drawing.Size(47, 17);
            this.radHole.TabIndex = 8;
            this.radHole.Text = "Hole";
            this.radHole.UseVisualStyleBackColor = true;
            this.radHole.CheckedChanged += new System.EventHandler(this.radHole_CheckedChanged);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(200, 9);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(57, 23);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // radEnd
            // 
            this.radEnd.AutoSize = true;
            this.radEnd.Enabled = false;
            this.radEnd.Location = new System.Drawing.Point(134, 48);
            this.radEnd.Name = "radEnd";
            this.radEnd.Size = new System.Drawing.Size(44, 17);
            this.radEnd.TabIndex = 7;
            this.radEnd.Text = "End";
            this.radEnd.UseVisualStyleBackColor = true;
            this.radEnd.CheckedChanged += new System.EventHandler(this.radEnd_CheckedChanged);
            // 
            // radProcess
            // 
            this.radProcess.AutoSize = true;
            this.radProcess.Checked = true;
            this.radProcess.Location = new System.Drawing.Point(7, 48);
            this.radProcess.Name = "radProcess";
            this.radProcess.Size = new System.Drawing.Size(63, 17);
            this.radProcess.TabIndex = 6;
            this.radProcess.TabStop = true;
            this.radProcess.Text = "Process";
            this.radProcess.UseVisualStyleBackColor = true;
            this.radProcess.CheckedChanged += new System.EventHandler(this.radProcess_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "MB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Block";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "P";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox3.Location = new System.Drawing.Point(571, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(85, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "99";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Designed by VKL and NCC  class IT2 c348 MTA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 428);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(748, 466);
            this.MinimumSize = new System.Drawing.Size(748, 466);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Continues Memory Allocation Stimulation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radWF;
        private System.Windows.Forms.RadioButton radFF;
        private System.Windows.Forms.RadioButton radBF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colBlock;
        private System.Windows.Forms.ColumnHeader colMB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Button butHelp;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butLock;
        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Button butPause;
        private System.Windows.Forms.RadioButton radHole;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.RadioButton radEnd;
        private System.Windows.Forms.RadioButton radProcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button butSlow;
        private System.Windows.Forms.Button butFast;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}

