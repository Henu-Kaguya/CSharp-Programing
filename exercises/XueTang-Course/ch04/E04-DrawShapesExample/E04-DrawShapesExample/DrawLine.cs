using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace DrawShapesExample
{
    public class DrawLine : DrawObject
    {
        public DrawLine(Image image) : base(image)
        {
        }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public double LineWidth
        {
            get { return pen.Thickness; }
            set { pen.Thickness = value; }
        }
        public override void Draw()
        {
            gd.Geometry = new LineGeometry
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint
            };
            Image.Source = new DrawingImage(gd);
        }
    }
}
