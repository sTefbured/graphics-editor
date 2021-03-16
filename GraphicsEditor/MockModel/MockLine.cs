using System;
using System.Drawing;
using GeometricPrimitives;

namespace GraphicsEditor.MockModel
{
    [Serializable]
    public class MockLine : Shape
    {
        public MockLine() {}
        
        public MockLine(Point point1, Point point2)
        {
            SetBounds(point1, point2);
        }

        public void Initialize()
        {
            this.Red = 200;
            this.Green = 100;
            this.Blue = 50;
            this.Width = 10;
        }
        
        public override void Draw(Graphics graphics)
        {
            Color penColor = Color.FromArgb(255, Red, Green, Blue);
            Pen pen = new Pen(penColor, Width);
            graphics.DrawLine(pen, Bounds.X, Bounds.Y, 
                Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height);
        }
    }
}