using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri yeniMusteri)
        {
  

            Console.WriteLine(yeniMusteri.Adi + " " + yeniMusteri.SoyAdi + " " + "isimli müşteri başarıyla sisteme eklendi.");
        }
        public void Cikar(Musteri cikarMusteri)
        {
            Console.WriteLine(cikarMusteri.Adi + " " + cikarMusteri.SoyAdi + " " + "isimli müşteri başarıyla sisteden çıkarıldı.");
        }


    }
}
