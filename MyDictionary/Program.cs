using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            Console.WriteLine("Sözlük oluşturuldu.");

            ogrenciler.Ekle(1, "Ali Karagöz");
            ogrenciler.Ekle(2, "Sefa Kılıç");
            ogrenciler.Ekle(3, "Enes Alper");
            ogrenciler.Ekle(4, "Özgür Özdemir");
            ogrenciler.Ekle(5, "Anıl Ateş");
            ogrenciler.Ekle(6, "Adem Sarıdağ");

            ogrenciler.Listele();

        }
    }
    
    class MyDictionary<TAnahtar, TDeger>
    {
        (TAnahtar,TDeger)[] dizi;
        public MyDictionary()
        {
            dizi = new (TAnahtar, TDeger)[0];
        }

        public void Ekle(TAnahtar anahtar, TDeger deger)
        {
            (TAnahtar, TDeger)[] geciciDizi = dizi;
            dizi = new (TAnahtar, TDeger)[dizi.Length + 1];

            for (int i = 0; i < geciciDizi.Length; i++)
            {
                dizi[i] = geciciDizi[i];
            }

            dizi[dizi.Length - 1] = (anahtar, deger);
        }
        
        public void Listele()
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Anahtar: "+dizi[i].Item1+" Değer: " + dizi[i].Item2);
            }
        }
    }
}
