using System; // Console sınıfını kullanabilmek için bu kütüphane şart

namespace C_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5] { 5, 12, 33, 56, 77 };
            int aradigimsayi = Convert.ToInt32(Console.ReadLine());
            int kucuk, buyuk, orta;

            kucuk = 0;
            buyuk = sayilar.Length - 1;

            while (kucuk <= buyuk)
            {
                orta = (kucuk + buyuk) / 2;

                if (aradigimsayi == sayilar[orta])
                {
                    // İndis 0'dan başladığı için kullanıcıya kaçıncı sırada olduğunu daha net göstermek adına (orta + 1) yazabilirsin
                    Console.WriteLine("Aradığım sayı dizinin {0}. indeksinde (Yani {1}. elemanı)", orta, orta + 1);
                    break;
                }
                // Eşittir kontrolünü kaldırdık, sadece küçüktür bıraktık
                else if (aradigimsayi < sayilar[orta])
                {
                    buyuk = orta - 1;
                }
                else
                {
                    kucuk = orta + 1;
                }
            }

          
            Console.WriteLine("\nÇıkış yapmak için Enter tuşuna basın...");
            Console.ReadLine();
        }
    }
}
