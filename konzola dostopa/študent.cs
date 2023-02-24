using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzola_dostopa
{
    internal class študent
    {
        private string študentID;
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string naslov;
        private int starost;
        private double povprečnaOcena;
        public študent()
        {
            študentID = "1234";
            ime = "Janez Novak";
            naslov = "Cankarjeva";
            starost = 19;
            povprečnaOcena = 7.5;
        }
        public void Izpis()
        {
            Console.WriteLine("****Študent****");
            Console.WriteLine("ID  "+študentID);
            Console.WriteLine("Ime  "+ime);
            Console.WriteLine("naslov "+naslov);
            Console.WriteLine("starost "+starost);
            Console.WriteLine("povprečje "+povprečnaOcena);
        }
    }
}
