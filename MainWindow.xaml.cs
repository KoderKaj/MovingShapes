using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovingShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ellipse ellipse = new Ellipse();
            ellipse.Height = 30; ellipse.Width = 20;
            ellipse.Fill = new SolidColorBrush(Colors.OrangeRed);
            ellipse.RenderTransform = new TranslateTransform(60, 70);
            cnvsMain.Children.Add(ellipse);
            ellipse.LayoutTransform = new RotateTransform(45);

            Ellipse circle = new Ellipse();
            circle.Width = 20; circle.Height = 20;
            circle.Stroke = Brushes.Blue;
            cnvsMain.Children.Add(circle);
        }
    }
}
