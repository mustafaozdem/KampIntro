using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndivisualCustomer customer1 = new IndivisualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.TcNo = "12345678910";

            //Kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1324567890";


            //Gerçek Müşteri - Tüzel Müşteri 
            // SOLID

            Customer customer3 = new IndivisualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            

        }
    }
}
