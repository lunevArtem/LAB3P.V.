using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Parallelogram : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int Base { get; set; }
        private int Height { get; set; }

        public Parallelogram(int x, int y, int baseLength, int height)
        {
            X = x;
            Y = y;
            this.Base = baseLength;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Base * Height;
        }

        public override Point GetCenter()
        {
            int x = X;
            int y = Y + Height / 2;
            return new Point(x, y);
        }

        public override void Draw(Graphics gr)
        {
            Point[] points =
            {
                new Point(X, Y),
                new Point(X + Base, Y),
                new Point(X + Base - Height, Y + Height),
                new Point(X - Height, Y + Height)
            };
            gr.FillPolygon(new SolidBrush(Color), points);
            RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(40, 20));

            var size = gr.MeasureString(GetArea().ToString() + "", new Font("Arial", 12));
            gr.FillRectangle(Brushes.White, new RectangleF(GetCenter(), size));
            gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
            gr.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(GetCenter(), Size.Ceiling(size)));
        }
    }
}
