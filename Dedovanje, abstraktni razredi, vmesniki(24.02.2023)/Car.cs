using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje__abstraktni_razredi__vmesniki_24._02._2023_
{
    internal class Motocikli :Vozilo,iDrivable
    {
        int štVrat;
        int velikostPrtljažnika;

        public Motocikli()
        {
        }

        public Motocikli(int Vrata, int prostor)
        {
            štVrat = Vrata;
            velikostPrtljažnika = prostor;
        }

        public int ŠtVrat { get => štVrat; set => štVrat = value; }
        public int ProstorPrtljažnika { get => velikostPrtljažnika; set => velikostPrtljažnika = value; }

        public double Drive(int štKilometrov)
        {//troši 6 na 100
            return štKilometrov * 6 / 100.0;
        }
    }
}
