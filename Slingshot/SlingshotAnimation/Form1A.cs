using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlingshotAnimation
{
    public partial class Form1A : Form
    {
        int tickCount;

        int windowWidth;
        int windowHeight;

        Point down;

        List<TrajectoryA> list;
        List<TrajectoryA> toBeRemoved;


        public Form1A()
        {

            InitializeComponent();
            Timer t = new Timer();
            Graphics g = this.CreateGraphics();
            list = new List<TrajectoryA>();
            toBeRemoved = new List<TrajectoryA>();
            windowWidth = this.Width;
            windowHeight = this.Height;
            this.BackColor = Color.White;
            t.Start();
            t.Interval = 50;
            t.Tick += T_Tick;
            MouseDown += Form1A_MouseDown;
            MouseUp += Form1A_MouseUp;
        }

       
        private void T_Tick(object sender, EventArgs e)
        {
            tickCount++;

           Graphics g = this.CreateGraphics();
           foreach(TrajectoryA shape in list)
           {
                Point end = shape.FindFinalPos(--tickCount);
                // g.DrawEllipse(new Pen(Brushes.White), new Rectangle(shape.down.X, shape.down.Y, 5, 5));

                //check if end.X or end.Y is out of frame
                if (end.X >= windowWidth || end.Y >= windowHeight || end.X <= 0)
                {                   
                    if(end.X >= windowWidth || end.X <= 0)
                    {
                        //handle left bounce
                        if (end.X <= 0 )
                        {
                            if (end.X / windowWidth % 2 == 0)
                            {
                                g.DrawEllipse(new Pen(Brushes.Black), new Rectangle(-(end.X % windowWidth), end.Y, 5, 5));
                            }
                            else
                            {
                                g.DrawEllipse(new Pen(Brushes.Black), new Rectangle(windowWidth+(end.X % windowWidth), end.Y, 5, 5));
                            }
                        }
                        //handle right bounce
                        if(end.X >= windowWidth)
                        {                           
                            if (end.X / windowWidth % 2 == 0)
                            {
                                g.DrawEllipse(new Pen(Brushes.Black), new Rectangle((end.X % windowWidth), end.Y, 5, 5));
                            }
                            else
                            {
                                g.DrawEllipse(new Pen(Brushes.Black), new Rectangle(windowWidth - (end.X % windowWidth), end.Y, 5, 5));
                            }
                        }
                    }
                    if (end.Y >= windowHeight)
                    {
                        toBeRemoved.Add(shape);
                    }
                }
                else
                {
                    try
                    {
                        //increment t and redraw in black pen
                        g.DrawEllipse(new Pen(Brushes.Black), new Rectangle(end.X, end.Y, 5, 5));
                        //g.DrawEllipse(new Pen(Brushes.Black), new Rectangle(shape.down.X, shape.down.Y, 5, 5));
                    }
                    catch (Exception)
                    {
                        g.DrawString("x=" + end.X + "y=" + end.Y, DefaultFont, Brushes.Black, new Point(5,5));
                    }
                }
            }
           foreach(TrajectoryA shape in toBeRemoved)
            {
                list.Remove(shape);
            }
            toBeRemoved = new List<TrajectoryA>();
        }

       

        private void Form1A_MouseDown(object sender, MouseEventArgs e)
        {
            down = new Point(e.X, e.Y);
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Brushes.Black),new Rectangle(down.X, down.Y, 5, 5));

        }

        private void Form1A_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point up = new Point(e.X, e.Y);

            if (down.X - up.X > down.X)
            {
                Point curr = new Point((down.X - (down.X - up.X)), (down.Y - (down.Y - up.Y)));
                TrajectoryA temp = new TrajectoryA(down, up, tickCount);
                list.Add(temp);
            }
            else
            {
                Point curr = new Point((down.X + (down.X - up.X)), (down.Y + (down.Y - up.Y)));
                TrajectoryA temp = new TrajectoryA(down, up, tickCount);
                list.Add(temp);
            }
        }

        private void Form1A_ClientSizeChanged(object sender, EventArgs e)
        {
            windowWidth = this.Width;
            windowHeight = this.Height;
        }
    }
}
