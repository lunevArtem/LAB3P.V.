using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class RegularDecagon : Figure
    {
        private int x, y;
        public int sideLength { get; set; }

        public RegularDecagon(int x, int y, int sideLength)
        {
            this.x = x;
            this.y = y;
            this.sideLength = sideLength;
        }

        public override double GetArea()
        {
            return 2.5 * sideLength * sideLength * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }

        public override Point GetCenter()
        {
            return new Point(x, y);
        }

        public override void Draw(Graphics gr)
        {
            PointF[] points = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                double angle_deg = i * 36;
                double angle_rad = Math.PI / 180 * angle_deg;
                points[i] = new PointF((float)(x + sideLength * Math.Cos(angle_rad)), (float)(y + sideLength * Math.Sin(angle_rad)));
            }
            gr.FillPolygon(new SolidBrush(Color), points);
            RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(145, 20));
            gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
            gr.DrawRectangle(new Pen(Color.Black, 1), Rectangle.Round(layoutRectangle));
        }
    }
}
