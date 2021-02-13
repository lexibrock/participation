using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WPF_Classes_2
{
    public class Toy
    {
        public string ManufacturerName { get; set; }
        public string ToyName { get; set; }
        public double ToyPrice { get; set; }

        //private string Aisle { get; set; }

        public Toy()
        {
            ManufacturerName = string.Empty;
            ToyName = string.Empty;
            ToyPrice = 0;
        }
        //public string GetAisle()
        //{
            //return ($"{ManufacturerName.Substring(0, 1)} - {ToyPrice}");

        //}

    }
}