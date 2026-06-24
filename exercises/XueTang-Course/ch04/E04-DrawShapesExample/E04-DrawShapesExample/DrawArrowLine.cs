using System.Windows.Controls;
using System.Windows.Media;

namespace DrawShapesExample
{
    public class DrawArrowLine : DrawLine
    {
        public DrawArrowLine(Image image) : base(image)
        {
        }
        public override void Draw()
        {
            pen.EndLineCap = PenLineCap.Triangle;
            base.Draw();
        }
    }
}
