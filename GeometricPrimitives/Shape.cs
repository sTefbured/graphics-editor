using System;
using System.Drawing;

namespace GeometricPrimitives
{
    [Serializable]
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics, Pen pen);
    }
}