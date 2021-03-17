using System;
using System.Drawing;
using System.Xml.Serialization;
using GeometricPrimitives;

namespace Rectangle
{
    [Serializable]
    [XmlType("Rectangle.Rectangle")]
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public Rectangle(Pen pen, Point first, Point second) : base(pen, first, second)
        {
        }

        public override void Draw(Graphics graphics)
        {
            Point point1 = Bounds.Location;
            Point point2 = new Point(Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height);
            if (point1.X > point2.X)
            {
                point1.X ^= point2.X;
                point2.X ^= point1.X;
                point1.X ^= point2.X;
            }
            if (point1.Y > point2.Y)
            {
                point1.Y ^= point2.Y;
                point2.Y ^= point1.Y;
                point1.Y ^= point2.Y;
            }

            graphics.DrawRectangle(CreatePen(), point1.X, point1.Y, point2.X, point2.Y);
        }
    }
}