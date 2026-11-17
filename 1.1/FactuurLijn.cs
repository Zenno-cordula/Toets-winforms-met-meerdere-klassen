using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1
{
    internal class FactuurLijn
    {
        //properties
        public int Aantal { get; set; }
        public double Prijs { get; set; }
        public string ProductNaam { get; set; }

        //constructors
        public FactuurLijn()
        {

        }

        public FactuurLijn(int aantal, double prijs, string productNaam)
        {
            Aantal = aantal;
            Prijs = prijs;
            ProductNaam = productNaam;
        }

        //override methode
        public override string ToString()
        {
            return ProductNaam;
        }

    }
}
