using System;
using System.Drawing;


namespace shapes
{
    public abstract class Shapes
    {
        public abstract Color OutlineColor { get; set; }
        public abstract Color FillColor { get; set; }
        public abstract void Draw();
        public abstract void PrintInfo();

    }
}
