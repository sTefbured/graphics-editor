using System;
using System.Drawing;
using GeometricPrimitives;

namespace Line
{
    [Serializable]
    public class Line : Shape
    {
        public Line()
        {
        }

        public Line(Pen pen) : base(pen)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(GetPen(), Bounds.X, Bounds.Y,
                Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height);
        }
    }
}