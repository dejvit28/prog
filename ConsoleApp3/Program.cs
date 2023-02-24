using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            napis x = new napis("C#");
            x.Izpiši();
            napis.Koliko();

            napis y =new napis();
            y.najljubšiProgram = "python";
            y.Izpiši();
            napis.Koliko();

            napis.štIzvodov = 5;

        }
    }
}
