﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EuclidGeometry2D
{
    public class Segment
    {
       public Point A;
       public Point B;

        public double Length
        {
            get
            {
                var dx = A.X - B.X;
                var dy = A.Y - B.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public Segment(Point a,Point b)
        {
            A = a;
            B = b;
        }
    }
}
