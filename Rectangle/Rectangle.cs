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

        public Rectangle(Pen pen) : base(pen)
        {
        }

        public override void Draw(Graphics graphics)
        {
            Point location = Bounds.Location;
            Size size = Bounds.Size;
            if (size.Width < 0)
            {
                size.Width = -size.Width;
                location.X -= size.Width;
            }

            if (size.Height < 0)
            {
                size.Height = -size.Height;
                location.Y -= size.Height;
            }

            graphics.DrawRectangle(GetPen(), location.X, location.Y, size.Width, size.Height);
        }
    }
}