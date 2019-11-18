using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Car
    {
        // This is a field
        //
        //
        private string _vinNumber;
        public Car(string make, string model, int mileage)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            //Console.WriteLine("We're in the constructor");
            Random rand = new Random();
            _vinNumber = rand.Next(10000).ToString();
        }
        private string VIN {get; set;}
        public string Make {get; set;}
        public int Year {get; set;}
        public string Model {get; set;}
        public int Mileage {get; private set;}
        public string Color {get; set;}
        public string CountryOfOrigin {get; set;}
        public bool IsInspected {get; set;}

        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }
        }

        // Methods
        public void Drive( int milesDrive )
        {
            Mileage += milesDrive;
        }
    }
}