using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje__abstraktni_razredi__vmesniki_24._02._2023_
{
    internal abstract class Vozilo
    {
      protected  string proizvajalca;
      protected  string model;
      protected  int leto;
      protected  string barvo;

        public string Proizvajalca { get => proizvajalca; set => proizvajalca = value; }
        public string Model { get => model; set => model = value; }
        public int Leto { get => leto; set => leto = value; }
        public string Barvo { get => barvo; set => barvo = value; }
    }
    //public  Vozilo(string proizvajalca1, string model1, int leto1,string barvo1)
    //{
    //    //proizvajalca = proizvajalca1;
    //    //model = model1;
    //    //letoIzdelave = leto1; 
    //    //barvo = barvo1;
    //}

}
