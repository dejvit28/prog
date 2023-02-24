using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje__abstraktni_razredi__vmesniki_24._02._2023_
{
    internal class motocikli : Vozilo, iDrivable
    {
        int štKoles;
        int največjoHitrost;

        public int ŠtKoles { get => štKoles; set => štKoles = value; }
        public int NajvečjoHitrost { get => največjoHitrost; set => največjoHitrost = value; }

        public motocikli(int štKoles1, int največjoHitrost1)
        {
            štKoles = štKoles1;
            največjoHitrost = največjoHitrost1;
        }

        public motocikli()
        {
        }

        public double Drive(int štKilometrov)
        {
            return štKilometrov * 5 / 100.0;
        }
    }
}
