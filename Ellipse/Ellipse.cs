using System;
using System.Drawing;
using GeometricPrimitives;

namespace Ellipse
{
    [Serializable]
    public class Ellipse : Shape
    {
        private Ellipse()
        {
        }

        public Ellipse(Pen pen, Point first, Point second) : base(pen, first, second)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(CreatePen(), Bounds);
        }
    }
}