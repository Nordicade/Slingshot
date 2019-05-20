using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slingshot
{
    class Trajectory
    {
        public Pen p;
        public int x;
        public int y;
        public int width;
        public int height;
        public long startAngle;
        public long sweepAngle;
        
        public Trajectory(Pen _p, int _x, int _y, int _width, int _height, long _startAngle, long _sweepAngle)
        {
            p = _p;
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            startAngle = _startAngle;
            sweepAngle = _sweepAngle;
        }
    }
}
