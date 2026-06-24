using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace DrawShapesExample.Ch05
{
    public partial class E06DrawDemo : Page
    {
        public E06DrawDemo()
        {
            InitializeComponent();
            InitDraws();
        }
        private void InitDraws()
        {
            btnLine.Click += delegate
            {
                double w = image1.Width, h = image1.Height, a = 15.0;
                var line = new DrawLine(image1)
                {
                    StartPoint = new Point(a, a),
                    EndPoint = new Point(w - a, h - a),
                    StrokeBrush = Brushes.Blue,
                    LineWidth = 2.0
                };
                line.Draw();
            };
            btnRectangle.Click += delegate
            {
                double w = image2.Width, h = image2.Height;
                var rectangle = new DrawRectangle(image2)
                {
                    Rect = new Rect(0, 0, w, h)
                };
                rectangle.Draw();
            };
            btnEllipse.Click += delegate
            {
                double halfX = image3.Width / 2, halfY = image3.Height / 2;
                var ellipse = new DrawEllipse(image3)
                {
                    CenterPoint = new Point(halfX, halfY),
                    RadiusH = halfX,
                    RadiusV = halfY
                };
                ellipse.Draw();
            };
            btnCircle.Click += delegate
            {
                double radius = Math.Min(image4.Width / 2, image4.Height / 2);
                var circle = new DrawEllipse(image4)
                {
                    CenterPoint = new Point(radius, radius),
                    RadiusH = radius,
                    RadiusV = radius
                };
                circle.Draw();
            };
            btnArrowLine.Click += delegate
            {
                var a = 15.0;
                var v = new DrawArrowLine(image5)
                {
                    StartPoint = new Point(a, a),
                    EndPoint = new Point(image5.Width - a, image5.Height - a),
                    StrokeBrush = Brushes.Blue,
                    LineWidth = 30.0
                };
                v.Draw();
            };
            btnSin.Click += delegate
            {
                var sin = new DrawSin(image6)
                {
                    FillBrush=Brushes.Blue,
                    StrokeBrush = Brushes.Red
                };
                sin.Draw();
            };
        }
    }
}
