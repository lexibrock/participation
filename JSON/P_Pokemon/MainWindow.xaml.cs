using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;
using System.Net.Http;
using Newtonsoft.Json;


namespace P_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AboutPokemons poke;

        private bool showFront = true;

        public MainWindow()
        {
            InitializeComponent();

            AllPokemonAPI pokemonApiResults;

            string apiURL = @"https://pokeapi.co/api/v2/pokemon/?offset=0&limit=1200";

            using (var client = new HttpClient())
            {
                string jsonResults = client.GetStringAsync(apiURL).Result;


                pokemonApiResults = JsonConvert.DeserializeObject<AllPokemonAPI>(jsonResults);

            }

            // do more stuff
            // e.g. add results to a listbox/combobox
            foreach (var item in pokemonApiResults.Results)
            {
                LSTPokemon.Items.Add(item);
            }

        }

        private void LSTPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPokemon = (ResultObject)LSTPokemon.SelectedItem;

            PokemonInfoWindow infoWindow = new PokemonInfoWindow();

            infoWindow.sp = selectedPokemon;
            //infoWindow.Setup(selectedPokemon);
            infoWindow.Setup();
            //infoWindow.Show();
            infoWindow.ShowDialog();

            using (var client = new HttpClient())
            {
                string jsonResults = client.GetStringAsync(selectedPokemon.URL).Result;

                poke = JsonConvert.DeserializeObject<AboutPokemons>(jsonResults);
            }



            SetImageByURL(AboutPokemons.Sprite.Front_default);
            showFront = false;
            BTNFlip.IsEnabled = true;
        }

        private void SetImageByURL(string urlToImage)
        {
            IMGPokemon.Source = new BitmapImage (new Uri(urlToImage));
        }

        private void BTNFlip_Click(object sender, RoutedEventArgs e)
        {
            if (showFront)
            {
                SetImageByURL(AboutPokemons.Sprite.Front_default);

            }
            else
            {
                SetImageByURL(AboutPokemons.Sprite.Back_default);
            }
            showFront = !showFront;
        }
    }
}