using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace DrawShapesExample
{
    public abstract class DrawObject
    {
        public DrawObject(Image image)
        {
            gd.Pen = pen;
            gd.Brush = new LinearGradientBrush
            {
                MappingMode = BrushMappingMode.RelativeToBoundingBox,
                StartPoint = new Point(0.5, 0),
                EndPoint = new Point(0.5, 1),
                GradientStops = new GradientStopCollection {
                    new GradientStop(Colors.Yellow,0.0),
                    new GradientStop(Colors.GreenYellow,0.5),
                    new GradientStop(Colors.Yellow,1.0)
                }
            };
            Image = image;
        }
        protected Pen pen = new Pen(Brushes.Blue, 2.0);
        protected GeometryDrawing gd = new GeometryDrawing();
        public Image Image { get; }
        public Brush FillBrush
        {
            get { return gd.Brush; }
            set { gd.Brush = value; }
        }
        public Brush StrokeBrush
        {
            get { return pen.Brush; }
            set { pen.Brush = value; }
        }
        public abstract void Draw();
    }
}
