using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Rectangles : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Width / 2), (int)(Position.Y + Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color, 5), Position.X, Position.Y, (int)Width, (int)Height);

            RectangleF layoutRectangle = new RectangleF(GetCenter(), new SizeF(40, 20));
            gr.DrawString(GetArea().ToString(), new Font("Arial", 12), Brushes.Black, GetCenter());
            gr.DrawRectangle(new Pen(Color.Black, 1), Rectangle.Round(layoutRectangle));
        }
    }
}
