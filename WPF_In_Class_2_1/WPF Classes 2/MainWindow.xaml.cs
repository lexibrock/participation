using System.Windows;
using System.Windows.Controls;

namespace WPF_Classes_2
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

        private void bttnAddToy_Click(object sender, RoutedEventArgs e)
        {
            string manufacturerName, toyName;
            double toyPrice = 0;

            manufacturerName = txtbxManufacturerName.Text;
            if (string.IsNullOrEmpty(manufacturerName))
            {
                MessageBox.Show("You must enter the manufacturer name!");
            }

            toyName = txtbxToyName.Text;
            if (string.IsNullOrEmpty(toyName))
            {
                MessageBox.Show("You must enter the toy name!");
            }

            txtbxToyPrice.Text = toyPrice.ToString();
            if (double.IsNaN(toyPrice))
            {
                MessageBox.Show("You must enter a valid toy price!");
            }


            Toy myToy = new Toy()
            {
                ManufacturerName = manufacturerName,
                ToyName = toyName,
                ToyPrice = toyPrice,
            };

            lstbxToys.Items.Add(myToy);
            
            
        }

        private void lstbxToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show($"{txtbxManufacturerName.Text} - {txtbxToyName.Text}");

        }

        private void lstbxToysSelected(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"{txtbxManufacturerName.Text.Substring(0, 1)} - {txtbxToyName.Text.Trim()}");

        }

    }
}
