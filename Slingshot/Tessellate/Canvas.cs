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
            ConnectPoints(t1,g);
            ConnectPoints(t2,g);
            ConnectPoints(t3,g);
            ConnectPoints(t4,g);
            FindTriangleWithin(t1);
            FindTriangleWithin(t2);
            FindTriangleWithin(t3);
            FindTriangleWithin(t4);
            foreach(Triangle element in tList)
            {
                ConnectPoints(element,g);
            }
        }

        public void FindTriangleWithin(Triangle t)
        {
            if (t.area <=1500)
            {
                return;
            }
            else
            {
                Random rng = new Random();
                double u = rng.NextDouble();
                Point between1and2;
                Point between2and3;
                Point between3and1;

                //generate between1and2
                if (t.p1.X != t.p2.X)
                {
                    
                    double slope = (double)(t.p2.Y - t.p1.Y) / (t.p2.X - t.p1.X);
                    double midX = ((t.p2.X - t.p1.X) * u + t.p1.X);
                    double midY =  (slope * (midX - t.p1.X)) + t.p1.Y; 
                    between1and2 = new Point((int)midX,(int)midY);                   
                }
                else
                {
                    //double u = rng.NextDouble();
                    double midY = (((t.p2.Y - t.p1.Y)*u)+t.p1.Y);
                    between1and2 = new Point(t.p1.X, (int)midY);
                }
                //generate between2and3
                if (t.p2.X != t.p3.X)
                {
                   // double u = rng.NextDouble();
                    double slope =(double) (t.p3.Y - t.p2.Y) / (t.p3.X - t.p2.X);
                    double midX = ((t.p3.X - t.p2.X) * u + t.p2.X);
                    double midY = (slope * (midX - t.p2.X)) + t.p2.Y;
                    between2and3 = new Point((int)midX,(int) midY);
                }
                else
                {
                    //double u = rng.NextDouble();
                    double midY = ((t.p3.Y - t.p2.Y) * u )+ t.p2.Y;
                    between2and3 = new Point(t.p2.X,(int) midY);
                }
                //generate between3and1
                if (t.p3.X != t.p1.X)
                {
                   // double u = rng.NextDouble();
                    double slope = (double)(t.p1.Y - t.p3.Y) / (t.p1.X - t.p3.X);
                    double midX = ((t.p1.X - t.p3.X) * u + t.p3.X);
                    double midY = (slope * (midX - t.p3.X)) + t.p3.Y;
                    between3and1 = new Point((int)midX, (int)midY);
                }
                else
                {
                    //double u = rng.NextDouble();
                    double midY = ((t.p1.Y - t.p3.Y) * u )+ t.p3.Y;
                    between3and1 = new Point(t.p3.X, (int)midY);
                }
                Triangle curr = new Triangle(between1and2, between2and3, between3and1);                
                tList.Add(curr);
                FindTriangleWithin(curr);
            }
        }

        public void ConnectPoints(Triangle t, Graphics g)
        {
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

        private void Canvas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            this.Dispose();
        }
    }
  
}
