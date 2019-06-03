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
        int tickCount;

        public Particle()
        {
            InitializeComponent();
            tickCount = 0;
            Timer t = new Timer();
            t.Start();
            t.Interval = 100;
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {

            foreach(Ball p in sList)
            {
                p.x = p.x + (tickCount - p.tickCreated);
                p.y = p.y + p.slope * (tickCount - p.tickCreated);
                if (p.y >= this.Height - 5 || p.y <= 0)
                {
                    p.slope = -p.slope;
                    p.y = Math.Abs(p.y);
                    p.x = Math.Abs(p.x);
                }
                if (p.x >= this.Width -5|| p.x <= 0)
                {
                    p.x = 
                    p.y = Math.Abs(p.y);
                }

            }
            tickCount++;

            this.Refresh();
        }

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
                g.DrawEllipse(new Pen(Brushes.Black), p.x, p.y, 5, 5);
            }
        }

        private void Particle_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //randomize initial slope
            Random rng = new Random();
            int randomizedSlope = rng.Next(-3, 3);
            int slope = -2;
            //Ball b = new Ball(e.X, e.Y, slope, tickCount);
            Ball b = new Ball(e.X, e.Y, randomizedSlope, tickCount);
            sList.Add(b);
        }
    }
}
