using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ustvarite program, v katerem boste opisovali več vozil. Obstajajo tri vrste vozil: avtomobili,
tovornjaki in motorna kolesa. Vsa vozila imajo proizvajalca, model, leto izdelave in barvo. xx
Vendar ima vsaka vrsta vozila svoj edinstven niz lastnosti:
Avtomobili imajo več vrat in prostornino prtljažnika.
Tovornjaki imajo nosilnost in vlečno zmogljivost.
Motocikli imajo več koles in največjo hitrost.
Ustvarite abstraktni razred Vozilo, ki vsebuje skupne lastnosti vseh vozil. Po potrebi dodajte
lastnosti in metode razredu Vozilo za uveljavitev enkapsulacije.
Ustvarite vmesnik IDrivable, ki definira obnašanje voznih vozil. Vmesnik IDrivable bi moral
vključevati metodo Drive, ki meri razdaljo v kilometrih in vrne količino porabljenega goriva.
Ustvarite konkretne razrede Car, Truck in Motorcycle, ki podedujejo razred Vozilo in
implementirajte vmesnik IDrivable. Vsakemu razredu po potrebi dodajte lastnosti in metode,
da uveljavite enkapsulacijo in izpolnite zahteve problema.
V metodi Main testirajte delovanje.
 */
namespace Dedovanje__abstraktni_razredi__vmesniki_24._02._2023_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motocikli a = new Motocikli();//za avto
            a.ŠtVrat = 5;
            a.Barvo = "rdeča";
            a.Proizvajalca = "Audi";
            a.Model = "rs7";
            a.Leto = 2023;
            Console.WriteLine("Avto*****");
            Console.WriteLine("Proizvajalec " + a.Proizvajalca);
            Console.WriteLine("Model        " + a.Model);
            Console.WriteLine("Leto         " + a.Leto);
            Console.WriteLine("za 30 km porabiš "+a.Drive(30)+" Litrov");

            Console.WriteLine();//prazan prostor ena vrstica
            Console.WriteLine();//prazan prostor ena vrstica

            Tovornjaki t = new Tovornjaki();//Tovornjaki
            t.Barvo = "črna";
            t.Proizvajalca = "Volvo";
            t.Model = "tp90";
            t.Leto = 2023;
            t.Nosilnost = 5000;
            t.Vlečnozmogljivost = 3500;
            Console.WriteLine("Tovornajk*****");
            Console.WriteLine("Proizvajalec " + t.Proizvajalca);
            Console.WriteLine("Model        " + t.Model);
            Console.WriteLine("Leto         " + t.Leto);
            Console.WriteLine(" nosilnost   " + t.Nosilnost + " KG");
            Console.WriteLine("vlečno zmogljivost" + t.Vlečnozmogljivost + " ");
            Console.WriteLine("za 50 km porabiš " + t.Drive(50) + " Litrov");

            Console.WriteLine();//prazan prostor ena vrstica
            Console.WriteLine();//prazan prostor ena vrstica


            motocikli m = new motocikli
            {
                Barvo = "rdeča",
                Proizvajalca = "Ducatti",
                Model = "Pista",
                Leto = 2023,
                ŠtKoles = 2,
                NajvečjoHitrost = 315
            };//za Motocikli
            Console.WriteLine("Motocikli*****");
            Console.WriteLine("Proizvajalec " + m.Proizvajalca);
            Console.WriteLine("Model        " + m.Model);
            Console.WriteLine("Leto         " + m.Leto);
            Console.WriteLine("število Koles" + m.ŠtKoles);
            Console.WriteLine("Največjo Hitrost" + m.NajvečjoHitrost);
            Console.WriteLine("za 30 km porabiš " + m.Drive(50) + " Litrov");
        }
    }
}
