using System;
using System.Drawing;
using GeometricPrimitives;

namespace Line
{
    [Serializable]
    public class Line : Shape
    {
        public Point First { get; }
        public Point Second { get; }

        public Line(Point first, Point second)
        {
            First = first;
            Second = second;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, First, Second);
        }
    }
}