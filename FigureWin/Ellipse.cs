using System.Drawing;

namespace Figure2
{
    class Ellipse : FilledFigure
    {
        public int width, height;
        Pen color;
        Graphics g;

        public Ellipse(Graphics g, Pen color, int x1, int x2, int width, int height) : base(x1, x2)
        {
            this.width = width;
            this.height = height;
            this.color = color;
            this.g = g;
            this.Draw();
        }
        public override void Draw()
        {
            g.DrawEllipse(color, base.basePoint.X, base.basePoint.Y, width, height);
        }

        public override string GetInfo()
        {
            return $"ellipse {base.basePoint.X} {base.basePoint.Y} {width} {height}";
        }

    }
}
