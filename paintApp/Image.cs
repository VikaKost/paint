using System.Collections.Generic;
using System.Drawing;

namespace paintApp
{
    public class Image
    {
        private List<Figure> figures;

        public Image()
        {
            figures = new List<Figure>();
        }

        public void addFigure(Figure figure)
        {
            figures.Add(figure);
        }

        public void drawAll(Graphics graphics)
        {
            foreach (var figure in figures)
            {
                figure.Drawing(graphics);
            }
        }
    }
}