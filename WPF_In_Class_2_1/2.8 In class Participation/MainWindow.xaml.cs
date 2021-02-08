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

namespace _2._8_In_class_Participation
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name, breed, url;

            name = txtbxPetName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("You must enter a name!");
                return;
            }


            breed = txtbxPetBreed.Text;
            url = txtbxURL.Text;

            Pet myPet = new Pet()
            {
                Breed = breed,
                Name = name,
                PicURL = url
            };

    
            lstPets.Items.Add(myPet);

        }

        private void lstPets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstPets.SelectedItem is null)
            {
                Pet selectedPet = (Pet)lstPets.SelectedItem;

                        //URI - a more sophisticated URL

                Uri locationofImage = new Uri(selectedPet.PicURL);
                BitmapImage picFromInternet = new BitmapImage(locationofImage);

                imgPet.Source = picFromInternet;

                        //imgPet.Source = new BitmapImage(new Uri(selectedPet.PicURL));
            }
        }
    }
}
