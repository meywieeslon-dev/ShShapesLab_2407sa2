using System.Windows.Media;
using ShapesLab_Final.Figures;

namespace ShapesLab_Final.Factories
{
    public class BlueFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Blue };
        public Square CreateSquare() => new Square { Color = Colors.Blue };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.Blue };
    }
}