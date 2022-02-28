using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Rectangle : Shapes

    {
        public Point TopLeft;

        private float width;

        public float Height
        {
            get { return width; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательная ширина");

                width = value;
            }
        }
        private float height;

        public float Height
        {
            get { return height; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательная высота");

                width = value;
            }
        }
        public override void  Draw()
        {
            Console.Write("Рисуем ");
            PrintInfo();
        }
        public override void PtintInfo()
        {
            Console.WriteLine($"Прямоугольнрик с вершиной ({TopLeft.X};{TopLeft.Y}) шириной {Width} и высотой {Height}");
        }

    }
}
