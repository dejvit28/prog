using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Izdelajte novo aplikacijo v kateri boste izpisovali naključno karto. Najprej si definirajte dva
naštevna tipa: Barva (lahko je srce, karo, pik in križ) in Vrednost (lahko je as, dvojka, trojka,
štirka,…, fant, dama ali kralj). Nato si v programu deklarirajte dve spremenljivki: eno tipa
Barva, drugo tipa Vrednost. Spremenljivki tipa Barva priredite naključno vrednost barve,
spremenljivki tipa Vrednost pa naključno vrednost. Izpišite obe vrednosti. Naključne
vrednosti spremenljivkam prirejamo s pomočjo razreda Random:
…..
Random r=new Random();
…..
int x=r.next(10); //x dobi naključno vrednost med 0 in 10 t.j. 0,1,2,3,4,5,6,7,8 ali 9
 */

namespace Nastevnitip
{
                internal class Program
                {
                    static void Main(string[] args)
                    {
            Random ran = new Random();
            int Barva = ran.Next(4);
            int Stevilka = ran.Next(10);

            karte ka = (karte)Barva;
            Vrednost vr = (Vrednost)Stevilka;

            Console.Write("karta je " +  ka);
            Console.WriteLine(" z vrednostjo " + vr);


            /*
                Console.Write("Kakšen tip klica uporabljate(Mobilno = 1 ali Stacionarno = 2) ");
                                    string klic = Console.ReadLine();
                                    int tip = int.Parse(klic);
                        Console.Write("vnesite minute ");
                        int minute =Convert.ToInt32 (Console.ReadLine());

                        if (tip==(1)) 
                        {
                            double Sum = minute * 0.03;

                            Console.WriteLine("Znesek je " + Sum);
                        }
                        else
                        {
                            double Sum = minute * 0.02;
                            Console.WriteLine("Znesek je " + Sum);
                        }



             */





            /*     Console.Write("Kakšen tip klica uporabljate(Mobilno ali Stacionarno) ");
             Console.ReadLine();
             Planeti p = Planeti.Zemlja;
             Console.WriteLine("Izbral sam "+p);
             int odd =(int)p;
             Console.WriteLine("Po oddaljenosti od sonca je "+odd);
             PeriodaPlaneti pp = PeriodaPlaneti.Zemlja;
             if (pp <= PeriodaPlaneti.Mars) 
             {
                 Console.WriteLine("Obhodni cas je "+(int)pp);
             }else
             {
                 Console.WriteLine("Obhodni čas je "+pp);
             }
             Console.Write("Vnesi zaporedno številko tvojeg meseca ");
             string odg = Console.ReadLine();
             int mojPlanet = int.Parse(odg);
             Planeti moj = (Planeti)mojPlanet;
             Console.WriteLine("Tvoj planet je "+moj);*/

        }
    }
}
