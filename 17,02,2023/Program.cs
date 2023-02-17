using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("ali želite nastaviti (da/ne)");

             string w1 = (Console.ReadLine());

             if (w1.Equals("da"))
             {
                 w = true;
             }else
                 if (w1.Equals("ne"))
             {
                 w = false; 
             }

         } while (w == true);


         /*   Random r = new Random();
            bool w = false;
            int i=0;
            do
            {

                    Console.Write("vnesi število ");//vnos
                int x = int.Parse(Console.ReadLine());//vnos 
                for (int k = 1; k < 6; k++)
                {
                    int y = r.Next(10);//ranodm
                    Console.WriteLine(y + " * " + x, " = ?");//vpprašanje
                    int odg1 = int.Parse(Console.ReadLine());//vnos 
                    if (x * y == odg1)
                    {
                        i++;

                    }
                }

                Console.WriteLine("imate " + i + " tačnih odgovora");
                Console.WriteLine("ali želite ponova začeti true za DA, false za NE");

                  string  w1 = (Console.ReadLine());
                  i = 0;
                 if (w1.Equals("ja"))
                 {
                     w = true;
                 }



            } while (w == true);

            */
            /*      bool w = false;
                  Random r = new Random();
                  Console.Write("vnesi začetno stanje  ");
                  int banka = int.Parse(Console.ReadLine());
                  Console.Write("vnesi začetno stavo  ");
                  int stava = int.Parse(Console.ReadLine());
                  int x = r.Next(36);//random
                  int min = 0;
                  int max = 10000;
                  int začetnoStanje = banka;
                  int začetnaStava = stava;
                  string barva = "";
                  for (int i = 1; i < 11; i++)
                  {
                      if (x % 2 == 0)//parni za rdača
                      {
                          banka = banka + stava;
                          stava = začetnoStanje;
                          barva = "rdeča";
                      }
                      else if(x%2 !=0)//neparni za črna
                      {
                          banka = banka - stava;
                          stava = začetnoStanje;
                          barva = "rdeča";
                      }

                      if (banka < min)
                      {
                          min = banka;
                      }
                      if (začetnoStanje > max)
                      {
                          max = banka;
                      }
                      Console.WriteLine("met: " + i + " barva " + barva + " stanje " + banka);

                  }
                  int razlika = banka - začetnoStanje;
                  Console.WriteLine("število metov: "+10);
                  Console.WriteLine("začetno stanje: "+začetnoStanje);
                  Console.WriteLine("končno stanje: "+ banka);
                  Console.WriteLine("najviše stanje: "+ max);
                  Console.WriteLine("najnižje stanje: "+ min);
                  Console.WriteLine("razlika med stanjem: "+razlika);

                 */

            Točka t1 = new Točka(1.0, 1.0);
            t1.Izpis();
            Točka t2 = new Točka(1.0, 180);
            t2.Izpis();

        }
    }
}
