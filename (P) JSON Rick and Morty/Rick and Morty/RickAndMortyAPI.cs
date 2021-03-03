using System;
using System.Collections.Generic;
using System.Text;

namespace Rick_and_Morty
{
    public class RickAndMortyAPI
    {
        public Info Info { get; set; }

        public List<Character> Results { get; set; }
    }

    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Status { get; set; }

        public string Image { get; set; }

        public override string ToString()
        {
            return $"{Name} ({ID})";
        }

    }

    public class Info
    {
        public int Count { get; set; }
        public int Pages { get; set; }

        public string Next { get; set; }

    }
}
