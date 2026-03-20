using ShapesLab_Final.Figures;

namespace ShapesLab_Final.Factories  
{
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }
}
