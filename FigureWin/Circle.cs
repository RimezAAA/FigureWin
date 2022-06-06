using System.Drawing;

namespace Figure2
{
    class Circle : FilledFigure
    {
        public int Radius;
        Graphics g;
        Pen color;
        public Circle(Graphics g, Pen color, int x1, int x2, int radius) : base(x1 , x2)
        {
            Radius = radius;
            this.color = color;
            this.g = g;
            this.Draw();
        }

        public override void Draw()
        {
            g.DrawEllipse(color, base.basePoint.X - Radius/2, base.basePoint.Y - Radius/2, Radius, Radius);
        }

        public override string GetInfo()
        {
            return $"circle {base.basePoint.X} {base.basePoint.Y} {Radius}";
        }
    }
}
