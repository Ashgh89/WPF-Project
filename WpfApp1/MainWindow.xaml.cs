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
using Microsoft.Win32;
using System.IO;
using System.Windows.Media.Imaging;





namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }







        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red = (byte)sliderRed.Value;
            byte green = (byte)sliderGreen.Value;
            byte blue = (byte)sliderBlue.Value;

            Color color = Color.FromRgb(red, green, blue);
            rectangle.Fill = new SolidColorBrush(color);

        }

        private void OnExitMenuClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("'Exit' Please press OK!");
            Environment.Exit(0);
        }

        private void btnSaveFileClicked(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
