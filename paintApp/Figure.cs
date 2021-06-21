using System.Drawing;
using System.Runtime.Serialization;

namespace paintApp
{
    [DataContract]
    public abstract class Figure
    {
        [DataMember]
        public Point[] points;
        [DataMember]
        public Color PenColor;
        [DataMember]
        public float PenWidth;
       
        public Pen figurePen { get; set; }

        public Figure(Pen pen, Color fillColor, int angles)
        {
            figurePen = pen;
            if (pen != null){
                PenColor = pen.Color;
                PenWidth = pen.Width;
            }
                   
            
        }
        public abstract void Drawing(Graphics graphics);   
    }
}