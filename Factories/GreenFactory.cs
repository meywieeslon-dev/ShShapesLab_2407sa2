using System.Windows.Media;
using ShapesLab_Final.Figures;

namespace ShapesLab_Final.Factories
{
    public class GreenFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Green };
        public Square CreateSquare() => new Square { Color = Colors.Green };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.Green };
    }
}
