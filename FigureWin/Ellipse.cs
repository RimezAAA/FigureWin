using System.Drawing;

namespace Figure2
{
    class Ellipse : FilledFigure
    {
        public int width, height;
        Graphics g;

        public Ellipse(Graphics g, Pen color, int x1, int x2, int width, int height) : base(x1, x2, color)
        {
            this.width = width;
            this.height = height;
            this.g = g;
            this.Draw();
        }
        public override void Draw()
        {
            g.DrawEllipse(new Pen(Color.FromArgb(Stroke.Color), Stroke.Width), base.basePoint.X, base.basePoint.Y, width, height);
        }

        public override string GetInfo()
        {
            return $"ellipse {base.basePoint.X} {base.basePoint.Y} {width} {height} {Stroke.Color} {Stroke.Width}";
        }

    }
}
