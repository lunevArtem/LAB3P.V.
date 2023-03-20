using LAB3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{

    class Polygon : Figure
    {
        public double Radius { get; set; }
        public int Vertices { get; set; }
        public Point Positions { get; set; } = new Point(1000, 1000);

        public Polygon(int vertices)
        {
            Vertices = vertices;
        }

        public override double GetArea()
        {
            // Проверка на корректность входных параметров
            if (Vertices < 3 || Radius <= 0)
            {
                throw new ArgumentException("Количество вершин должно быть больше 2, а радиус должен быть положительным числом.");
            }

            double sideLength = 2 * Radius * Math.Sin(Math.PI / Vertices);
            double apothemLength = Radius * Math.Cos(Math.PI / Vertices);
            double area = 0.5 * Vertices * sideLength * apothemLength;

            return (int)Math.Round(area);
        }

        public override Point GetCenter()
        {
            return Position;
        }

        public override void Draw(Graphics gr)
        {
            PointF[] points = new PointF[Vertices];

            double angle = 2 * Math.PI / Vertices;

            for (int i = 0;i < Vertices; i++)
            {
                double x = Position.X + Radius * Math.Cos(i * angle);
                double y = Position.Y + Radius * Math.Sin(i * angle);
                points[i] = new PointF((float)x, (float)y);
            }

            //Pen pen = new Pen(Color.Black, 2);
            gr.FillPolygon(new SolidBrush(Color), points);
            //gr.DrawPolygon(pen, vertices);
            RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(50, 20));
            gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
            gr.DrawRectangle(new Pen(Color.Black, 1), Rectangle.Round(layoutRectangle));
        }
    }
}