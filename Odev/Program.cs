using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "İphone 12";
            product1.UrunKodu = "APIP12";
            product1.UrunFiyati = 14000;

            Product product2 = new Product();
            product2.UrunAdi = "İphone 11";
            product2.UrunKodu = "APIP11";
            product2.UrunFiyati = 12000;

            Product product3 = new Product();
            product3.UrunAdi = "İphone 10";
            product3.UrunKodu = "APIP10";
            product3.UrunFiyati = 10000;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.UrunAdi);


            }


            Console.WriteLine("Hello World!");
        }
    }


    class Product
    {
        public string UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public int UrunFiyati { get; set; }




    }
}
