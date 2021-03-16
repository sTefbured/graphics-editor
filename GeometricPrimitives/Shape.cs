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

        protected Shape()
        {
            Bounds = new Rectangle();
        }

        public Rectangle GetBounds()
        {
            return Bounds;
        }
        
        public void SetBounds(Point point1, Point point2)
        {
            Bounds = new Rectangle(point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
        }

        public abstract void Draw(Graphics graphics);
    }
}