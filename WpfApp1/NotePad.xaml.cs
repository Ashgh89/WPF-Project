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
using System.IO;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NotePad.xaml
    /// </summary>
    public partial class NotePad : Window
    {

        string myWord;
        

        public NotePad()
        {
            InitializeComponent();
        }


        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            myWord = tbText.SelectedText;
        }
            

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            tbText.SelectedText = myWord.Replace(Environment.NewLine, " ");
        }
            

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            tbText.SelectedText = "";
        }
            


        private void New_Click(object sender, RoutedEventArgs e)
        {
            tbText.Text = "";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "NewFile";
            save.DefaultExt = ".txt";
            save.Filter = "Text files |*.txt|PNG Files|*.png";
            if (save.ShowDialog() == true)
                File.WriteAllText(save.FileName, tbText.Text);
        }

       

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string _fileName = open.FileName;
            tbText.Text = File.ReadAllText(_fileName);

        }

        private void myExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("'Exit' Please press OK!");
            Environment.Exit(0);
        }
    }
}



       
