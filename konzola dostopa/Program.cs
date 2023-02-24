using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzola_dostopa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            študent janez = new študent();


            Console.WriteLine(janez.Ime);
            janez.Ime = "janez kovač";
            janez.Izpis();


        }
    }
}
