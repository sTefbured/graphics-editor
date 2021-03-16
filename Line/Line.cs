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
        
        public Line(Pen pen, Point first, Point second)
        {
            Red = pen.Color.R;
            Green = pen.Color.G;
            Blue = pen.Color.B;
            Width = pen.Width;
            SetBounds(first, second);
        }

        public override void Draw(Graphics graphics)
        {
            Rectangle bounds = GetBounds();
            Color color = Color.FromArgb(255, Red, Green, Blue);
            Pen pen = new Pen(color, Width);
            graphics.DrawLine(pen, bounds.X, bounds.Y, 
                bounds.X + bounds.Width, bounds.Y + bounds.Height);
        }
    }
}