using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesLab_Final.Figures
{
    public abstract class Figure
    {
        public Color Color { get; set; }

       
        public abstract UIElement CreateUIElement(double size = 50);
    }
}