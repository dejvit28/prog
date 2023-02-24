using Liki1_24._02._2023_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link1_24._02._2023_
{
    internal class Program
    {
        static void Main(string[] args)
        {
     /*       Pravokotnik p = new Pravokotnik(0, 2, 2, 0);
            Console.WriteLine("Koordinati kota levo zgoraj = " + p.X1 + "," + p.Y1 +
            "\nKoordinati kota desno spodaj = " + p.X2 + "," + p.Y2);
            Console.WriteLine("Stranica a " + p.StranicaA());
            Console.WriteLine("Stranica b " + p.StranicaB());
            Console.WriteLine("Plošina " + p.Ploščina());

            Kvader vk = new Kvader(0, 1, 1, 0, 1);
            Console.WriteLine("Prostornina kvadra je "+vk.Prostornina());
            Console.WriteLine("Površina kvadra je "+vk.Površina());
     */
            Valj v = new Valj(37, 45, 2.5f, 1f);
            Console.WriteLine("X koordinata = " + v.X +
            "\nY koordinata = " + v.Y +
            "\nRadij =" + v.Radij +
            "\nVišina =" + v.Višina);
            Console.WriteLine("Površina = " + v.Površina());
            Console.WriteLine("Volumen =" + v.Volumen());
            Console.ReadLine();


        }
    }
}
