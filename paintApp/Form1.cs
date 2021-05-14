﻿using System;
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
        
        private Pen pen = new Pen(Color.Black, 3f);
        private Color penColor = Color.Black;
        private float penWidth = 3f;
        private List<Point> points;
        private Paint paint;
        private Figure figure;
        private Color fillColor = new Color();
        private Point StartPoint = new Point();
        private Point EndPoint = new Point();
        private Image image = new Image();
        private int angles = 3;

        public Form1()
        {
            points = new List<Point>();
            InitializeComponent();
            SetSize();
        }
        
        private bool isMouse = false;

        private Bitmap map = new Bitmap(100, 100);
        Graphics graphics;

        

        private void SetSize()
        {
            //Rectangle rectangle1 = Screen.PrimaryScreen.Bounds;
            //map = new Bitmap(rectangle1.Width, rectangle1.Height);
            graphics = Graphics.FromImage(map);
            Pen pen = new Pen(penColor, penWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorBtn1.ShowDialog() == DialogResult.OK)  
               {  
                  colorBack1.BackColor = colorBtn1.Color;
                  penColor = ((Button) sender).BackColor;
                  pen = new Pen(penColor, penWidth);
               }
        }

        private void colorBack2_Click(object sender, EventArgs e)
        {
            if(colorBtn2.ShowDialog() == DialogResult.OK)  
            {  
                colorBack2.BackColor = colorBtn2.Color;
                fillColor = ((Button) sender).BackColor;
            }
        }

        private void paper_MouseDown(object sender, MouseEventArgs e)
        {
            if (paint != null)
            {
                if (e.Button == MouseButtons.Left)
                {


                    figure = paint.getFigure(pen, fillColor, angles);
                    StartPoint.X = e.X;
                    StartPoint.Y = e.Y;
                    points.Add(StartPoint);
                }
                else
                {
                    if (paint.poly)
                    {
                        //StartPoint.;
                        //EndPoint = new Point();
                        points.Clear();
                        //paint = null;

                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            paint = new LinePaint();
        }

        private void paper_MouseUp(object sender, MouseEventArgs e)
        {
            if (paint != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouse = false;
                    EndPoint.X = e.X;
                    EndPoint.Y = e.Y;

                    points.Add(EndPoint);
                    figure.points = points.ToArray();
                    image.addFigure(figure);
                    if (!paint.poly)
                    {
                        points.Clear();
                    }

                    paper.Refresh();
                }
            }
        }

        private void paper_Paint(object sender, PaintEventArgs e) 
        {
            image.drawAll(e.Graphics);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        
        {
            if (textBox2.Text == "")
            {
                penWidth = 1;
            }
            else
            {
                penWidth = System.Convert.ToInt32(textBox2.Text);

                if (penWidth > 80)
                {
                    penWidth = 80;
                    textBox2.Text = "80";
                }
            }

            pen = new Pen(penColor, penWidth);
        }

        private void circleImg_Click(object sender, EventArgs e)
        {
            paint = new CirclePaint();

        }

        private void squareImg_Click(object sender, EventArgs e)
        {
            paint = new RectanglePaint();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            paint = new PolylinePaint();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                angles = 3;
            }
            else
            {
                angles = System.Convert.ToInt32(textBox1.Text);

                if (angles > 10)
                {
                    angles = 10;
                    textBox1.Text = "10";
                }
                if (angles < 3)
                {
                    angles = 3;
                    textBox1.Text = "3";
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void polygon_Click(object sender, EventArgs e)
        {
            paint = new PolygonPaint();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
    }
}