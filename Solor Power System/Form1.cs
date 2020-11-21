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
        Byte LeftNumber, RightNumber;

        Byte[] Data = new Byte[2];
        Byte[] OutPut = new Byte[2];
        Byte[] InPut = new Byte[2];

        bool[,] D = new bool[2, 8];
        bool[,] O = new bool[2, 8];
        bool[,] I = new bool[2, 8];



        int[] Converter = {
            0x77,
            0x12,
            0x5D,
            0x6D,
            0x2E,
            0x6B,
            0x7B,
            0x25,
            0x7F,
            0x6F };

        Byte temperature; /// 7 bits
        bool isWaterExist;  /// 1 bit
        Byte TankState; /// 2 bits



        Byte temperature_real;
        bool isWaterExist_real;
        Byte TankState_real;


        public Form1()
        {
            InitializeComponent();
            tempNumberOne.ForeColor = System.Drawing.SystemColors.Control;
            tempNumberTwo.ForeColor = System.Drawing.SystemColors.Control;
            start100.Enabled = false;
            start33.Enabled = false;
            start67.Enabled = false;
            makeEmpty.Enabled = false;
            temprListBox.Enabled = false;
            textBoxTempr.Enabled = false;
            setCheckWater.Enabled = false;
            for (int i = 10; i < 100; i += 10)
                temprListBox.Items.Add(i.ToString());
            O[0, 2] = true;
            O[1, 2] = true;
            out2.BackColor = Color.Green;
            out2.ForeColor = SystemColors.ControlLight;
            out2_2.BackColor = Color.Green;
            out2_2.ForeColor = SystemColors.ControlLight;
        }
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void makeEmpty_Click(object sender, EventArgs e)
        {
            TankState = 0;
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
            else
            {

                start33.Enabled = false;
                readerTimer.Stop();
            }
        }
        private void start67_Click(object sender, EventArgs e)
        {
            TankState = 2;
        }
        private void start100_Click(object sender, EventArgs e)
        {
            TankState = 3;
        }
        private void temprListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  var selected = temprListBox.GetItemText(temprListBox.SelectedValue);
            var selected = temprListBox.SelectedItem.ToString();
            textBoxTempr.Text = selected;
            temperature = (byte)Int32.Parse(selected);
            tempNumberOne.Text = (Int32.Parse(selected) / 10).ToString();
            tempNumberTwo.Text = (Int32.Parse(selected) % 10).ToString();
            tempNumberOne.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            tempNumberTwo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            //System.Windows.Forms.MessageBox.Show(selected.ToString()); 
        }
        private void startEmilation_Click(object sender, EventArgs e)
        {
            #region Start 
            isStartedBtn = !isStartedBtn;
            if (!isStartedBtn)
            {
                OutPut[1] |= 0x01;
                O[1, 0] = true;
                // out32(0x27A,OutPut[1]);
                out0_2.BackColor = Color.Green;
                out0_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                O[1, 0] = false;
                OutPut[1] &= 0x0E;
                // out32(0x27A,OutPut[1]);
                out0_2.BackColor = System.Drawing.SystemColors.Control;
                out0_2.ForeColor = Color.Black;
            }
            if (!isStartedBtn)
            {
                readerTimer.Start();
                startEmilation.BackColor = Color.Red;
                startEmilation.Text = "إيقاف";
                start100.Enabled = true;
                start33.Enabled = true;
                start67.Enabled = true;
                makeEmpty.Enabled = true;
                temprListBox.Enabled = true;
                textBoxTempr.Enabled = true;
                setCheckWater.Enabled = true;
            }
            else
            {
                readerTimer.Stop();
                startEmilation.BackColor = System.Drawing.SystemColors.MenuHighlight;
                startEmilation.Text = "بدء";
                start100.Enabled = false;
                start33.Enabled = false;
                start67.Enabled = false;
                makeEmpty.Enabled = false;
                temprListBox.Enabled = false;
                textBoxTempr.Enabled = false;
                setCheckWater.Enabled = false;
            }
            #endregion
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            #region CONV
            Byte tempLower = (Byte)(temperature & 0x1F);
            tempLower *= (1 << 3);

            tempLower = (Byte)(tempLower ^ 0x80);
            InPut[0] = tempLower;
            // inp32(0x379);

            Byte tempUpper = (Byte)(temperature & 0x60);
            tempUpper /= (1 << 2);
            InPut[1] = tempUpper;
            // inp32(0x279);

            InPut[1] |= (Byte)(32 * TankState);
            if (isWaterExist) InPut[1] &= (Byte)(0x7F);
            else InPut[1] |= (Byte)(0x80);
            for (int i = 3; i <= 7; i++)
            {
                if ((byte)(InPut[0] & (1 << i)) == 0) I[0, i] = false;
                else I[0, i] = true;
                if ((byte)(InPut[1] & (1 << i)) == 0) I[1, i] = false;
                else I[1, i] = true;
            }
            #endregion

            #region I[0,j]
            if (I[0, 3])
            {
                In3.BackColor = Color.Green;
                In3.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                In3.BackColor = System.Drawing.SystemColors.Control;
                In3.ForeColor = Color.Black;
            }
            if (I[0, 4])
            {
                In4.BackColor = Color.Green;
                In4.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                In4.BackColor = System.Drawing.SystemColors.Control;
                In4.ForeColor = Color.Black;
            }
            if (I[0, 5])
            {
                In5.BackColor = Color.Green;
                In5.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                In5.BackColor = System.Drawing.SystemColors.Control;
                In5.ForeColor = Color.Black;

            }
            if (I[0, 6])
            {
                In6.BackColor = Color.Green;
                In6.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                In6.BackColor = System.Drawing.SystemColors.Control;
                In6.ForeColor = Color.Black;
            }
            if (I[0, 7])
            {
                In7.BackColor = Color.Green;
                In7.ForeColor = SystemColors.ControlLight;
            }
            else
            {

                In7.BackColor = System.Drawing.SystemColors.Control;
                In7.ForeColor = Color.Black;
            }
            #endregion

            #region I[1,j]
            if (I[1, 3])
            {
                ln3_2.BackColor = Color.Green;
                ln3_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                ln3_2.BackColor = System.Drawing.SystemColors.Control;
                ln3_2.ForeColor = Color.Black;
            }
            if (I[1, 4])
            {
                ln4_2.BackColor = Color.Green;
                ln4_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                ln4_2.BackColor = System.Drawing.SystemColors.Control;
                ln4_2.ForeColor = Color.Black;
            }
            if (I[1, 5])
            {
                ln5_2.BackColor = Color.Green;
                ln5_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                ln5_2.BackColor = System.Drawing.SystemColors.Control;
                ln5_2.ForeColor = Color.Black;
            }
            if (I[1, 6])
            {
                ln6_2.BackColor = Color.Green;
                ln6_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                ln6_2.BackColor = System.Drawing.SystemColors.Control;
                ln6_2.ForeColor = Color.Black;
            }
            if (I[1, 7])
            {
                ln7_2.BackColor = Color.Green;
                ln7_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                ln7_2.BackColor = System.Drawing.SystemColors.Control;
                ln7_2.ForeColor = Color.Black;
            }
            #endregion

            #region isWaterExist
            int x = InPut[1] / 128;
            isWaterExist_real = (x == 1) ? false : true;
            #endregion

            #region TankState Read
            x = InPut[1] & (0x60);
            TankState_real = (Byte)(x / (1 << 5));
            #endregion

            #region Temperature
            x = InPut[0];
            x ^= (1 << 7);
            x /= (1 << 3);
            if ((Byte)(InPut[1] & (1 << 3)) != 0) x += (1 << 5);
            if ((Byte)(InPut[1] & (1 << 4)) != 0) x += (1 << 6);
            temperature_real = (Byte)x;
            #endregion

            #region Enable And Disable 33 67 100
            if (isWaterExist_real)
            {
                start33.Enabled = true;
                start67.Enabled = true;
                start100.Enabled = true;
            }
            else
            {
                start33.Enabled = false;
                start67.Enabled = false;
                start100.Enabled = false;
            }
            #endregion

            #region TankState Changing
            if (TankState_real == 0 && solar_tank.Value != 0)
            {
                solar_tank.Increment(-1);
            }
            if (TankState_real == 1)
            {
                th35.Visible = true;
                th72.Visible = false;
                th100.Visible = false;
                if(solar_tank.Value < 33) solar_tank.Increment(1);
                else if(solar_tank.Value > 33) solar_tank.Increment(-1);
            }
            if (TankState_real == 2)
            {
                th35.Visible = false;
                th72.Visible = true;
                th100.Visible = false;
                if(solar_tank.Value < 67) solar_tank.Increment(1);
                else if(solar_tank.Value > 67) solar_tank.Increment(-1);
            }
            if (TankState_real == 3)
            {
                th35.Visible = false;
                th72.Visible = false;
                th100.Visible = true;
                if(solar_tank.Value < 100) solar_tank.Increment(1);
            }
            #endregion

            #region TankState On and Off [O0 , O1]
            if (TankState_real == 0)
            {
                OutPut[0] &= 0x0C;
                O[0, 0] = false;
                O[0, 1] = false;
                // out32(0x37A , OutPut[0])
                out0.BackColor = System.Drawing.SystemColors.Control;
                out0.ForeColor = Color.Black;
                out1.BackColor = System.Drawing.SystemColors.Control;
                out1.ForeColor = Color.Black;
            }
            else if (TankState_real == 1)
            {
                OutPut[0] &= 0x0D;
                OutPut[0] |= 0x08;
                O[0, 0] = true;
                O[0, 1] = false;
                // out32(0x37A , OutPut[0])
                out0.BackColor = Color.Green;
                out0.ForeColor = SystemColors.ControlLight;
                out1.BackColor = System.Drawing.SystemColors.Control;
                out1.ForeColor = Color.Black;
            }
            else if (TankState_real == 2)
            {
                OutPut[0] &= 0x0D;
                OutPut[0] |= 0x08;
                O[0, 0] = false;
                O[0, 1] = true;
                // out32(0x37A , OutPut[0])
                out0.BackColor = System.Drawing.SystemColors.Control;
                out0.ForeColor = Color.Black;
                out1.BackColor = Color.Green;
                out1.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                OutPut[0] |= 0x03;
                O[0, 0] = true;
                O[0, 1] = true;
                // out32(0x37A , OutPut[0])
                out0.BackColor = Color.Green;
                out0.ForeColor = SystemColors.ControlLight;
                out1.BackColor = Color.Green;
                out1.ForeColor = SystemColors.ControlLight;
            }
            #endregion

            #region WaterExistChanging
            if (isWaterExist_real)
            {
                OutPut[0] |= 0x08;
                O[0, 3] = true;
                // out32(0x37A , OutPut[0])
                pictureBoxRed.Visible = false;
                checkedUserWater.Visible = true;
                textwaterisExist.Text = "يوجد مياه شركة ";
            }
            else
            {
                OutPut[0] &= 0x07;
                O[0, 3] = false;
                // out32(0x37A , OutPut[0])
                pictureBoxRed.Visible = true;
                checkedUserWater.Visible = false;
                textwaterisExist.Text = "لايوجد  مياه  ";
            }
            #endregion

            #region Temp
            RightNumber = (Byte)(temperature_real % 10);
            LeftNumber = (Byte)(temperature_real / 10);
            Data[0] = (byte)Converter[RightNumber];
            Data[1] = (byte)Converter[LeftNumber];

            // out32(0x378 , Data[0])
            // out32(0x278 , Data[1])
            for (int i = 0; i <= 7; ++i)
            {
                if ((Data[0] & (1 << i)) != 0) D[0, i] = true;
                else D[0, i] = false;
                if ((Data[1] & (1 << i)) != 0) D[1, i] = true;
                else D[1, i] = false;
            }
            #endregion

            #region D[0,j]
            if (D[0, 0])
            {
                D0.BackColor = Color.Green;
                D0.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D0.BackColor = System.Drawing.SystemColors.Control;
                D0.ForeColor = Color.Black;
            }
            if (D[0, 1])
            {
                D1.BackColor = Color.Green;
                D1.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D1.BackColor = System.Drawing.SystemColors.Control;
                D1.ForeColor = Color.Black;
            }
            if (D[0, 2])
            {
                D2.BackColor = Color.Green;
                D2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D2.BackColor = System.Drawing.SystemColors.Control;
                D2.ForeColor = Color.Black;

            }
            if (D[0, 3])
            {
                D3.BackColor = Color.Green;
                D3.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D3.BackColor = System.Drawing.SystemColors.Control;
                D3.ForeColor = Color.Black;
            }
            if (D[0, 4])
            {
                D4.BackColor = Color.Green;
                D4.ForeColor = SystemColors.ControlLight;
            }
            else
            {

                D4.BackColor = System.Drawing.SystemColors.Control;
                D4.ForeColor = Color.Black;
            }
            if (D[0, 5])
            {
                D5.BackColor = Color.Green;
                D5.ForeColor = SystemColors.ControlLight;
            }
            else
            {

                D5.BackColor = System.Drawing.SystemColors.Control;
                D5.ForeColor = Color.Black;
            }
            if (D[0, 6])
            {
                D6.BackColor = Color.Green;
                D6.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D6.BackColor = System.Drawing.SystemColors.Control;
                D6.ForeColor = Color.Black;
            }
            #endregion

            #region D[1,j]
            if (D[1, 0])
            {
                D0_2.BackColor = Color.Green;
                D0_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D0_2.BackColor = System.Drawing.SystemColors.Control;
                D0_2.ForeColor = Color.Black;
            }
            if (D[1, 1])
            {
                D1_2.BackColor = Color.Green;
                D1_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D1_2.BackColor = System.Drawing.SystemColors.Control;
                D1_2.ForeColor = Color.Black;
            }
            if (D[1, 2])
            {
                D2_2.BackColor = Color.Green;
                D2_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D2_2.BackColor = System.Drawing.SystemColors.Control;
                D2_2.ForeColor = Color.Black;

            }
            if (D[1, 3])
            {
                D3_2.BackColor = Color.Green;
                D3_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D3_2.BackColor = System.Drawing.SystemColors.Control;
                D3_2.ForeColor = Color.Black;
            }
            if (D[1, 4])
            {
                D4_2.BackColor = Color.Green;
                D4_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {

                D4_2.BackColor = System.Drawing.SystemColors.Control;
                D4_2.ForeColor = Color.Black;
            }
            if (D[1, 5])
            {
                D5_2.BackColor = Color.Green;
                D5_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {

                D5_2.BackColor = System.Drawing.SystemColors.Control;
                D5_2.ForeColor = Color.Black;
            }
            if (D[1, 6])
            {
                D6_2.BackColor = Color.Green;
                D6_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                D6_2.BackColor = System.Drawing.SystemColors.Control;
                D6_2.ForeColor = Color.Black;
            }
            #endregion

            #region t
            if (isWaterExist_real)
            {
                out3.BackColor = Color.Green;
                out3.ForeColor = SystemColors.ControlLight;
                OutPut[0] |= 0x08;
                O[0, 3] = true;
            }
            else
            {
                out3.BackColor = System.Drawing.SystemColors.Control;
                out3.ForeColor = Color.Black;
                OutPut[0] &= 0x07;
                O[0, 3] = false;
            }
            #endregion

            #region O[1 ,1]
            if (solar_tank.Value != 0 && solar_tank.Value != 33 && solar_tank.Value != 67 && solar_tank.Value != 100)
            {

                O[1, 1] |= true;
                OutPut[1] |= 0x02;
                // out32(0x27A,OutPut[1])
                out1_2.BackColor = Color.Green;
                out1_2.ForeColor = SystemColors.ControlLight;
            }
            else
            {
                O[1, 1] |= false;
                OutPut[1] &= 0x0D;
                // out32(0x27A,OutPut[1])
                out1_2.BackColor = System.Drawing.SystemColors.Control;
                out1_2.ForeColor = Color.Black;
            }
            #endregion
        }

        private void textBoxTempr_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTempr.Text.Length <= 2)
            {
                tempNumberOne.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                tempNumberTwo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                if (textBoxTempr.Text.Length == 1)
                {
                    tempNumberOne.Text = 0.ToString();
                    tempNumberTwo.Text = textBoxTempr.Text;


                }
                else if (textBoxTempr.Text.Length == 2)
                {
                    tempNumberOne.Text = (Int32.Parse(textBoxTempr.Text) / 10).ToString();
                    tempNumberTwo.Text = (Int32.Parse(textBoxTempr.Text) % 10).ToString();

                }
                else {
                    tempNumberOne.Text = 0.ToString();
                    tempNumberTwo.Text = 0.ToString();
                }

            }
            else
            {
                tempNumberOne.Text = 0.ToString();
                tempNumberTwo.Text = 0.ToString();
            }
            if (textBoxTempr.Text.Length == 2)
                temperature = (byte)((Int32.Parse(textBoxTempr.Text) / 10) * 10 + (Int32.Parse(textBoxTempr.Text) % 10));
            else if (textBoxTempr.Text.Length == 1) temperature = (byte)(Int32.Parse(textBoxTempr.Text));
            else temperature = 0;
        }
        private void setCheckWater_CheckedChanged(object sender, EventArgs e)
        {
            isWaterExist = setCheckWater.Checked;
        }
        private void makeEmpty_Click_1(object sender, EventArgs e)
        {
            TankState = 0;
            th35.Visible = false;
            th72.Visible = false;
            th100.Visible = false;
        }
    }
}
