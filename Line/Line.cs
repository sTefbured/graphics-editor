using System;
using System.Drawing;
using GeometricPrimitives;

namespace Line
{
    [Serializable]
    public class Line : Shape
    {
        private Line()
        {
        }

        public Line(Pen pen, Point first, Point second) : base(pen, first, second)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(CreatePen(), Bounds.X, Bounds.Y,
                Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height);
        }
    }
}