using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace DrawShapesExample
{
    public class DrawSin : DrawLine
    {
        public DrawSin(Image image) : base(image)
        {
        }
        public override void Draw()
        {
            double w = Image.Width, h = Image.Height;
            int a = 60;
            PointCollection points = new PointCollection();
            PathGeometry pathGeometry = new PathGeometry();
            //横坐标
            pathGeometry.AddGeometry(Geometry.Parse(
                string.Format("M-{0},0  L{0},0  M{0},0  {1},5  M{0},0  L{1},-5",
                w + 5, w - 5)));
            //纵坐标
            double x = 100;
            pathGeometry.AddGeometry(Geometry.Parse(
                string.Format("M0,-{0}  L0,{1}  M0,-{1}  L-5,-{2}  M0,-{1}  L5,-{2}",
                x, x + 5, x - 5)));
            //正弦曲线
            for (int i = -360; i <= 360; i++)
            {
                Point p = new Point(i, a * Math.Sin(i * Math.PI / 180.0));
                points.Add(p);
            }
            for (int i = 0; i < points.Count - 1; i++)
            {
                LineGeometry line = new LineGeometry
                {
                    StartPoint = points[i],
                    EndPoint = points[i + 1]
                };
                pathGeometry.AddGeometry(line);
            }
            gd.Geometry = pathGeometry;
            Image.Source = new DrawingImage(gd);
        }
    }
}
