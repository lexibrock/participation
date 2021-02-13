using System;
using System.Collections.Generic;
using System.Text;

namespace _2._8_In_class_Participation
{
    public class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string PicURL { get; set; }

        public Pet()
        {
            Name = string.Empty;
            Breed = string.Empty;
            PicURL = string.Empty;
        }

        public override string ToString()
        {
            return $"{Name} {Breed}";
        }
    }
}
