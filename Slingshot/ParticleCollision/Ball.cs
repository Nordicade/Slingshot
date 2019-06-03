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
        public int slope;
        public int tickCreated;

        public Ball(int startX, int startY, int _slope, int _tickCreated)
        {
            x = startX;
            y = startY;
            slope = _slope;
            tickCreated = _tickCreated;
        }
        
    }
}
