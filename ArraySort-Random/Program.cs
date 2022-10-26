using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eşsiz Rastgele sayı
            int[] sayilar = new int[10];
            bool ayniSayidanVarMi = false;
            Random rastgele = new Random();

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    ayniSayidanVarMi = false;
                    sayilar[i] = rastgele.Next(20);
                    for (int k = 0; k < i; k++)
                    {
                        if (sayilar[k] == sayilar[i]) // Varsa içeri girer.
                            ayniSayidanVarMi = true;
                    }
                    if (ayniSayidanVarMi == false) // Yoksa döngüyü  kırar.
                        break;
                }
            }
            Console.WriteLine("Liste;");
            foreach (int yaz in sayilar) // Ekrana Yazdır.
                Console.Write(yaz + " ");

            // En büyük ve en küçüğü bulma
            int enBuyuk = sayilar[0], enKucuk = sayilar[0];
            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] > enBuyuk)
                    enBuyuk = sayilar[i];
                if (sayilar[i] < enKucuk)
                    enKucuk = sayilar[i];
            }
            Console.WriteLine("\n\nListedeki; \nEn büyük Değer = " + enBuyuk + "\nEn küçük Değer = " + enKucuk);

            // Sırala
            int[] yeniSayilar = new int[10];
            int enBuyukIndex=0, enBuyukYeni = sayilar[0];

            for (int i = 0; i <10; i++)
            {
                enBuyukYeni = 0;
                for (int k = 0; k < 10; k++)
                {
                    if (sayilar[k]>enBuyukYeni)
                    {
                        enBuyukYeni = sayilar[k];
                        enBuyukIndex = k;
                    }
                }
                yeniSayilar[i] = enBuyukYeni;
                sayilar[enBuyukIndex] = 0;
            }

            foreach (int yaz in yeniSayilar) // Ekrana Yazdır.
                Console.Write(yaz + " ");

            Console.ReadKey();
        }
    }
}
