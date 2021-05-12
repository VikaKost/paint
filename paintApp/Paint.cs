using System.Drawing;

namespace paintApp
{
    public interface Paint
    {
        bool poly { get; }
        Figure getFigure(Pen pen, Color FillColor, int angles);
    }
}