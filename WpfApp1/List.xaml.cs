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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List()
        {
            InitializeComponent();
        }

        private void btnColor(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
           // this.Close();
        }

        private void btnPs(object sender, RoutedEventArgs e)
        {
            PlayStation5_Demo demo = new PlayStation5_Demo();
            demo.Show();
            //this.Close();
        }

        private void btnStart(object sender, RoutedEventArgs e)
        {
            NotePad notepad = new NotePad();
            notepad.Show();
          //  this.Close();
        }
    }
}
