using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delavec d = new Delavec("123", "Janez Novak", 10, 160);
            d.Izpis();
            Console.WriteLine(
                );
            Console.WriteLine();
            LDelavec a = new LDelavec();
            a.DelID = "5678";
            a.Ime = "Miha Potrč";
            a.LetnaPlača = 12000;
            a.Izpis();
            Console.ReadLine();
        }
    }
}
