using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace DrawShapesExample
{
    public class DrawEllipse : DrawObject
    {
        public DrawEllipse(Image image) : base(image)
        {
        }
        public Point CenterPoint { get; set; }
        public double RadiusH { get; set; }
        public double RadiusV { get; set; }
        public override void Draw()
        {
            gd.Geometry = new EllipseGeometry
            {
                Center = CenterPoint,
                RadiusX = RadiusH,
                RadiusY = RadiusV
            };
            Image.Source = new DrawingImage(gd);
        }
    }
}
