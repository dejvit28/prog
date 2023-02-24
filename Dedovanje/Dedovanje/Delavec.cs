﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Delavec
    {
        protected string delID;
        protected string ime;
        protected double urnaPostavka;
        protected int štUr;
        protected double brutoPlača;

        public string DelID { get => delID; set => delID = value; }
        public string Ime { get => ime; set => ime = value; }
        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }
        public int ŠtUr { get => štUr; set => štUr = value; }
        public double BrutoPlača
        {get
            { return urnaPostavka * štUr; }
        }
        public void Izpis()
        {
            Console.WriteLine("*************DELAVEC*************");
            Console.WriteLine("ID              " + delID);
            Console.WriteLine("Ime             " + ime);
            Console.WriteLine("Urna postava    " + urnaPostavka);
            Console.WriteLine("Število ur      " + štUr);
            Console.WriteLine("Bruto plača     " + brutoPlača);
            Console.WriteLine("*********************************");
        }
        public Delavec(string i,string im,double up,int š)
        {
            Console.WriteLine("Sem v konstruktorju delavec.");
            delID = i;
            ime = im;
            urnaPostavka = up;
            štUr = š;
        }
        public Delavec()
        {
            Console.WriteLine("Konstruktor Delavec brez parametrov");
        }
    }
}
