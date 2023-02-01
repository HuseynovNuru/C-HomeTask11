using System;

namespace CHomeTask11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store= new Store();


            Product pr1 = new Product
            {
                Category = "Laptop",
                Price = 2000,
                No = "1"
            };

            Product pr2 = new Product
            {
                Category = "Telephone",
                Price = 900,
                No = "2"
            };
            try
            {
                store.AddProduct(pr1);
                store.AddProduct(pr2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bele mehsul movcud deyil.");
            }
        }
    }
}
