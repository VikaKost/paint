using System.Drawing;

namespace paintApp
{
    public class CirclePaint : Paint
    {
        public Figure getFigure(Pen pen, Color FillColor, int angles)
        {
            return new Circle(pen, FillColor, angles);
        }
        
        public bool poly { get { return false; } }
    }
}