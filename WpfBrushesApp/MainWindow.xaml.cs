using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfBrushesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //btnBrush.Background = new SolidColorBrush(Colors.Aqua) { Opacity = 0.9 };
            //btnBrush.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));

            //LinearGradientBrush lnrGrBrush = new LinearGradientBrush() { StartPoint = new Point(0,0), EndPoint = new Point(1,1)  };
            //lnrGrBrush.GradientStops.Add(new GradientStop(Colors.Aqua, 0.0));
            //lnrGrBrush.GradientStops.Add(new GradientStop(Color.FromRgb(255, 255, 0), 1.0));
            //btnBrush.Background = lnrGrBrush;
        }
    }
}
