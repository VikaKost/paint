using System.Drawing;

namespace paintApp
{
    public class PolygonPaint : Paint
    {
        public Figure getFigure(Pen pen, Color FillColor, int angles)
        {
            return new Polygon(pen, FillColor, angles);
        }
        
        public bool poly { get { return false; } }
    }
}