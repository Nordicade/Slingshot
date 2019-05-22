using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlingshotAnimation
{

    class TrajectoryA
    {
        public Point down;
        public Point up;
        public double initialV;
        public double startTime;

        const double acceleration = 9.8;

        public TrajectoryA(Point _down, Point _up, double _time)
        {
            down = _down;
            up = _up;
            initialV = FindSlope(down, up);
            startTime = _time;
        }

        public double FindFinalV()
        {
            return initialV + (acceleration * startTime);
        }

        public Point FindFinalPos(double time)
        {
            int finalX;
            int finalY;

            double deltaTime = time - startTime;

            int deltaY = up.Y - down.Y;
            int deltaX = up.X - down.X;

            finalX = down.X + (int)(deltaX * deltaTime); //+ (int)(.5 * (acceleration * (time * time)));
            finalY = down.Y + (int)(deltaY * deltaTime) + (int)(.5 * (acceleration * (deltaTime * deltaTime)));
           
            return new Point(finalX, finalY);
        }

        private double FindSlope(Point down, Point up)
        {
            double deltaY = (up.Y - down.Y);
            double deltaX = -(up.X - down.X);
            double slope = (deltaY / deltaX);
            if(deltaX == 0)
            {
                return 1;
            }
            return slope;

        }

        public Point FindLBouncePos(double time)
        {
            int finalX;
            int finalY;

            double deltaTime = time - startTime;

            int deltaY = up.Y - down.Y;
            int deltaX = up.X - down.X;

            finalX = down.X + (int)(deltaX * deltaTime); //+ (int)(.5 * (acceleration * (time * time)));
            finalY = down.Y + (int)(deltaY * deltaTime) + (int)(.5 * (acceleration * (deltaTime * deltaTime)));
           

            return new Point(-finalX, finalY);
        }
        public Point FindRBouncePos(double time)
        {
            int finalX;
            int finalY;

            double deltaTime = time - startTime;

            int deltaY = up.Y - down.Y;
            int deltaX = up.X - down.X;
          

            finalX = - (int)(deltaX * deltaTime); //+ (int)(.5 * (acceleration * (time * time)));
            finalY = down.Y + (int)(deltaY * deltaTime) + (int)(.5 * (acceleration * (deltaTime * deltaTime)));            
            //if finalX + deltaX { then the trajectory resumes at up.X
            //if finalX { then the trajectory resumes at down.X
            return new Point(finalX, finalY);
        }
    }
}
