using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB3
{
    using System.Drawing;

    class Rhombus : Figure
    {
        public int diagonal1 { get; set; }
        public int diagonal2 { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public Rhombus(int x, int y, int diagonal1, int diagonal2)
        {
            X = x;
            Y = y;
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public override double GetArea()
        {
            return diagonal1 * diagonal2 / 2;
        }

        public override Point GetCenter()
        {
            return new Point(X, Y);
        }

        public override void Draw(Graphics gr)
        {
            int halfDiagonal1 = diagonal1 / 2;
            int halfDiagonal2 = diagonal2 / 2;
            Point[] points = {
            new Point(X, Y - halfDiagonal1),
            new Point(X + halfDiagonal2, Y),
            new Point(X, Y + halfDiagonal1),
            new Point(X - halfDiagonal2, Y)
        };
            gr.FillPolygon(new SolidBrush(Color), points);
            RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(40, 20));
            gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
            gr.DrawRectangle(new Pen(Color.Black, 1), Rectangle.Round(layoutRectangle));
        }
    }

}
