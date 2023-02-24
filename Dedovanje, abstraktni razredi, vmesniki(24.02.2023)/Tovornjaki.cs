using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje__abstraktni_razredi__vmesniki_24._02._2023_
{
    internal class Tovornjaki : Vozilo, iDrivable
    {
        int nosilnost;
        int vlečnozmogljivost;

        public int Nosilnost { get => nosilnost; set => nosilnost = value; }
        public int Vlečnozmogljivost { get => vlečnozmogljivost; set => vlečnozmogljivost = value; }

      

        public Tovornjaki(int noslivost1, int vlečnozmogljivost1)
        {
            nosilnost = noslivost1;
            vlečnozmogljivost = vlečnozmogljivost1;
        }

        public Tovornjaki()
        {
        }

        public double Drive(int štKilometrov)
        {
            return štKilometrov * 12 / 100.0;
        }
    }
}
