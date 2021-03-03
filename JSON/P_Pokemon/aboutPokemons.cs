using System;
using System.Collections.Generic;
using System.Text;

namespace P_Pokemon
{
    public class AboutPokemons
    {
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Sprites { get; set; }

        public AboutPokemons()
        {
            Height = string.Empty;
            Weight = string.Empty;
            Sprites = string.Empty;
        }

        public override string ToString()
        {
          return $"Height: {Height} Weight: {Weight}";
        }
        public class Sprite
        {
            public string Front_default { get; set; }
            public string Back_default { get; set; }
        }
    }
}
