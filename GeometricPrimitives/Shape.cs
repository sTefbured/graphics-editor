using System;
using System.Drawing;

namespace GeometricPrimitives
{
    [Serializable]
    public abstract class Shape
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public float Width { get; set; }
        public Rectangle Bounds { get; set; }
        private Pen _pen;
        
        protected Shape()
        {
            Bounds = new Rectangle();
        }

        protected Shape(Pen pen)
        {
            SetPen(pen);
        }
        
        protected Shape(Pen pen, Point first, Point second)
        {
            SetPen(pen);
            SetBounds(first, second);
        }
        
        public void SetBounds(Point point1, Point point2)
        {
            Bounds = new Rectangle(point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
        }

        protected Pen CreatePen()
        {
            Color color = Color.FromArgb(255, Red, Green, Blue);
            Pen pen = new Pen(color, Width);
            return pen;
        }

        public void SetPen(Pen pen)
        {
            _pen = pen;
            Red = pen.Color.R;
            Green = pen.Color.G;
            Blue = pen.Color.B;
            Width = pen.Width;
        }

        protected Pen GetPen()
        {
            return _pen;
        }

        public abstract void Draw(Graphics graphics);
    }
}