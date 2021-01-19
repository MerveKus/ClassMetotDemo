using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add (Musteri musteri)
        {
            Console.WriteLine("Costumer is added :" + musteri.MusteriAdiSoyadi + " TC Kimlik No:" + 
                musteri.tckimlikno + " Musteri No " + musteri.MusteriIDno);
        }
        public void Update (Musteri musteri)
        {
            Console.WriteLine("Costumer infos are updated :" + musteri.MusteriAdiSoyadi + " TC Kimlik No:" + 
               musteri.tckimlikno + " Musteri No " + musteri.MusteriIDno);
        
         }

        public void Delete (Musteri musteri)
        {
            Console.WriteLine("Costumer infos are deleted :" + musteri.MusteriAdiSoyadi + " TC Kimlik No:" + 
                musteri.tckimlikno + " Musteri No " + musteri.MusteriIDno);

        }
    }
}
