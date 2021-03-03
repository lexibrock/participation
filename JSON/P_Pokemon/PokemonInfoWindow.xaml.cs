using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace P_Pokemon
{
    /// <summary>
    /// Interaction logic for PokemonInfoWindow.xaml
    /// </summary>
    public partial class PokemonInfoWindow : Window
    {
        public AboutPokemons poke;
        private bool showFront = false;
        public ResultObject sp { get; set; }

        public PokemonInfoWindow()
        {
            InitializeComponent();
        }

        public void Setup()//(AllResults selectedPokemon)
        {
            var selectedPokemon = sp;
            using (var client = new HttpClient())
            {
                string jsonResults = client.GetStringAsync(selectedPokemon.url).Result;

                poke = JsonConvert.DeserializeObject<AboutPokemons>(jsonResults);
            }


            showFront = false;
            BTNFlip.IsEnabled = true;
            SetImageByURL(poke.Sprites.Front_default);
            LBLPokemonName.Content = selectedPokemon.Name.ToUpper();
            this.Title = $"{selectedPokemon.Name} Info";
        }

        private void SetImageByURL(string urlToImage)
        {
            IMGPokemon.Source = new BitmapImage(new Uri(urlToImage));
        }

        private void BTNFlip_Click(object sender, RoutedEventArgs e)
        {
            if (showFront)
            {
                SetImageByURL(poke.Sprites.Front_default);

            }
            else
            {
                SetImageByURL(poke.Sprites.Back_default);
            }
            showFront = !showFront;
        }
    }
}