using System.Windows.Media;
using ShapesLab_Final.Figures;

namespace ShapesLab_Final.Creators
{
    public class GreenSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Green };
    }
}