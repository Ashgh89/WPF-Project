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
    /// Interaction logic for WpfLogin.xaml
    /// </summary>
    public partial class WpfLogin : Window
    {
        public WpfLogin()
        {
            InitializeComponent();
           
        }

        private void buttonLogin(object sender, RoutedEventArgs e)
        {
            string userName = "SAE";
            string password = "123";
           

            if (textUserName.Text.ToUpper() == userName && textPassword.Password == password)
            {
                // MainWindow main = new MainWindow();
                List list = new List();
                list.Show();
                this.Close();
            }
                
            else
                MessageBox.Show("Your Username or Password is incorrect ", "Error" , MessageBoxButton.OK, MessageBoxImage.Error);
                

            

            
        }
    }
}
