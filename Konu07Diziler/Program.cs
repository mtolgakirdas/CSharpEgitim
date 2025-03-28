using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Konu07Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //adana,ankara,istanbul,kayseri
            //Değişkentürü[] diziadı =new DeğişkenTürü[ElemanSayısı]

            //string[] renk = new string[4];
            //renk[0] = "Kırmızı";
            //renk[1] = "sarı";
            //renk[2] = "Beyaz";
            //renk[3] = "Mavi";

            //Console.WriteLine(renk[1]);
            /////////////////////////////////////////////////////////////
            //string[] sehir = new string[5];

            //sehir[0] = "Adana";
            //sehir[1] = "Ankara";
            //sehir[2] = "İstanbul";
            //sehir[3] = "Kayseri";
            //sehir[4] = "İzmir";

            //Console.WriteLine(sehir[5]);//hata verir beşinci index yoktur 4 'e kadar vardır.


            //int[] sayilar = new int[10];
            //sayilar[0] = 2;
            //sayilar[1] = 45;
            //sayilar[2] = 232;
            //sayilar[3] = 12;
            //sayilar[7] = 120;

            //Console.WriteLine(sayilar[5]);//indexe değer atamazsanız karşılığı 0 olarak döner.


            //string[] sehir = { "Adana", "İstanbul", "bursa" };

            //Console.WriteLine(sehir[2]);





            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] renk = { "Sarı", "Kırmızı", "Yeşil", "Mavi","Turuncu" };

            //for (int i = 0; i < renk.Length; i++)
            //{
            //    Console.WriteLine(renk[i]);
            //}



            //int[] sayilar = { 3, 45, 243, 456, 326, 6767, 32, 78, 95, 75 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 3 ==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}



            //char[] sembol = { 'A', 'b', 'c', '*', '/' };

            //for (int i = 0; i < sembol.Length; i++)
            //{
            //    Console.WriteLine(sembol[i]);
            //}



            //int[] Dizi = {1,234,2356,34,67,213,899,123,11,23 };
            //int maxDeger = Dizi[0];

            //for (int i = 0; i < Dizi.Length; i++)
            //{
            //    if (Dizi[i] > maxDeger)
            //    {
            //        maxDeger = Dizi[i];
            //    }
            //}
            //    Console.WriteLine(maxDeger);


            //Dizi Metodları(lenght,)
            //string[] person = { "ali", "ayşe", "cengiz", "tolga" };
            //Console.WriteLine(person.Length);


            //int[] sayilar = { 12, 13, 1435, 3452354, 32454, 2, 4, 5, 788, 43, 567, 8 };
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}



            //int[] sayilar = { 12, 13, 1435, 3452354, 32454, 2, 4, 5, 788, 43, 567, 8 };
            //Array.Reverse(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region Dizi Metotları

            //string[] musteriler = {"Ali","Ayşe","Kamil","Merve","Tolga","Bilal" };
            //int index = Array.IndexOf(musteriler, "Tolga");
            //Console.WriteLine(index);


            //int[] sayilar = { 12, 13, 1435, 3452354, 32454, 2, 4, 5, 788, 43, 567, 8 };
            //Console.WriteLine("Dizinin En Büyük Elemanı : " + sayilar.Max() + "Dizinin En Küçük Elemanı : " + sayilar.Min());


            #endregion

            #region Kullanıcıdan Değer Alma
            string[] sehir = new string[5];
            for (int i = 0; i < sehir.Length; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. Şehri Giriniz : ");
                sehir[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");
             
            for (int i = 0;i < sehir.Length; i++)
            {
                Console.WriteLine(sehir[i]);
            }
            #endregion
        }
    }
}
