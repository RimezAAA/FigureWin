using System;
using System.Drawing;

namespace Figure2
{
    class Line : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public StrokeData Stroke;
        Graphics g;
        Pen color;

        public Line(Graphics g,Pen color, int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            B = new Point(x2, y2);
            this.g = g;
            this.color = color;
            this.Draw();
        }

        public override void Draw()
        {
            g.DrawLine(color, A.X, A.Y, B.X, B.Y);
        }

        public override string GetInfo()
        {
            return $"line {base.basePoint.X} {base.basePoint.Y} {B.X} {B.Y}";
        }
    }
}
