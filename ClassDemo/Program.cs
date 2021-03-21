using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Huawei P20 Lite";
            product1.productCategory = "Smartphone";
            product1.productPrice = "2600 TL";

            Product product2 = new Product();
            product2.productName = "iPhone 11 Pro";
            product2.productCategory = "Smartphone";
            product2.productPrice = "8000 TL";

            Product product3 = new Product();
            product3.productName = "Lastvoice BM800 Condenser Microphone";
            product3.productCategory = "Microphone";
            product3.productPrice = "450 TL";

            Product[] products = new Product[] {product1,product2,product3};

            Console.WriteLine("-*-*-*For Loop-*-*-*");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Kategori: " + products[i].productCategory + "\n" + "Ürün Adı: " + products[i].productName + "\n" + "Fiyatı: " + products[i].productPrice + "\n---------------------------");
            }
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("-*-*-*For Each Loop-*-*-*");
            foreach (var product in products)
            {
                Console.WriteLine("Kategori: " + product.productCategory + "\n" + "Ürün Adı: " + product.productName + "\n" + "Fiyatı: " + product.productPrice + "\n---------------------------- ");
            }
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("-*-*-*While Loop-*-*-*");
            var urun = 0;
            while (urun<3)
            {
                Console.WriteLine("Kategori: " + products[urun].productCategory + "\n" + "Ürün Adı: " + products[urun].productName + "\n" + "Fiyatı: " + products[urun].productPrice + "\n-----------------------------");
                urun++;

            }
        }
    }

    class Product
    {
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string productPrice { get; set; }
    }
}
