using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static string i;

        static void Main(string[] args)
        {


            /*          int min = 1000;
                   for(int i=0; i<10; i++)
                      {
                          Console.Write(i + ". vnesite številka ");
                          int x = int.Parse(Console.ReadLine());
                          if (x < min)
                          {
                              min = x;
                          }
                      }
                      Console.WriteLine("najmanše je = " + min);*/


            /*Napišite program v katerem generirate 100 naključnih števil med 0 in 99, nato pa
            izpišete vsoto teh sto števil. Naključna števila v C# generiramo s pomočjo razreda
            Random. Uporabite kodo:
            Random r= new Random();
             …….
             Število=r.Next(100); // v spre menljivkištevilo je
             naključno število med 0 in 99 
            int v = 0;
            double d = 0;
            Random r = new Random();
            for (int i = 0; i <100; i++)
            {
                
              int  Število = r.Next(100);
       
                v = v + Število;
            }
            d = v / 100;
            Console.WriteLine("povprečno število " +d);
            */


            /*Napišite program v katerem generirate 1.000 naljučnih števil med 0 in 999, izpišite
povprečno vrednost naključno generiranih števil. 
            int v = 0;
            double d = 0;
            Random r = new Random();
            for (int i = 0; i <1000; i++)
            {
                
              int  Število = r.Next(1000);
       
                v = v + Število;
            }
            d = v / 1000;
            Console.WriteLine("povprečno število " +d);
            }*/

            /*V programu generirajte 100.000 naključnih števil med o in 1.000.000. Denimo, da ta
            števila predstavljajo zneske, ki jih imajo posamezniki na banki. Nato izračunajte vsoto
            teh zneskov . Banka bi rada obračunala obresti ( letne 2,3%) na vsak posamezen
            znesek, zanima jih pa tudi koliko bodo obresti obremenile banko. V ta namen
            izračunajte koliko je 2,3% od vsote vseh zneskov in koliko je vsota obresti ( vsak
            znesek pomnožite s 2,3% in jih nato seštejte). Izpišite oba rezultata. Kaj opazite? */
            //4
            /*            float vsotaZneskov = 0;
                        float vsotaObresti = 0;
                        Random r = new Random();
                        for (int i = 0; i < 100000; i++)
                        {
                            float znesek = r.Next(1000000);
                            vsotaZneskov = vsotaZneskov + znesek;
                            float obresti = znesek * 0.023f;
                            vsotaObresti = vsotaObresti + obresti;
                        }
                        Console.WriteLine("vsota zneskov * 0.23 {0,15:n2}", vsotaZneskov*0.023f);
                        Console.WriteLine("vsota obresti        {0,15:n2}", vsotaObresti);*/

            //Napiši program, ki izpiše vse črke (velike in male) in njihove ASCII kode. V vsaki vrstici naj bo po 10 črk.
            //5


            /*         for (int c =(int)'A'; c <(int)'z' ; c++)
                     {

                         Console.WriteLine((char)c);


                     }*/

            //6
            /*         double x=0;
                     for(int i=1; i<100; i++)
                     {
                         x = x + Math.Sin(Math.PI / i);
                     }
                     Console.WriteLine(x);
            */

            double člen = 1;
            double vsota = 1;
            Console.Write("vnesi x =");
            double x = double.Parse(Console.ReadLine());
            //  for(int i=1; i<101; i++)
            int i = 1;
                while(Math.Abs(vsota-Math.Exp(x))>0.000001)
            {
                člen = člen * x / i;
                vsota = vsota + člen;
                i++;
            }
            Console.WriteLine("Vsota je "+Math.Exp(x));
            
            }
        }
}
