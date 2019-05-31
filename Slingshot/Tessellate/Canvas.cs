using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tessellate
{
    public partial class Canvas : Form
    {
        List<Triangle> tList;
        Pen p;

        public static Canvas _instance;
        public Canvas()
        {
            InitializeComponent();
            this.MinimumSize = new Size(500,600);
            tList = new List<Triangle>();
         
        }

        public void StartingPoints(Graphics g)
        {
            p = new Pen(Brushes.Black);
            int min = 1;
            int windowWidth = 500;
            int windowHeight = 500;
            Point corner1 = new Point(min,min);
            Point corner2 = new Point(windowWidth, min);
            Point corner3 = new Point(min, windowHeight);
            Point corner4 = new Point(windowWidth, windowHeight);
            Random rng = new Random();
            Point eccentricP = new Point(rng.Next(windowWidth-5), rng.Next(windowHeight-5));
            Triangle t1 = new Triangle(corner1, corner2, eccentricP);
            Triangle t2 = new Triangle(corner1, corner3, eccentricP);
            Triangle t3 = new Triangle(corner2, corner4, eccentricP);
            Triangle t4 = new Triangle(corner3, corner4, eccentricP);
            ConnectPoints(t1);
            ConnectPoints(t2);
            ConnectPoints(t3);
            ConnectPoints(t4);
            
        }

        public Triangle FindTriangleWithin(Triangle t)
        {
            
            return new Triangle(new Point(2, 3), new Point(2, 3), new Point(3, 4));
        }

        public void ConnectPoints(Triangle t)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(p, t.p1, t.p2);
            g.DrawLine(p, t.p2, t.p3);
            g.DrawLine(p, t.p3, t.p1);
        }

        public static Canvas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Canvas();
                    return _instance;
                }
                return _instance;
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            StartingPoints(g);
        }
    }
  
}
