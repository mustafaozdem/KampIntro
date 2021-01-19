using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "11111111111";
            musteri1.Adi = "Ali";
            musteri1.SoyAdi = "Veli";
            musteri1.Cinsiyeti = "Erkek";
            musteri1.Yasi = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "11111111112";
            musteri2.Adi = "Ahmet";
            musteri2.SoyAdi = "Mehmet";
            musteri2.Cinsiyeti = "Erkek";
            musteri2.Yasi = 32;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.SoyAdi + ". Yaşı: " +musteri.Yasi);

                Console.WriteLine("------------------");
            }


               
         
       


        }
    }
}
