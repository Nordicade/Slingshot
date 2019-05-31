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
            
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            EraseOldWave();

            //draw 3 wave windows
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(40, 40, 360, 200));
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(410, 40, 360, 200));
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(0, 260, 820, 400));
            //left square wave

            int length = 360;
            PointF[] leftPList = new PointF[length];
            for (int i = 0; i < length; i++)
            {
                //double amplitude = 10;
                //double constant = 1000;
                //double frequency = 1;

                double amplitude = 55; //range from 1 to 50
                double constant = .015;  //range from .015 to 1
                double frequency = 1;
                double slider = 2;
                //double y = amplitude * Math.Sin(constant * i - (frequency * i));
                double y = amplitude * Math.Sin(constant * i + slider);
                leftPList[i] = new PointF(40 + i, 140 + (float)y);
                for(int index = 0; index < length; index++)
                {
                    toBeRemovedL[index] = leftPList[index];
                }
            }
            g.DrawLines(new Pen(Brushes.Black), leftPList);

            //left square wave

            PointF[] rightPList = new PointF[length];
            for (int i = 0; i < length; i++)
            {
                //double amplitude = 10;
                //double constant = 1000;
                //double frequency = 1;

                double amplitude = 10;
                double constant = 1000;
                double frequency = 1;
                double y = amplitude * Math.Sin(constant * i - (frequency * i));
                rightPList[i] = new PointF(410 + i, 140 + (float)y);
                for (int index = 0; index < length; index++)
                {
                    toBeRemovedR[index] = rightPList[index];
                }
            }
            g.DrawLines(new Pen(Brushes.Black), rightPList);
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

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int leftScrollValue = vScrollBar1.Value;
            textBox1.Text = leftScrollValue.ToString();
        }

        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            int rightScrollValue = vScrollBar2.Value;
            textBox2.Text = rightScrollValue.ToString();
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
    }
}
