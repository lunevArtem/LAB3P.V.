using LAB3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public class Trapezoid : Figure
    {
        public Trapezoid(int x, int y, int height, int top, int bottom) 
        {
            X = x;
            Y = y;
            this.Height = height;
            this.Top = top;
            this.Bottom = bottom;
        }

        public int Height { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public override double GetArea()
        {
            return (Top + Bottom) / 2.0 * Height;
        }

        public override Point GetCenter()
        {
            int x = X;
            int y = Y + Height / 2;
            return new Point(x, y);
        }

        public override void Draw(Graphics gr)
        {
            using (Pen pen = new Pen(Color.Black))
            {
                // Вычисление координат вершин трапеции
                int x1 = X - Top / 2;
                int y1 = Y;
                int x2 = X + Top / 2;
                int y2 = Y;
                int x3 = X + Bottom / 2;
                int y3 = Y + Height;
                int x4 = X - Bottom / 2;
                int y4 = Y + Height;

                Point[] points = { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4) };
                gr.FillPolygon(new SolidBrush(Color), points);
                RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(40, 20));
                gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
                gr.DrawRectangle(new Pen(Color.Black, 1), Rectangle.Round(layoutRectangle));
            }
        }
    }
}
