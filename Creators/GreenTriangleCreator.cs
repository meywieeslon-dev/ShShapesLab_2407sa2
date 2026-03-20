using System.Windows.Media;
using ShapesLab_Final.Figures;

namespace ShapesLab_Final.Creators
{
    public class GreenTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Green };
    }
}