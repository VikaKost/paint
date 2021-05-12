using System.Drawing;

namespace paintApp
{
    public class Polyline : Figure
    {
        private Brush brush;
        public Polyline(Pen pen, Color fillColor, int angles) : base(pen, fillColor, angles)
        {
            brush = new SolidBrush(fillColor);
        }
        
        public override void Drawing(Graphics graphics)
        {
            graphics.DrawLines(figurePen, points);
           
        }
        
    }
}