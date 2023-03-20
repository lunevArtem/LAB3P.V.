using LAB3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea() 
        {
            return 3.14 * Radius * Radius ;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Radius / 2), (int)(Position.Y + Radius / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color,5), Position.X, Position.Y, (int)Radius, (int)Radius);

            RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(40, 20));
            gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
            gr.DrawRectangle(new Pen(Color.Black, 1), Rectangle.Round(layoutRectangle));
        }
    }
}
