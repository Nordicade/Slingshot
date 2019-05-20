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

            
        public Form1A()
        {

            InitializeComponent();
            Timer t = new Timer();
            Graphics g = this.CreateGraphics();
            list = new List<TrajectoryA>();
            windowWidth = this.Width;
            windowHeight = this.Height;
            this.BackColor = Color.White;
            t.Start();
            t.Interval = 15;
            t.Tick += T_Tick;

        }

       
        private void T_Tick(object sender, EventArgs e)
        {
            tickCount++;

            Graphics g = this.CreateGraphics();
           foreach(TrajectoryA shape in list)
            {
                //update redraw the current shape in white pen
                Point end = shape.FindFinalPos(tickCount);
                g.DrawEllipse(new Pen(Brushes.White), new Rectangle(shape.down.X, shape.down.Y, 5, 5));

                //increment t and redraw in black pen
            }
           
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
            g.DrawEllipse(new Pen(Brushes.White), new Rectangle(down.X, down.Y, 5, 5));

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

    }
}
