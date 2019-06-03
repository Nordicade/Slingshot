using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleCollision
{
    class Ball
    {
        public int x;
        public int y;
        public int xDir;
        public int yDir;
        public int tickCreated;
        public int mass;
        public Ball(int startX, int startY, int _xDir, int _yDir, int _tickCreated)
        {
            x = startX;
            y = startY;
            xDir = _xDir;
            yDir = _yDir;
            tickCreated = _tickCreated;
            mass = 1;
        }

        public Ball(int startX, int startY, int _xDir, int _yDir, int _tickCreated, int _mass)
        {
            x = startX;
            y = startY;
            xDir = _xDir;
            yDir = _yDir;
            tickCreated = _tickCreated;
            mass = _mass;
        }

    }
}
