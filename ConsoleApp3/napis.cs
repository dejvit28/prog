using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class napis
    {
        public string najljubšiProgram;//vezano na objekt
        public static int štIzvodov;//vezano na razred
        public void Izpiši()
        {
            Console.WriteLine("rad imam "+najljubšiProgram);
        }
        public napis()
        {
            najljubšiProgram = "neznano";
            Console.WriteLine("konstruktor brez parametrov");
                štIzvodov++;
        }
        public napis(string n)
        {
            najljubšiProgram = n; 
            Console.WriteLine("konstruktor s parametri");
            štIzvodov++;
        }
        public static void Koliko()
        {
            Console.WriteLine("število objektov tipa Napis je "+štIzvodov);
        }
    }
}
