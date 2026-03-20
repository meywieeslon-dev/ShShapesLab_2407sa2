using System.Windows.Media;
using ShapesLab_Final.Figures;

namespace ShapesLab_Final.Creators
{
    public class GreenCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Green };
    }
}