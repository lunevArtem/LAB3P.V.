using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB3
{
    public partial class Form1 : Form
    {
        //Square
        public static Figure[] figures =
        {
            new Rectangles()
            {
            Name = "Square",
            Color = System.Drawing.Color.DarkRed,
            Position = new System.Drawing.Point(30, 30),
            Width = 35,
            Height = 35
            },

            new Rectangles()
            {
            Name = "Square #2",
            Color = System.Drawing.Color.Gold,
            Position = new System.Drawing.Point(120, 30),
            Width = 60,
            Height = 95
            },

            new Rectangles()
            {
            Name = "Square",
            Color = System.Drawing.Color.YellowGreen,
            Position = new System.Drawing.Point(220, 30),
            Width = 95,
            Height = 47
            },
        };



        //Circle
        public static Figure d = new Circle()
        {
            Name = "Circle",
            Color = System.Drawing.Color.Blue,
            Position = new System.Drawing.Point(30, 200),
            Radius = 55
        };

        //Poligon
        public static Figure polygon = new Polygon(5)
        {
            Name = "Polygon",
            Color = System.Drawing.Color.Red,
            Radius = 65,
            Position = new Point(180, 220)
        };
        public static Figure regulardecagon = new RegularDecagon(70,360,122)
        {
            Name = "RegularDecagon",
            Color = System.Drawing.Color.OrangeRed,
            sideLength = 60
           

        };

        //Trapezoid
        public static Figure trapezoid = new Trapezoid(300, 340, 70, 80, 145)
        {
            Name = "Trapezoid",
            Color = System.Drawing.Color.Aqua
        };

        //Rhombus
        public static Figure rhombus = new Rhombus(70, 570, 85, 126)
        {
            Name = "Rhombus",
            Color = System.Drawing.Color.PaleGreen
        };

        //Triangle
        public static Figure triangle = new Triangle(150, 550, 50, 100)
        {
            Name = "Triangle",
            Color = System.Drawing.Color.Yellow
        };

        //Parallelogram
        public static Figure parallelogram = new Parallelogram(350, 540, 80, 70)
        {
            Name = "Parallelogram",
            Color = System.Drawing.Color.BlueViolet
            
        };

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //Square
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }

            //Circle
            d.Draw(e.Graphics);

            //Polygon

            polygon.Draw(e.Graphics);

            //Trapezoid
            trapezoid.Draw(e.Graphics);


            //Rhombus
            rhombus.Draw(e.Graphics);

            //Triangle
            triangle.Draw(e.Graphics);

            //Parallelogram
            parallelogram.Draw(e.Graphics);
            //RegularDecagon
            regulardecagon.Draw(e.Graphics);


            //e.Graphics.DrawRectangle(Pens.f.Color, new Rectangle(f.Position, 30, f.Width, Height));

            //e.Graphics.FillEllipse(Brushes.Navy, new Rectangle(50, 50, 100, 200));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}