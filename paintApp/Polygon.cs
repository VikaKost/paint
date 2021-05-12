using System;
using System.Drawing;

namespace paintApp
{
    public class Polygon : Figure
    {
        private Brush brush;
        private int ang;
        public Polygon(Pen pen, Color fillColor, int angles) : base(pen, fillColor, angles)
        {
            brush = new SolidBrush(fillColor);
            ang = angles;
        }

        public override void Drawing(Graphics graphics)
        {
            Point[] angles = new Point[ang];
            angles[0] = points[1];
            double d = Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
            Point center = new Point();
            center.X = (points[0].X + points[1].X) / 2;
            center.Y = (points[0].Y + points[1].Y) / 2;
            double a = d * Math.Sin(Math.PI / ang);
            double angle = Math.PI * 2 / ang;
            for (int i = 1; i < ang; i++)
            {
                Point temp = new Point();
                temp.X = (angles[i-1].X - center.X);
                temp.Y = (angles[i-1].Y - center.Y);
                Point temp_new = new Point();
                temp_new.X = Convert.ToInt32(temp.X * Math.Cos(angle) - temp.Y * Math.Sin(angle));
                temp_new.Y = Convert.ToInt32(temp.X * Math.Sin(angle) + temp.Y * Math.Cos(angle));
                Point new_point = new Point();
                new_point.X = center.X + temp_new.X;
                new_point.Y = center.Y + temp_new.Y;
                angles[i] = new_point;
            }
            graphics.DrawPolygon(figurePen, angles);
            graphics.FillPolygon(brush, angles);

        }
    }
}