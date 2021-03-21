using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.productName = "Armut";
            product1.productPrice = 15;
            product1.productDescription = "Armut gibi armut";

            Product product2 = new Product();
            product2.productName = "Karpuz";
            product2.productPrice = 60;
            product2.productDescription = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.productName);
                Console.WriteLine(product.productPrice);
                Console.WriteLine(product.productDescription);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("-------------------Methods-------------------");

            //instance - örnek
            //encapsulation
            CardManager cardManager = new CardManager();
            cardManager.Ekle(product1);
            cardManager.Ekle(product2);
            cardManager.Ekle2("Armut", "Armut gibi armut", 12);
            cardManager.Ekle2("Karpuz", "Diyarbakır karupuzu", 60);
        }
    }
}
