using System;
using System.Drawing;
using GeometricPrimitives;

namespace Ellipse
{
    [Serializable]
    public class Ellipse : Shape
    {
        public Ellipse()
        {
        }

        public Ellipse(Pen pen) : base(pen)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(GetPen(), Bounds);
        }
    }
}