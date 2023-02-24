using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link1_24._02._2023_
{
    internal class Valj : Krog
    {


        double višina;
        public Valj(int xK, int yK, double rK, double vV) : base(xK, yK, rK)
        {
            višina = vV;
        }

        public double Višina { get => višina; set => višina = value; }

        public double Površina()//  P = r2 π.
        {
            return 2* Math.PI * Radij * (Radij +Višina);
        }
        public double Volumen() //2r p
        {
            return 2 * Radij + Math.PI;
        }
    }

}

