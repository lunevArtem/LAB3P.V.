using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Triangle : Figure
    {
        public Triangle(int x, int y, int height, int baseWidth) 
        {
            X = x;
            Y = y;
            this.Height = height;
            this.BaseWidth = baseWidth;
        }


        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int BaseWidth { get; set; }

        public override double GetArea()
        {
            return 0.5 * BaseWidth * Height;
        }

        public override Point GetCenter()
        {
            int x = X + BaseWidth / 2;
            int y = Y + Height / 3;
            return new Point(x, y);
        }

        public override void Draw(Graphics gr)
        {
            using (Pen pen = new Pen(Color.Black))
            {
                // Вычисление координат вершин треугольника
                int x1 = X;
                int y1 = Y + Height;
                int x2 = X + BaseWidth / 2;
                int y2 = Y;
                int x3 = X + BaseWidth;
                int y3 = Y + Height;

                Point[] points = { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
                gr.FillPolygon(new SolidBrush(Color), points);
                RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(40, 20));
                gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
                gr.DrawRectangle(new Pen(Color.Black, 1), Rectangle.Round(layoutRectangle));
            }
        }
    }
}
