namespace Figure2
{
    class FilledFigure : Figure
    {
        public FillData Fill;
        public StrokeData Stroke;

        public FilledFigure(Point point) : base(point)
        {
            Fill.Color = 0xFFFFFF;
            Stroke.Color = 0x000000;
        }

        public FilledFigure(int x, int y) : base(x, y)
        {
            Fill.Color = 0xFFFFFF;
            Stroke.Color = 0x000000;
        }
    }
}
