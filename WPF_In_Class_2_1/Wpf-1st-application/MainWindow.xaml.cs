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

namespace Wpf_1st_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //constructor bc same as class name
        public MainWindow()
        {
            InitializeComponent();

            label_2.Content = string.Empty;

        }

        //by clicking the event in property double click in click
        // ORRRR by double clicking the box
        private void butnpi_Click(object sender, RoutedEventArgs e)
        {
            label_2.Content = "Hello!!";
            MessageBox.Show("HI");
            MessageBox.Show("HI", "POP UP", MessageBoxButton.OKCancel, MessageBoxButton.Exclaim);
            label_2.Content = TextInput.;
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }    
}
