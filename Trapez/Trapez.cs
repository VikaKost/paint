using System;
using System.Drawing;
using System.Runtime.Serialization;
using paintApp;

namespace Trapez
{
    public class Trapez : Figure
    {
        [DataMember]
        private Brush brush { get; set; }

        [DataMember]
        private Point[] pointt; 

        public Trapez(Pen pen, Color fillColor, int angles) : base(pen, fillColor, angles)
        {
            brush = new SolidBrush(fillColor);
        }

        public override void Drawing(Graphics graphics)
        {
            int width = Math.Abs(points[1].X - points[0].X) / 3;
            pointt = new Point[4] { new Point(points[0].X + width, points[0].Y), new Point(points[1].X - width, points[0].Y), points[1], new Point(points[0].X, points[1].Y) };

            graphics.FillPolygon(brush, pointt);
            graphics.DrawPolygon(figurePen, pointt);
        }
    }
}