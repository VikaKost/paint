using System.Drawing;

namespace paintApp
{
    public class PolylinePaint : Paint
    {
        public Figure getFigure(Pen pen, Color FillColor, int angles)
        {
            return new Polyline(pen, FillColor, angles);
        }
        
        public bool poly { get { return true; } }
    }
}