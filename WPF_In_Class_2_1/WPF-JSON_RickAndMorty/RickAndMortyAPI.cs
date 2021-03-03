using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_JSON_RickAndMorty
{
    //ON EXAM
    //ON EXAM
    //ON EXAM


    public class RickAndMortyAPI
    {
        //https://rickandmortyapi.com/api/character
        public Info info { get; set; }
        public List<Character> results {get;set;}
    }

    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string image { get; set; }

        //public Location location {get; set;}

        public override string ToString()
        {
            return $"{name} ({id})";
        }

    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public int next { get; set; }
    }
}
