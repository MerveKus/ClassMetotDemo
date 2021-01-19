using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdiSoyadi= "Doron Kavillio";
            musteri1.MusteriIDno = 123;
            musteri1.tckimlikno = 12345678900;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdiSoyadi = "Bashar Hamdan";
            musteri1.MusteriIDno = 456;
            musteri1.tckimlikno = 98731105895;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdiSoyadi = "Mickey Moreno";
            musteri3.MusteriIDno = 789;
            musteri3.tckimlikno = 98744405847;


            MusteriManager costumermanager = new MusteriManager();
            costumermanager.Add(musteri1);
            costumermanager.Add(musteri2);
            costumermanager.Add(musteri3);

            costumermanager.Update(musteri3);
            costumermanager.Delete(musteri3);
        }
    }
}
