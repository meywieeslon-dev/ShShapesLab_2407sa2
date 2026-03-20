using ShapesLab_Final.Factories;  
using ShapesLab_Final.Figures;
using System.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls;

namespace ShapesLab_Final
{
    public partial class MainWindow : Window
    {
        private IFigureFactory _currentFactory;  // ← Теперь ОДНА фабрика!

        public MainWindow()
        {
            InitializeComponent();
            ColorComboBox.SelectedIndex = 0;
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ComboBoxItem)ColorComboBox.SelectedItem;
            if (selectedItem == null) return;

            _currentFactory = selectedItem.Content.ToString() switch
            {
                "Красный" => new RedFactory(),
                "Синий" => new BlueFactory(),
                "Зелёный" => new GreenFactory(),
                _ => new RedFactory()
            };
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentFactory == null)
            {
                MessageBox.Show("Сначала выберите цвет!");
                return;
            }

            ShapesPanel.Children.Clear();

           
            var circle = _currentFactory.CreateCircle();
            var square = _currentFactory.CreateSquare();
            var triangle = _currentFactory.CreateTriangle();

       
            ShapesPanel.Children.Add(circle.CreateUIElement(80));
            ShapesPanel.Children.Add(square.CreateUIElement(80));
            ShapesPanel.Children.Add(triangle.CreateUIElement(80));
        }
    }
}