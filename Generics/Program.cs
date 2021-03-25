using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste<string> sehirler = new Liste<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.ElemanSayisi);

        }

    }

    class Liste<Tip> //Generic class
    {
        Tip[] dizi;
        Tip[] geciciDizi;
        public Liste()
        {
            dizi = new Tip[0];
        }
        public void Add(Tip eleman)
        {
            geciciDizi = dizi;
            dizi = new Tip[dizi.Length + 1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                dizi[i] = geciciDizi[i];
            }

            dizi[dizi.Length - 1] = eleman;

            

        }

        public int ElemanSayisi
        {
            get { return dizi.Length; }
        }


    }
}
