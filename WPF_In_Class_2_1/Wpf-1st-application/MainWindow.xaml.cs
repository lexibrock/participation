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
        }
        private void MouseEnter_ENTER(object sender, MouseEventArgs e)
        {
            MyGrid.Background = Brushes.Gray;   
        }

        private void MouseLeave_ENTER(object sender, MouseEventArgs e)
        {
            MyGrid.Background = Brushes.Transparent;
        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {
            string name = Text_Box_Enter_Name.Text;
            
            // birthday = Convert.ToDateTime(DatePicker_Birthday);
            string age = Convert.ToDateTime(birthday);
            // Convert.ToString(birthday);


            //DateTime birthday = DatePicker_Birthday;
            //var DatePicker_Birthday = 
            // (DatePicker_Birthday);
            //DateTime birthday = DatePicker_Birthday.DateTime;
            //DateTime today = DateTime.Today);
            //DateTime age = DateTime.Today - DatePicker_Birthday;
            
            
            MessageBox.Show(name, age.ToString());
        }

        private void DatePicker_Birthday(object sender, RoutedEventArgs e)
        {
            
                string birthday = new DateTime(DatePicker_Birthday);
                
        }
    }    
}
