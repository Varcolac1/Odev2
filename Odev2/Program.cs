using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customManager = new CustomerManager();
            Customer musteri1 = new Customer();
            musteri1.name = "Ülkü";
            musteri1.lastName =  "Demir";
            musteri1.age = 18;

            Customer musteri2 = new Customer();
            musteri2.name = "Murat";
            musteri2.lastName = "Demir";
            musteri2.age = 18;

            Customer[] customers = new Customer[] {musteri1, musteri2 };
            foreach (Customer x in customers)
            {
                Console.WriteLine(x.name);
                Console.WriteLine(x.lastName);
                Console.WriteLine(x.age);
                Console.WriteLine("-------------");
            }
            customManager.AddCustomer(musteri1);
            customManager.DeleteCustomer(musteri1);
            customManager.AddCustomer(musteri2);
            customManager.DeleteCustomer(musteri2);
            Console.ReadLine();
            
        }
    }
}
