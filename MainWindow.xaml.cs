using System.Windows;
using System.Windows.Controls;
using ShapesLab_Final.Creators;
using ShapesLab_Final.Figures;

namespace ShapesLab_Final
{
    public partial class MainWindow : Window
    {
        private CircleCreator _circleCreator;
        private SquareCreator _squareCreator;
        private TriangleCreator _triangleCreator;

        public MainWindow()
        {
            InitializeComponent();
            ColorComboBox.SelectedIndex = 0; 
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ComboBoxItem)ColorComboBox.SelectedItem;
            if (selectedItem == null) return;

            switch (selectedItem.Content.ToString())
            {
                case "Красный":
                    _circleCreator = new RedCircleCreator();
                    _squareCreator = new RedSquareCreator();
                    _triangleCreator = new RedTriangleCreator();
                    break;
                case "Синий":
                    _circleCreator = new BlueCircleCreator();
                    _squareCreator = new BlueSquareCreator();
                    _triangleCreator = new BlueTriangleCreator();
                    break;
                case "Зелёный":
                    _circleCreator = new GreenCircleCreator();
                    _squareCreator = new GreenSquareCreator();
                    _triangleCreator = new GreenTriangleCreator();
                    break;
                default:
                    return;
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (_circleCreator == null)
            {
                MessageBox.Show("Сначала выберите цвет!");
                return;
            }

            ShapesPanel.Children.Clear();

            var circle = _circleCreator.CreateCircle();
            var square = _squareCreator.CreateSquare();
            var triangle = _triangleCreator.CreateTriangle();

            ShapesPanel.Children.Add(circle.CreateUIElement(80));
            ShapesPanel.Children.Add(square.CreateUIElement(80));
            ShapesPanel.Children.Add(triangle.CreateUIElement(80));
        }
    }
}