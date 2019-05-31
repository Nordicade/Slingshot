using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveSim
{
    public partial class Wave : Form
    {
        public static Wave _instance;
        PointF[] toBeRemovedL;
        PointF[] toBeRemovedR;
        Boolean hasChanged;
        int tickCount;

        public Wave()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Size = new Size(840, 700);
            toBeRemovedL = new PointF[360];
            toBeRemovedR = new PointF[360];
            Timer t = new Timer();
            t.Start();
            t.Interval = 100;
            t.Tick += T_Tick;
            hasChanged = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            tickCount++;
            if (hasChanged || tickCount != 0)
            {
                EraseOldWave();

                //left square wave

                int length = 360;
                PointF[] leftPList = new PointF[length];
                for (int i = 0; i < length; i++)
                {
                    //double amplitude = 10;
                    //double constant = 1000;
                    //double frequency = 1;

                    double amplitude = vScrollBar1.Value; //range from 1 to 50
                    if(amplitude > 50 || amplitude < 1)
                    {
                        throw new Exception();
                    }
                    double constant = 1;
                    double scrollValue = (double) vScrollBar3.Value;              
                   // double frequency = scrollValue * Math.Pow(10, 3);  //range from .015 to 1                   
                    double frequency = scrollValue;
                    // double y = amplitude * Math.Sin(constant * i - (frequency * i));
                    double y = amplitude * Math.Sin(constant * i - (frequency * tickCount));
                    leftPList[i] = new PointF(40 + i, 140 + (float)y);
                    for (int index = 0; index < length; index++)
                    {
                        toBeRemovedL[index] = leftPList[index];
                    }
                }
                g.DrawLines(new Pen(Brushes.Black), leftPList);

                //right square wave

                PointF[] rightPList = new PointF[length];
                for (int i = 0; i < length; i++)
                {
                    double amplitude = vScrollBar2.Value;  //range from 1 to 50
                    double constant = 1;
                    double scrollValue = (double)vScrollBar4.Value;
                    double frequency = scrollValue * Math.Pow(10, 3);  //range from .015 to 1
                    double y = amplitude * Math.Sin(constant * i - (frequency * tickCount));
                    rightPList[i] = new PointF(410 + i, 140 + (float)y);
                    for (int index = 0; index < length; index++)
                    {
                        toBeRemovedR[index] = rightPList[index];
                    }
                }
                g.DrawLines(new Pen(Brushes.Black), rightPList);
                hasChanged = false;
            }
        }

        private void EraseOldWave()
        {
            if (toBeRemovedL.Length != 0)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLines(new Pen(Brushes.White), toBeRemovedL);
                toBeRemovedL = new PointF[360];
            }
            if (toBeRemovedR.Length != 0)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLines(new Pen(Brushes.White), toBeRemovedR);
                toBeRemovedR = new PointF[360];
            }

        }

        public static Wave Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Wave();
                    return _instance;

                }
                return _instance;

            }
        }

        private void vScrollBar1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(30, 30, 360, 200));
        }

        //handles vscrollbar value change for topleft (textbox1)
        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int left1ScrollValue = vScrollBar1.Value;
            textBox1.Text = "Amplitude:" + left1ScrollValue.ToString();
            hasChanged = true;
        }
        //handles vscrollbar value change for topright (textbox4)
        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            int right1ScrollValue = vScrollBar2.Value;
            textBox4.Text = "Amplitude:" + right1ScrollValue.ToString();
            hasChanged = true;
        }
        //handles vscrollbar value change for Botright (textbox2)
        private void vScrollBar4_ValueChanged(object sender, EventArgs e)
        {
              int left2ScrollValue = vScrollBar4.Value;
              textBox2.Text = "Frequency:"+ left2ScrollValue.ToString();
              hasChanged = true;
        }
        //handles vscrollbar value change for topleft
        private void vScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            int right2ScrollValue = vScrollBar3.Value;
            textBox3.Text = "Frequency:" + right2ScrollValue.ToString();
            hasChanged = true;
        }

        private void Wave_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //draw 3 wave windows
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(40, 40, 360, 200));
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(410, 40, 360, 200));
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(0, 260, 820, 400));

            //draw x axis for all 3 windows

           

        }
        private void vScrollBar1_Enter(object sender, EventArgs e)
        {
           
        }     

        private void vScrollBar1_MouseHover(object sender, EventArgs e)
        {
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {          
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
