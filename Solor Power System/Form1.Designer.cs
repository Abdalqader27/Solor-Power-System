namespace Solor_Power_System
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startRandomFill = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.th100 = new System.Windows.Forms.Label();
            this.th72 = new System.Windows.Forms.Label();
            this.th35 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.solar_tank = new Solor_Power_System.VerticalProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.makeEmpty = new System.Windows.Forms.Button();
            this.stopFill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTempr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.temprListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.start100 = new System.Windows.Forms.Button();
            this.start67 = new System.Windows.Forms.Button();
            this.start33 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tempNumber = new System.Windows.Forms.Label();
            this.progressBar1 = new Solor_Power_System.VerticalProgressBar();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.startEmilation = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.readerTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startRandomFill
            // 
            this.startRandomFill.Location = new System.Drawing.Point(20, 33);
            this.startRandomFill.Name = "startRandomFill";
            this.startRandomFill.Size = new System.Drawing.Size(211, 35);
            this.startRandomFill.TabIndex = 3;
            this.startRandomFill.Text = "بدء تعبئة الخزان عشوائيا";
            this.startRandomFill.UseVisualStyleBackColor = true;
            this.startRandomFill.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.th100);
            this.groupBox1.Controls.Add(this.th72);
            this.groupBox1.Controls.Add(this.th35);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.solar_tank);
            this.groupBox1.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 423);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خزان الطاقة الشمسية";
            // 
            // th100
            // 
            this.th100.AutoSize = true;
            this.th100.BackColor = System.Drawing.Color.Transparent;
            this.th100.ForeColor = System.Drawing.SystemColors.InfoText;
            this.th100.Location = new System.Drawing.Point(20, 41);
            this.th100.Name = "th100";
            this.th100.Size = new System.Drawing.Size(57, 28);
            this.th100.TabIndex = 10;
            this.th100.Text = "100 %";
            this.th100.Visible = false;
            // 
            // th72
            // 
            this.th72.AutoSize = true;
            this.th72.BackColor = System.Drawing.Color.Transparent;
            this.th72.ForeColor = System.Drawing.SystemColors.InfoText;
            this.th72.Location = new System.Drawing.Point(20, 160);
            this.th72.Name = "th72";
            this.th72.Size = new System.Drawing.Size(42, 28);
            this.th72.TabIndex = 9;
            this.th72.Text = "67%";
            this.th72.Visible = false;
            // 
            // th35
            // 
            this.th35.AutoSize = true;
            this.th35.BackColor = System.Drawing.Color.Transparent;
            this.th35.ForeColor = System.Drawing.SystemColors.InfoText;
            this.th35.Location = new System.Drawing.Point(21, 262);
            this.th35.Name = "th35";
            this.th35.Size = new System.Drawing.Size(48, 28);
            this.th35.TabIndex = 8;
            this.th35.Text = "33 %";
            this.th35.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "نسبة الماء في الخزان";
            // 
            // solar_tank
            // 
            this.solar_tank.Location = new System.Drawing.Point(18, 40);
            this.solar_tank.MarqueeAnimationSpeed = 10;
            this.solar_tank.Name = "solar_tank";
            this.solar_tank.Size = new System.Drawing.Size(212, 318);
            this.solar_tank.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.makeEmpty);
            this.groupBox2.Controls.Add(this.stopFill);
            this.groupBox2.Controls.Add(this.startRandomFill);
            this.groupBox2.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(310, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(249, 175);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الخزان";
            // 
            // makeEmpty
            // 
            this.makeEmpty.ForeColor = System.Drawing.Color.DarkBlue;
            this.makeEmpty.Location = new System.Drawing.Point(20, 115);
            this.makeEmpty.Name = "makeEmpty";
            this.makeEmpty.Size = new System.Drawing.Size(211, 35);
            this.makeEmpty.TabIndex = 5;
            this.makeEmpty.Text = "إفراغ الخزان";
            this.makeEmpty.UseVisualStyleBackColor = true;
            this.makeEmpty.Click += new System.EventHandler(this.makeEmpty_Click);
            // 
            // stopFill
            // 
            this.stopFill.ForeColor = System.Drawing.Color.Crimson;
            this.stopFill.Location = new System.Drawing.Point(20, 74);
            this.stopFill.Name = "stopFill";
            this.stopFill.Size = new System.Drawing.Size(211, 35);
            this.stopFill.TabIndex = 4;
            this.stopFill.Text = "ايقاف التعبئة";
            this.stopFill.UseVisualStyleBackColor = true;
            this.stopFill.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxTempr);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.temprListBox);
            this.groupBox3.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(523, 166);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "درجة الحرارة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(177, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "أو";
            this.label4.Visible = false;
            // 
            // textBoxTempr
            // 
            this.textBoxTempr.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxTempr.Location = new System.Drawing.Point(36, 76);
            this.textBoxTempr.Multiline = true;
            this.textBoxTempr.Name = "textBoxTempr";
            this.textBoxTempr.Size = new System.Drawing.Size(116, 40);
            this.textBoxTempr.TabIndex = 49;
            this.textBoxTempr.TextChanged += new System.EventHandler(this.textBoxTempr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "حدد درجة الحرارة";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // temprListBox
            // 
            this.temprListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.temprListBox.FormattingEnabled = true;
            this.temprListBox.ItemHeight = 25;
            this.temprListBox.Location = new System.Drawing.Point(218, 12);
            this.temprListBox.Name = "temprListBox";
            this.temprListBox.Size = new System.Drawing.Size(191, 129);
            this.temprListBox.TabIndex = 4;
            this.temprListBox.SelectedIndexChanged += new System.EventHandler(this.temprListBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox13);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(650, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(599, 423);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "لوحة المحاكاة";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox13.Controls.Add(this.start100);
            this.groupBox13.Controls.Add(this.start67);
            this.groupBox13.Controls.Add(this.start33);
            this.groupBox13.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(36, 40);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox13.Size = new System.Drawing.Size(249, 175);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "تعبئة الخزان";
            // 
            // start100
            // 
            this.start100.Location = new System.Drawing.Point(19, 119);
            this.start100.Name = "start100";
            this.start100.Size = new System.Drawing.Size(211, 35);
            this.start100.TabIndex = 5;
            this.start100.Text = "بدء تعبئة 100 %";
            this.start100.UseVisualStyleBackColor = true;
            this.start100.Click += new System.EventHandler(this.start100_Click);
            // 
            // start67
            // 
            this.start67.Location = new System.Drawing.Point(20, 74);
            this.start67.Name = "start67";
            this.start67.Size = new System.Drawing.Size(211, 35);
            this.start67.TabIndex = 4;
            this.start67.Text = "بدء تعبئة 67 %";
            this.start67.UseVisualStyleBackColor = true;
            this.start67.Click += new System.EventHandler(this.start67_Click);
            // 
            // start33
            // 
            this.start33.Location = new System.Drawing.Point(20, 33);
            this.start33.Name = "start33";
            this.start33.Size = new System.Drawing.Size(211, 35);
            this.start33.TabIndex = 3;
            this.start33.Text = "بدء تعبئة 33 %";
            this.start33.UseVisualStyleBackColor = true;
            this.start33.Click += new System.EventHandler(this.start33_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox12);
            this.groupBox5.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox5.Location = new System.Drawing.Point(12, 441);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(1253, 125);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "lPT1";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Controls.Add(this.button14);
            this.groupBox6.Controls.Add(this.button15);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Location = new System.Drawing.Point(846, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(388, 81);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Out Put Port";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Location = new System.Drawing.Point(306, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 35);
            this.button5.TabIndex = 10;
            this.button5.Text = "Out5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.DarkBlue;
            this.button10.Location = new System.Drawing.Point(232, 34);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 35);
            this.button10.TabIndex = 9;
            this.button10.Text = "Out4";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.ForeColor = System.Drawing.Color.DarkBlue;
            this.button14.Location = new System.Drawing.Point(158, 34);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 35);
            this.button14.TabIndex = 8;
            this.button14.Text = "Out3";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.ForeColor = System.Drawing.Color.DarkBlue;
            this.button15.Location = new System.Drawing.Point(84, 34);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 35);
            this.button15.TabIndex = 7;
            this.button15.Text = "Out1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.ForeColor = System.Drawing.Color.DarkBlue;
            this.button16.Location = new System.Drawing.Point(10, 34);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 35);
            this.button16.TabIndex = 6;
            this.button16.Text = "Out0";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox7.Controls.Add(this.button21);
            this.groupBox7.Controls.Add(this.button22);
            this.groupBox7.Controls.Add(this.button23);
            this.groupBox7.Controls.Add(this.button24);
            this.groupBox7.Controls.Add(this.button25);
            this.groupBox7.Location = new System.Drawing.Point(511, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(325, 81);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Input Port";
            // 
            // button21
            // 
            this.button21.ForeColor = System.Drawing.Color.DarkBlue;
            this.button21.Location = new System.Drawing.Point(254, 34);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(55, 35);
            this.button21.TabIndex = 10;
            this.button21.Text = "In 3";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.ForeColor = System.Drawing.Color.DarkBlue;
            this.button22.Location = new System.Drawing.Point(193, 34);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(55, 35);
            this.button22.TabIndex = 9;
            this.button22.Text = "In 4";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.ForeColor = System.Drawing.Color.DarkBlue;
            this.button23.Location = new System.Drawing.Point(71, 34);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(55, 35);
            this.button23.TabIndex = 8;
            this.button23.Text = "In 6";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.ForeColor = System.Drawing.Color.DarkBlue;
            this.button24.Location = new System.Drawing.Point(132, 34);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(55, 35);
            this.button24.TabIndex = 7;
            this.button24.Text = "In 5";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.ForeColor = System.Drawing.Color.DarkBlue;
            this.button25.Location = new System.Drawing.Point(10, 34);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(55, 35);
            this.button25.TabIndex = 6;
            this.button25.Text = "In 7";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox12.Controls.Add(this.button26);
            this.groupBox12.Controls.Add(this.button46);
            this.groupBox12.Controls.Add(this.button47);
            this.groupBox12.Controls.Add(this.button48);
            this.groupBox12.Controls.Add(this.button53);
            this.groupBox12.Controls.Add(this.button54);
            this.groupBox12.Controls.Add(this.button55);
            this.groupBox12.Controls.Add(this.button56);
            this.groupBox12.Location = new System.Drawing.Point(16, 31);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(485, 81);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Data Port";
            // 
            // button26
            // 
            this.button26.ForeColor = System.Drawing.Color.DarkBlue;
            this.button26.Location = new System.Drawing.Point(419, 34);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(55, 35);
            this.button26.TabIndex = 13;
            this.button26.Text = "D0";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.ForeColor = System.Drawing.Color.DarkBlue;
            this.button46.Location = new System.Drawing.Point(365, 34);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(55, 35);
            this.button46.TabIndex = 12;
            this.button46.Text = "D1";
            this.button46.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.ForeColor = System.Drawing.Color.DarkBlue;
            this.button47.Location = new System.Drawing.Point(315, 34);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(55, 35);
            this.button47.TabIndex = 11;
            this.button47.Text = "D2";
            this.button47.UseVisualStyleBackColor = true;
            // 
            // button48
            // 
            this.button48.ForeColor = System.Drawing.Color.DarkBlue;
            this.button48.Location = new System.Drawing.Point(254, 34);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(55, 35);
            this.button48.TabIndex = 10;
            this.button48.Text = "D3";
            this.button48.UseVisualStyleBackColor = true;
            // 
            // button53
            // 
            this.button53.ForeColor = System.Drawing.Color.DarkBlue;
            this.button53.Location = new System.Drawing.Point(193, 34);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(55, 35);
            this.button53.TabIndex = 9;
            this.button53.Text = "D4";
            this.button53.UseVisualStyleBackColor = true;
            // 
            // button54
            // 
            this.button54.ForeColor = System.Drawing.Color.DarkBlue;
            this.button54.Location = new System.Drawing.Point(71, 34);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(55, 35);
            this.button54.TabIndex = 8;
            this.button54.Text = "D6";
            this.button54.UseVisualStyleBackColor = true;
            // 
            // button55
            // 
            this.button55.ForeColor = System.Drawing.Color.DarkBlue;
            this.button55.Location = new System.Drawing.Point(132, 34);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(55, 35);
            this.button55.TabIndex = 7;
            this.button55.Text = "D5";
            this.button55.UseVisualStyleBackColor = true;
            // 
            // button56
            // 
            this.button56.ForeColor = System.Drawing.Color.DarkBlue;
            this.button56.Location = new System.Drawing.Point(10, 34);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(55, 35);
            this.button56.TabIndex = 6;
            this.button56.Text = "D7";
            this.button56.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox14.Controls.Add(this.tempNumber);
            this.groupBox14.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(323, 12);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(281, 273);
            this.groupBox14.TabIndex = 48;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "درجة الحرارة";
            this.groupBox14.Enter += new System.EventHandler(this.groupBox14_Enter);
            // 
            // tempNumber
            // 
            this.tempNumber.AutoSize = true;
            this.tempNumber.Font = new System.Drawing.Font("DS-Digital", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempNumber.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tempNumber.Location = new System.Drawing.Point(19, 67);
            this.tempNumber.Name = "tempNumber";
            this.tempNumber.Size = new System.Drawing.Size(240, 165);
            this.tempNumber.TabIndex = 47;
            this.tempNumber.Text = "00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox16.Controls.Add(this.startEmilation);
            this.groupBox16.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.Location = new System.Drawing.Point(321, 303);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox16.Size = new System.Drawing.Size(285, 132);
            this.groupBox16.TabIndex = 7;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "التشغيل";
            // 
            // startEmilation
            // 
            this.startEmilation.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.startEmilation.ForeColor = System.Drawing.Color.White;
            this.startEmilation.Location = new System.Drawing.Point(34, 61);
            this.startEmilation.Name = "startEmilation";
            this.startEmilation.Size = new System.Drawing.Size(216, 48);
            this.startEmilation.TabIndex = 5;
            this.startEmilation.Text = "بدء";
            this.startEmilation.UseVisualStyleBackColor = false;
            this.startEmilation.Click += new System.EventHandler(this.startEmilation_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Font = new System.Drawing.Font("SST Arabic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox8.Location = new System.Drawing.Point(12, 572);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(1253, 125);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "lPT2";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.button6);
            this.groupBox9.Location = new System.Drawing.Point(846, 31);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(388, 81);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Out Put Port";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(306, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Out5";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(232, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Out4";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(158, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Out3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(84, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Out1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.DarkBlue;
            this.button6.Location = new System.Drawing.Point(10, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 35);
            this.button6.TabIndex = 6;
            this.button6.Text = "Out0";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox10.Controls.Add(this.button7);
            this.groupBox10.Controls.Add(this.button8);
            this.groupBox10.Controls.Add(this.button9);
            this.groupBox10.Controls.Add(this.button11);
            this.groupBox10.Controls.Add(this.button12);
            this.groupBox10.Location = new System.Drawing.Point(511, 31);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(325, 81);
            this.groupBox10.TabIndex = 19;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Input Port";
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.DarkBlue;
            this.button7.Location = new System.Drawing.Point(254, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 35);
            this.button7.TabIndex = 10;
            this.button7.Text = "In 3";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.DarkBlue;
            this.button8.Location = new System.Drawing.Point(193, 34);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 35);
            this.button8.TabIndex = 9;
            this.button8.Text = "In 4";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.DarkBlue;
            this.button9.Location = new System.Drawing.Point(71, 34);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 35);
            this.button9.TabIndex = 8;
            this.button9.Text = "In 6";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.DarkBlue;
            this.button11.Location = new System.Drawing.Point(132, 34);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 35);
            this.button11.TabIndex = 7;
            this.button11.Text = "In 5";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.Color.DarkBlue;
            this.button12.Location = new System.Drawing.Point(10, 34);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 35);
            this.button12.TabIndex = 6;
            this.button12.Text = "In 7";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox11.Controls.Add(this.button13);
            this.groupBox11.Controls.Add(this.button17);
            this.groupBox11.Controls.Add(this.button18);
            this.groupBox11.Controls.Add(this.button19);
            this.groupBox11.Controls.Add(this.button20);
            this.groupBox11.Controls.Add(this.button27);
            this.groupBox11.Controls.Add(this.button28);
            this.groupBox11.Controls.Add(this.button29);
            this.groupBox11.Location = new System.Drawing.Point(16, 31);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(485, 81);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Data Port";
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.Color.DarkBlue;
            this.button13.Location = new System.Drawing.Point(419, 34);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 35);
            this.button13.TabIndex = 13;
            this.button13.Text = "D0";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.ForeColor = System.Drawing.Color.DarkBlue;
            this.button17.Location = new System.Drawing.Point(365, 34);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(55, 35);
            this.button17.TabIndex = 12;
            this.button17.Text = "D1";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.ForeColor = System.Drawing.Color.DarkBlue;
            this.button18.Location = new System.Drawing.Point(315, 34);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(55, 35);
            this.button18.TabIndex = 11;
            this.button18.Text = "D2";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.ForeColor = System.Drawing.Color.DarkBlue;
            this.button19.Location = new System.Drawing.Point(254, 34);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 35);
            this.button19.TabIndex = 10;
            this.button19.Text = "D3";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.ForeColor = System.Drawing.Color.DarkBlue;
            this.button20.Location = new System.Drawing.Point(193, 34);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(55, 35);
            this.button20.TabIndex = 9;
            this.button20.Text = "D4";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.ForeColor = System.Drawing.Color.DarkBlue;
            this.button27.Location = new System.Drawing.Point(71, 34);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(55, 35);
            this.button27.TabIndex = 8;
            this.button27.Text = "D6";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.ForeColor = System.Drawing.Color.DarkBlue;
            this.button28.Location = new System.Drawing.Point(132, 34);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(55, 35);
            this.button28.TabIndex = 7;
            this.button28.Text = "D5";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.ForeColor = System.Drawing.Color.DarkBlue;
            this.button29.Location = new System.Drawing.Point(10, 34);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(55, 35);
            this.button29.TabIndex = 6;
            this.button29.Text = "D7";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // readerTimer
            // 
            this.readerTimer.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1303, 721);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نظام الطاقة الشمسية";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private VerticalProgressBar solar_tank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button startRandomFill;
        private System.Windows.Forms.Button makeEmpty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.GroupBox groupBox13;
        public System.Windows.Forms.Button start33;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label th35;
        public System.Windows.Forms.Button start100;
        public System.Windows.Forms.Button start67;
        private System.Windows.Forms.Label th100;
        private System.Windows.Forms.Label th72;
        private System.Windows.Forms.ListBox temprListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTempr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label tempNumber;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button startEmilation;
        private System.Windows.Forms.Button stopFill;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer readerTimer;
    }
}

