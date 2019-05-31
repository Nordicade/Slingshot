using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slingshot
{
    public partial class Form1 : Form
    {
        static int initX;
        static int initY;

        static List<Trajectory> trajectoryList = new List<Trajectory>();
        static List<Trajectory> trajectoryDList = new List<Trajectory>();

        static List<Point> pointList = new List<Point>();
        static List<Point> pointDList = new List<Point>();

        static List<Point> arrowList = new List<Point>();
        static List<Point> arrowDList = new List<Point>();

        public string status;
        Boolean pressed;

        public Form1()
        {
            this.BackColor = Color.White;            
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.button1.Click += Form1_Button1_Click;
            this.Size = new System.Drawing.Size(800, 600);
            status = "Line";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (status == "Line")
            {
                Point p = new Point(e.X, e.Y);
                pointList.Add(p);

                Graphics g = this.CreateGraphics();
                if (pointList.Count == 2)
                {
                    Point p1 = pointList[0];
                    Point p2 = pointList[1];

                    g.DrawLine(new Pen(Brushes.Black), p1.x, p1.y, p2.x, p2.y);

                    pointDList.Add(pointList[0]);
                    pointDList.Add(pointList[1]);

                    pointList.Remove(p1);
                    pointList.Remove(p2);
                    if (Math.Abs(p2.x - p1.x) == 0)
                    {
                        textBox1.Text += "Line slope: undefined.";
                    }
                    else
                    {
                        double slope = (double) (Math.Abs(p2.y - p1.y) / Math.Abs(p2.x - p1.x));
                        textBox1.Text += "Line slope: " + -(p2.y - p1.y) + "/" + Math.Abs(p2.x - p1.x) + ".\r";
                        textBox1.Text += "Line slope: " + slope + ".";
                    }
                }
            }
            else if(status == "Trajectory")
            {
                pressed = true;
                Graphics g = this.CreateGraphics();
                initX = e.X;
                initY = e.Y;
               
            }
            else if(status == "Arrow")
            {
                
                pressed = true;
                Graphics g = this.CreateGraphics();
                initX = e.X;
                initY = e.Y;
                g.DrawEllipse(new Pen(Brushes.Black), initX-5, initY-5, 10, 10);
            }
            if (status == "Wave")
            {
                Graphics g = this.CreateGraphics();
                int length = this.Width - e.X;
                PointF[] pList = new PointF[length];
                for(int i = 0; i < length; i++)
                {
                    //double amplitude = 10;
                    //double constant = 1000;
                    //double frequency = 1;
                    //
                    //double amplitude = vScrollBar2.Value;  //range from 1 to 50
                    //double constant = 1;
                    //double scrollValue = (double)vScrollBar4.Value;
                    //double frequency = scrollValue * Math.Pow(10, -3);  //range from .015 to 1

                    double amplitude = 100;
                    double constant = 1;
                    double frequency = 5;
                    double y = amplitude * Math.Sin((constant * i) - (frequency * i));
                    //double y = amplitude * Math.Sin(constant * i);
                    pList[i] = new PointF(i + e.X , e.Y + (float) y);
                }
                g.DrawLines(new Pen(Brushes.Black), pList);
                g.DrawLine(new Pen(Brushes.Black), new PointF(e.X, e.Y), new PointF(length, e.Y));
                
            }
            else
            {


            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
            if(status == "Arrow")
            {
                int deltaX = initX - e.X;
                int deltaY = initY - e.Y;

                textBox1.Text += "Velocity components = " + deltaY +"/" + deltaX;            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Graphics g = this.CreateGraphics();

            if (pressed && status == "Trajectory")
            {
                foreach (Trajectory prev in trajectoryList)
                {
                    prev.p = new Pen(Brushes.White);
                    g.DrawArc(prev.p, initX, initY, prev.width, prev.height, prev.startAngle, prev.sweepAngle);
                }
                int tempWidth = Math.Abs(initX - e.X);
                int tempHeight = Math.Abs(initY - e.Y);
                trajectoryList = new List<Trajectory>();
                //Trajectory curr = new Trajectory(new Pen(Brushes.Black), initX, initY, (e.X + initX), initY + e.Y, 180, 180);
                Trajectory curr = new Trajectory(new Pen(Brushes.Black),
                    initX, initY, tempWidth + 1, tempHeight + 1, 180, 180);
                trajectoryList.Add(curr);
                g.DrawArc(curr.p, initX, initY, curr.width, curr.height, curr.startAngle, curr.sweepAngle);

                trajectoryDList.Add(curr);

            }
            if (pressed && status == "Arrow")
            {
                textBox1.Text = "Arrow";
                if(initX - e.X  > initX)
                {
                    Point curr = new Point((initX - (initX - e.X)), (initY - (initY - e.Y)));
                    arrowList.Add(curr);
                   
                }
                else
                {
                    Point curr = new Point((initX + (initX - e.X)), (initY + (initY - e.Y)));
                    arrowList.Add(curr);
                }

                foreach (Point prev in arrowDList)
                {
                    Pen p = new Pen(Brushes.White);
                    g.DrawLine(p, initX, initY, prev.x, prev.y);
                    g.DrawEllipse(new Pen(Brushes.Black), initX-5, initY-5, 10, 10);

                }

                while (arrowList.Count != 0)
                {
                    Point p1 = arrowList[0];

                    g.DrawLine(new Pen(Brushes.Black), initX, initY, p1.x, p1.y);

                    arrowList.Remove(p1);
                    arrowDList.Add(p1);
                }


            }
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            status = "Line";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            status = "Trajectory";
        }      

        private void radioButton3_Click(object sender, EventArgs e)
        {
            status = "Arrow";
        }
        private void radioButton4_Click(object sender, EventArgs e)
        {
            status = "Wave";
        }
        private void Form1_Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Graphics g = this.CreateGraphics();

            foreach (Trajectory prev in trajectoryDList)
            {

                prev.p = new Pen(Brushes.White);
                g.DrawArc(prev.p, prev.x, prev.y, prev.width, prev.height, prev.startAngle, prev.sweepAngle);
            }
            trajectoryDList = new List<Trajectory>();

            while(pointDList.Count != 0 && pointDList.Count % 2 == 0)
            {
                Point p1 = pointDList[0];
                Point p2 = pointDList[1];

                g.DrawLine(new Pen(Brushes.White), p1.x, p1.y, p2.x, p2.y);
                pointDList.RemoveAt(0);
                pointDList.RemoveAt(0);
            }

            while (arrowDList.Count != 0 && arrowDList.Count % 2 == 0)
            {
                Point p1 = arrowDList[0];
                Point p2 = arrowDList[1];

                g.DrawLine(new Pen(Brushes.White), p1.x, p1.y, p2.x, p2.y);
                arrowDList.RemoveAt(0);
                arrowDList.RemoveAt(0);
            }
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
