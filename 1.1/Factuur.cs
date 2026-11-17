using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1
{
    internal class Factuur
    {
        //fields
        List<FactuurLijn> factuurLijnen = new List<FactuurLijn>();

        //properties
        public List<FactuurLijn> FactuurLijnen
        {
            get { return factuurLijnen; }
        }

        public int FactuurID { get; set; }
        public int KlantID { get; set; }
        public string KlantNaam { get; set; }

        //constructors
        public Factuur()
        {

        }

        public Factuur(int factuurID, int klantID, string klantNaam)
        {
            FactuurID = factuurID;
            KlantID = klantID;
            KlantNaam = klantNaam;
        }

        //methodes
        public override string ToString()
        {
            return KlantNaam;
        }

        public double BerekenFactuurTotaal()
        {
            double resultaat = 0;
            return resultaat;
        }

        public void VoegFactuurLijnToe(int aantal, string productNaam, double prijs)
        {
            
        }



    }
}
