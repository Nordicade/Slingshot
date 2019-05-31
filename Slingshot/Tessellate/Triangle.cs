using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tessellate
{
    public class Triangle
    {
        public Point p1;
        public Point p2;
        public Point p3;
        public double area;

        public Triangle(Point _p1, Point _p2, Point _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
            area = FindArea();
        }
        
        public double FindArea()
        {
            double result = (p1.X * (p2.Y - p3.Y) + p2.X * (p1.Y - p3.Y) + p3.X * (p1.Y - p2.Y)) / 2;
            return Math.Abs(result); ;
        }
    }
  
}
