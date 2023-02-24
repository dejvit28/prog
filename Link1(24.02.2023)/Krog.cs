﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link1_24._02._2023_
{
    internal class Krog
    {
        int x; //je private dostop
        int y;
        double radij;
        public Krog(int xK, int yK, double rK)
        {
            x = xK;
            y = yK;
            radij = rK;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public double Radij { get => radij; set => radij = value; }

        //metodi Premer in Ploščina
        public double Premer()
        {
            return 2 * radij;  //2 krat radij
        }
        public double Ploščina()
        {
            return Math.PI * radij * radij;  //številka pi krat radij na dva
        }
    }
}
