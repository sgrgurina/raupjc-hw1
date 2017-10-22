﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            if (a.X > b.X + b.Width)
            {
                return false;
            }
            if (a.X + a.Width < b.X)
            {
                return false;
            }
            if(a.Y > b.Y+b.Height)
            {
                return false;
            }
            if (a.Y + a.Height < b.Y)
            {
                return false;
            }

            return true;
        }
    }
}
