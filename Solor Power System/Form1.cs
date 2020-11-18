using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ListBox = System.Windows.Controls.ListBox;

namespace Solor_Power_System
{
    public partial class Form1 : Form
    {

        bool isStartedBtn = true;

        Byte[] Data= new Byte[2];
        Byte[] OutPut = new Byte[2];
        Byte[] InPut = new Byte[2];

        bool[,] D = new bool[2, 8]; 
        bool[,] O = new bool[2, 8];
        bool[,] I = new bool[2, 8];

        Byte temperature; /// 7 bits
        Byte isWaterExist;  /// 1 bit
        Byte TankState; /// 2 bits






        public Form1()
        {

            InitializeComponent();


            tempNumber.ForeColor=System.Drawing.SystemColors.Control;
            start100.Enabled = false;
            start33.Enabled = false;
            start67.Enabled = false;
            startRandomFill.Enabled = false;
            makeEmpty.Enabled = false;
            stopFill.Enabled = false;
            temprListBox.Enabled = false;
            textBoxTempr.Enabled = false;
            for (int i=10;i<200;i+=10)
            temprListBox.Items.Add(i.ToString());
        }

        private void start_Click(object sender, EventArgs e)
        {
            startRandomFill.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(solar_tank.Value!=100)
            solar_tank.Increment(1);


            if (solar_tank.Value < 35)
            {

                th35.Visible = true;
                th72.Visible = false;
                th100.Visible = false;
            }
            else if (solar_tank.Value < 75) {
                th35.Visible = false;
                th72.Visible = true;
                th100.Visible = false;
            }
            else if (solar_tank.Value==100)
                    {
                th35.Visible = false;
                th72.Visible = false;
                th100.Visible = true;
            }

            if (solar_tank.Value==100) startRandomFill.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  timer1.Stop();
            startRandomFill.Enabled = true;
        }

        private void makeEmpty_Click(object sender, EventArgs e)
        {
            TankState = 0;


            startRandomFill.Enabled = true;
            solar_tank.Value = 0;
        }


        private void start33_Click(object sender, EventArgs e)
        {
            TankState = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (solar_tank.Value != 100)
                solar_tank.Increment(1);


            if (solar_tank.Value < 35)
            {
                th35.Visible = true;
                th72.Visible = false;
                th100.Visible = false;
            }
            else {

                start33.Enabled = false;
                readerTimer.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (solar_tank.Value != 100)
                solar_tank.Increment(1);


            if (solar_tank.Value < 72)
            {
                th35.Visible = false;
                th72.Visible = true;
                th100.Visible = false;
            }
            else
            {

                start67.Enabled = false; start33.Enabled = false;
                //timer3.Stop();
            }
        }

        private void start67_Click(object sender, EventArgs e)
        {
            //timer3.Start();
            TankState = 2;

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (solar_tank.Value != 100)
                solar_tank.Increment(1);


            if (solar_tank.Value <100)
            {
                th35.Visible = false;
                th72.Visible = false;
                th100.Visible = true;
                tempNumber.Text = solar_tank.Value.ToString();
            }
            else
            {

                start67.Enabled = false; start33.Enabled = false; start100.Enabled = false;

            //    timer4.Stop();
            }
        }

        private void start100_Click(object sender, EventArgs e)
        {
            //   timer4.Start();
            TankState = 3;
        }

        private void temprListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  var selected = temprListBox.GetItemText(temprListBox.SelectedValue);
            var selected = temprListBox.SelectedItem.ToString();
            textBoxTempr.Text = selected;
            temperature = (byte)Int32.Parse(selected);
            tempNumber.Text = selected;
            tempNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            //System.Windows.Forms.MessageBox.Show(selected.ToString()); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void startEmilation_Click(object sender, EventArgs e)
        {
            isStartedBtn = !isStartedBtn;


            if (!isStartedBtn)
            {
                readerTimer.Start();
                startEmilation.BackColor = Color.Red;
                startEmilation.Text = "إيقاف";

                start100.Enabled = true;
                start33.Enabled = true;
                start67.Enabled = true;
                startRandomFill.Enabled = true;
                makeEmpty.Enabled = true;
                stopFill.Enabled = true;
                temprListBox.Enabled = true;
                textBoxTempr.Enabled = true;
            }
            else
            {
                readerTimer.Stop();

                startEmilation.BackColor = System.Drawing.SystemColors.MenuHighlight;
                startEmilation.Text = "بدء";
                start100.Enabled = false;
                start33.Enabled = false;
                start67.Enabled = false;
                startRandomFill.Enabled = false;
                makeEmpty.Enabled = false;
                stopFill.Enabled = false;
                temprListBox.Enabled = false;
                textBoxTempr.Enabled = false;
            }

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (temperature != null) {
                Byte tempLower = (Byte)(temperature & 0x1F);
                tempLower *= 8;

                tempLower = (Byte)(tempLower ^ 0x80);
                InPut[0] = tempLower;

                Byte tempUpper = (Byte)(temperature & 0x60);
                tempUpper /= 4;
                InPut[1] = tempUpper;

                InPut[1] |= (Byte)(32 *TankState);
                InPut[1] |= (Byte)(128 * (~isWaterExist));

                

                if (textBoxTempr.Text.Length != 0)
                   // Data[0] = Int32.Parse(textBoxTempr.Text);

                Console.WriteLine(InPut[0].ToString()+ "  " +InPut[1].ToString() + " " + temperature.ToString() + " " + TankState.ToString() + " " + isWaterExist.ToString() );
            }
   


        }

        private void textBoxTempr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
