using System;
using System.Windows;

namespace Poligonos.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 71; i++)
            {
                double x = i * Math.PI;
                double y = 40 + 30 * Math.Sin(x / 10);
                polygon1.Points.Add(new Point(x, y));
            }
        }
    }
}