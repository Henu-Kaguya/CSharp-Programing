using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace DrawShapesExample
{
    public class DrawRectangle : DrawObject
    {
        public DrawRectangle(Image image) : base(image)
        {
        }
        public Rect Rect { get; set; }
        public override void Draw()
        {
            RectangleGeometry geometry = new RectangleGeometry(Rect);
            gd.Geometry = geometry;
            Image.Source = new DrawingImage(gd);
        }
    }
}
