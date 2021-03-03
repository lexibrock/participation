using System;
using System.Collections.Generic;
using System.Text;

namespace P_Pokemon
{
    public class AllPokemonAPI
    {
        public List<ResultObject> Results { get; set; }

    }

    public class ResultObject
    {
        public string Name { get; set; }
        public string URL { get; set; }

        public override string ToString()
        {
            return Name[0].ToString() + Name.Substring(1, Name.Length - 1);
        }
    }

}
