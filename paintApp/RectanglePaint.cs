using System.Drawing;

namespace paintApp
{
    public class RectanglePaint : Paint
    {
        public Figure getFigure(Pen pen, Color FillColor, int angles)
        {
            return new Rectangle(pen, FillColor, angles);
        }
        
        public bool poly { get { return false; } }
    }
}