using System;
using System.Collections.Generic;

namespace myApp
{
    public class City
    {
        private string _cityName { get; set; }

        private string _mayor { get; set; }

        private DateTime _established { get; set; }

        public List<Building> Buildings { get; set; } = new List<Building>();

        public City(string name)
        {
            _cityName = name;
            _established = DateTime.Now;
        }

        public void Elect(string name)
        {
            _mayor = name;
        }
        public void Print()
        {
            Console.WriteLine($@"
            City: {_cityName}
            Established: {_established}
            Mayor: {_mayor}
            
            ---------------------------
            ");


            foreach (Building Building in Buildings)
            {
                Building.Print();
            }
        }

    }
}

