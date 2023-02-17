﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_2023
{
    internal class Točka
    {
        double x;
        double y;
        double r;
        int kot; //kot je v stopinjah
        public void PretvoriVPolarne()
        {
            //x je poznam, računam r in kot
            r = Math.Sqrt(x * x + y * y);
            kot =(int) (Math.Atan(y / x)*180/Math.PI);
        }
        public void PretvoriVKartezične()
        {
            //r in kot poznam, x in y računam
            x =Math.Round (r * Math.Cos(kot * Math.PI / 180),2);
            y =Math.Round (r * Math.Cos(kot * Math.PI / 180),2);
        }
        //konstruktor
        public Točka()
        {
            x = 0;y = 0;
            PretvoriVPolarne();
        }
        public Točka(double x1, double y1)
        {
            x = x1;y = y1;
            PretvoriVPolarne();
        }
        public Točka(double r1, int kot1)
        {
            r = r1; kot = kot1;
            PretvoriVKartezične();
        }
        public void Izpis()
        {
            Console.WriteLine("*****TOČKA*****");
            Console.WriteLine("Kartezične: ("+x+","+y+")");
            Console.WriteLine("Polarne: (" + r + "," + kot + "°)");
        }
    }
}
