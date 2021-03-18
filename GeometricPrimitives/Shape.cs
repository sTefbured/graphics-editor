using System;
using System.Drawing;
using System.Drawing.Drawing2D;

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
        [NonSerialized]
        private Pen _pen;

        protected Shape()
        {
            Bounds = new Rectangle();
        }

        protected Shape(Pen pen)
        {
            SetPen(pen);
        }

        public void SetBounds(Point point1, Point point2)
        {
            Bounds = new Rectangle(point1.X, point1.Y,
                point2.X - point1.X, point2.Y - point1.Y);
        }

        public void SetPen(Pen pen)
        {
            _pen = (Pen) pen.Clone();
            Red = pen.Color.R;
            Green = pen.Color.G;
            Blue = pen.Color.B;
            Width = pen.Width;
        }

        private void InitializePen()
        {
            _pen = new Pen(Color.FromArgb(255, Red, Green, Blue), Width);
            _pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        protected Pen GetPen()
        {
            if (_pen == null)
            {
                InitializePen();
            }
            return _pen;
        }

        public abstract void Draw(Graphics graphics);
    }
}