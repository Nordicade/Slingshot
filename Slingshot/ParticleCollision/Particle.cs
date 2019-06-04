using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleCollision
{
    public partial class Particle : Form
    {
        static Particle _instance;
        List<Ball> sList = new List<Ball>();
        List<Ball> toBeRemoved = new List<Ball>();

        int tickCount;

        public Particle()
        {          
            InitializeComponent();
            tickCount = 0;
            this.Width = 500;
            this.Height = 500;
            Timer t = new Timer();
            t.Start();
            t.Interval = 10;
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Ball toBeAdded = null;
            foreach (Ball p in sList)
            {
                p.x = p.x + (p.xDir / p.mass);
                p.y = p.y + (p.yDir / p.mass);
                if (p.x >= this.Width - 25 || p.x <= 0)
                {
                    p.xDir = p.xDir * -1;
                }
                if (p.y >= this.Height - 45 || p.y <= 0)
                {
                    p.yDir = p.yDir * -1;
                }
                foreach (Ball q in sList)
                {
                    if (Math.Abs(q.x - p.x) <= (5) && !p.Equals(q) && Math.Abs(q.y - p.y) <= 5)
                    {
                        if (Math.Abs(p.yDir + q.yDir) != 2)
                        {
                            p.yDir = p.yDir * -1;
                            q.yDir = q.yDir * -1;
                        }
                        if (Math.Abs(p.xDir + q.xDir) != 2)
                        {
                            p.xDir = p.xDir * -1;
                            q.xDir = q.xDir * -1;
                        }
                    }
                }
            }

            tickCount++;

            this.Refresh();
        }

        //private void T_Tick(object sender, EventArgs e)
        //{
        //    Ball toBeAdded = null;
        //    foreach (Ball p in sList)
        //    {
        //        p.x = p.x + (p.xDir / p.mass);
        //        p.y = p.y + (p.yDir / p.mass);
        //        if (p.x >= this.Width - 25 || p.x <= 0)
        //        {
        //            p.xDir = p.xDir * -1;
        //        }
        //        if (p.y >= this.Height - 45 || p.y <= 0)
        //        {
        //            p.yDir = p.yDir * -1;
        //        }
        //        foreach (Ball q in sList)
        //        {
        //            if (Math.Abs(q.x - p.x) <= (5) && !p.Equals(q) && Math.Abs(q.y - p.y) <= 5)
        //            {
        //                toBeAdded = new Ball(q.x, q.y, (p.xDir + q.xDir), (q.xDir + p.xDir), tickCount, q.mass + p.mass);
        //                toBeRemoved.Add(q);
        //                toBeRemoved.Add(p);
        //            }
        //        }
        //    }
        //    foreach (Ball s in toBeRemoved)
        //    {
        //        sList.Remove(s);
        //    }
        //    toBeRemoved.Clear();
        //    if (toBeAdded != null)
        //    {
        //        sList.Add(toBeAdded);
        //    }
        //    tickCount++;

        //    this.Refresh();
        //}


        public static Particle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Particle();
                    return _instance;
                }
                return _instance;
            }
        }

        private void Particle_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Particle_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            this.Dispose();
        }

        private void Particle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            foreach (Ball p in sList)
            {
                g.DrawEllipse(new Pen(Brushes.Black), p.x, p.y, 5 * p.mass, 5 * p.mass);
            }
        }

        private void Particle_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //randomize initial slope
            Random rng = new Random();            
            Ball b = new Ball(e.X, e.Y, rng.Next(-10,10), rng.Next(-10,10), tickCount);
            sList.Add(b);
        }
    }
}
//p.x = p.x + (tickCount - p.tickCreated);
//                p.y = p.y + p.slope* (tickCount - p.tickCreated);
//                if (p.y >= this.Height - 50 || p.y <= 0)
//                {
//    p.slope = -p.slope;
//    p.y = Math.Abs(p.y);
//    p.x = Math.Abs(p.x);
//}
//                if (p.x >= this.Width -20|| p.x <= 0)
//                {
//    int delta = p.x % this.Width;
//    p.x =
//    p.y = Math.Abs(p.y);
//}
//                //if (p.x >= this.Width - 5 || p.x <= 0)
//                //{
//                //    p.x =
//                //    p.y = Math.Abs(p.y);
//                //}