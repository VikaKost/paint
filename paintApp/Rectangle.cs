using System;
using System.Drawing;
using System.Runtime.Serialization;


namespace paintApp
{
    [DataContract]
    public class Rectangle : Figure
    {
        [DataMember]
        private Brush brush;
        public Rectangle(Pen pen, Color fillColor, int angles) : base(pen, fillColor, angles)
        {
            brush = new SolidBrush(fillColor);
        }
        
        public override void Drawing(Graphics graphics)
        {
            Point point1 = new Point(Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y));
            Point point2 = new Point(Math.Max(points[0].X, points[1].X), Math.Max(points[0].Y, points[1].Y));
            graphics.DrawRectangle(figurePen, point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
            graphics.FillRectangle(brush, point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
        }
    }
}