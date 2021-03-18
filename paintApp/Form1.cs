using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void line_Click(object sender, EventArgs e)
        {
            Graphics g = paper.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 100, 100, 200, 100);
        }

        private void polyline_Click(object sender, EventArgs e)
        {
            Graphics g = paper.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 2);
            Point[] points =
            {
                new Point(10,  10),
                new Point(10, 100),
                new Point(200,  50),
                new Point(250, 300)
            };
            g.DrawLines(pen, points);
        }

        private void circle_Click(object sender, EventArgs e)
        {
            Graphics g = paper.CreateGraphics();
            g.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, 100, 100, 100, 100);
        }

        private void polygon_Click(object sender, EventArgs e)
        {
            Graphics g = paper.CreateGraphics();
            g.Clear(Color.White);
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point[] curvePoints = { point1, point2, point3, point4, point5 };
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillPolygon(brush, curvePoints);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            Graphics g = paper.CreateGraphics();
            g.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, 100, 100, 200, 100); 
        }
    }
}