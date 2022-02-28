using System;

namespace VectorAlgebra
{
    public class Vector
    {
        public double X;
        public double Y;
        public double Z;

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector a,Vector b)
        {
            return new Vector(
                a.X + b.X,
                a.Y + b.Y,
                a.Z + b.Z);    
        }

        public override string ToString()
        {
            return $"({X}; {Y}; {Z})";
        }
    }
}
