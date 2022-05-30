using System;
using System.Drawing;

namespace Figure2
{
    class Triangle : FilledFigure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public Point C;
        Graphics g;
        Pen color;
        System.Drawing.Point[] points = new System.Drawing.Point[4];


        public Triangle(Graphics g, Pen color ,int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
        {
            B = new Point(x2, y2);
            C = new Point(x3, y3);
            this.g = g;
            this.color = color;
            this.Draw();
            points[0] = new System.Drawing.Point(x1,y1);
            points[1] = new System.Drawing.Point(x2, y2);
            points[2] = new System.Drawing.Point(C.X, C.Y);
            points[3] = new System.Drawing.Point(x1, y1);
            this.Draw();
        }

        public override void Draw()
        {
            g.DrawLines(color, points);
        }

        public override string GetInfo()
        {
            return $"triangle {base.basePoint.X} {base.basePoint.Y} {B.X} {B.Y} {C.X} {C.Y}";
        }
    }
}
