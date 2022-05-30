namespace Figure2
{
    class Figure
    {
        protected Point basePoint;

        public Figure(Point point)
        {
            basePoint = point;
        }

        public Figure(int x = 0, int y = 0)
        {
            basePoint = new Point(x, y);
        }

        public virtual void Draw()
        { }

        public virtual string GetInfo()
        { return $"{basePoint.X}, {basePoint.Y}"; }
    }
}
