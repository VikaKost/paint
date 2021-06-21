using System;
using System.Drawing;
using paintApp;

namespace Trapez
{
    public class TrapezPaint : Paint
    {
        public Figure getFigure(Pen pen, Color FillColor, int angles)
        {
            return new Trapez(pen, FillColor, angles);
        }
        public bool poly { get { return false; } }
    }
}