using System;
using System.Drawing;

namespace paintApp
{
    public class Circle : Figure
    {
        private Brush brush;
        public Circle(Pen pen, Color fillColor, int angles) : base(pen, fillColor, angles)
        {
            brush = new SolidBrush(fillColor);
        }
        
        public override void Drawing(Graphics graphics)
        {
            graphics.DrawEllipse(figurePen, points[0].X, points[0].Y, points[1].X - points[0].X, points[1].Y - points[0].Y);
            graphics.FillEllipse(brush, points[0].X, points[0].Y, points[1].X - points[0].X, points[1].Y - points[0].Y);
        }
    }
}