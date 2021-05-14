using System.Drawing;

namespace paintApp
{
    public abstract class Figure
    {
        public Point[] points;
        
        public Pen figurePen { get; set; }

        public Figure(Pen pen, Color fillColor, int angles)
        {
            figurePen = pen;
        }
        public abstract void Drawing(Graphics graphics);   
    }
}