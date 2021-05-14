using System.Drawing;

namespace paintApp
{
    public class LinePaint : Paint
    {
        public Figure getFigure(Pen pen, Color FillColor, int angles)
        {
            return new Line(pen, FillColor, angles);
        }
        
        public bool poly { get { return false; } }
    }
}