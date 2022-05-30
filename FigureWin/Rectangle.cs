using System;
using System.Drawing;

namespace Figure2
{
    class Rectangle : FilledFigure
    {
        public int Height;
        public int Width;
        Graphics g;
        Pen color;

        public Rectangle(Graphics g, Pen color, int x1, int x2, int width, int height) : base(x1, x2)
        {
            Height = height;
            Width = width;
            this.g = g;
            this.color = color;
            this.Draw();
        }

        public override void Draw()
        {
            g.DrawRectangle(color, base.basePoint.X, base.basePoint.Y, Width, Height);
        }

        public override string GetInfo()
        {
            return $"rectangle {base.basePoint.X} {base.basePoint.Y} {Height} {Width}";
        }
    }
}
