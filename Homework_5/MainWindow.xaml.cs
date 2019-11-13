using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace Homework_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ResourceDictionary Temp;
        public MainWindow()
        {
            Temp = new ResourceDictionary();
            InitializeComponent();
        }

        private void Style_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Style.SelectedIndex)
            {
                //case 0:

                //    break;
                case 1:
                    Temp.Source = new Uri(Environment.CurrentDirectory + "\\11.xaml");
                    this.Resources = Temp;
                    break;
                case 2:
                    Temp.Source = new Uri(Environment.CurrentDirectory + "\\13.xaml");
                    this.Resources = Temp;
                    break;
                case 3:
                    Temp.Source = new Uri(Environment.CurrentDirectory + "\\14.xaml");
                    this.Resources = Temp;
                    break;


            }
        }
    }
}
