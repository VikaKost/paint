using System.Runtime.Serialization;
using System.Drawing;
namespace paintApp
{
    [DataContract]
    public class Line : Figure
    {
        public Line(Pen pen, Color fillColor, int angles ) : base(pen, fillColor, angles)
        {
        }

        public override void Drawing(Graphics graphics)
        {
            graphics.DrawLines(figurePen, points);
        }
    }
}