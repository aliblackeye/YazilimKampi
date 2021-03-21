using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CardManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine(product.productName + " Sepete eklendi");

        }

        public void Ekle2(string productName, string productDescription, double productPrice)
        {
            Console.WriteLine(productName + " Sepete eklendi");
        }
    }
}
