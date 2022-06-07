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

        public Line(Graphics g,Pen color, int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            B = new Point(x2, y2);
            this.g = g;
            Stroke.Color = color.Color.ToArgb();
            Stroke.Width = Convert.ToInt32(color.Width);
            this.Draw();
        }

        public override void Draw()
        {
            g.DrawLine(new Pen(Color.FromArgb(Stroke.Color), Stroke.Width), A.X, A.Y, B.X, B.Y);
        }

        public override string GetInfo()
        {
            return $"line {base.basePoint.X} {base.basePoint.Y} {B.X} {B.Y} {Stroke.Color} {Stroke.Width}";
        }
    }
}
