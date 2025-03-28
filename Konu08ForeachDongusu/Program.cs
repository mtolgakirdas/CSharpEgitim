using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] sehirler = { "Ankara", "Bursa", "İstanbul", "Kayseri", "Mugla", "roma" };

            //foreach (string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}



            //int[] sayi = { 45, 4564, 3, 2, 54, 6, 222, 567, 345, 77, 3342, 889, 90, 132, 34, 56, 348 };
            //foreach (int i in sayi)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] sayi = { 45, 4564, 3, 2, 54, 6, 222, 567, 345, 77, 3342, 889, 90, 132, 34, 56, 348 };

            //foreach (int i in sayi) //2'ye bölünenleri saydırma
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}




            //int[] sayi = { 45, 4564, 3, 2, 54, 6, 222, 567, 345, 77, 3342, 889, 90, 132, 34, 56, 348 };

            //int toplam = 0;

            //foreach (int i in sayi)
            //{
            //    toplam += i;

            //}
            //Console.WriteLine(toplam);


            //List<int> sayi = new List<int>()
            //{
            //    1,2,34,4,6,9
            //};

            //foreach (int i in sayi)
            //{
            //    Console.WriteLine(i);
            //}


            //string kelime = "Merhaba";

            //foreach (char c in kelime)
            //{
            //    Console.WriteLine(c);
            //}



                









            //Console.Read();


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("****** C# Sınav Sistemi Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("---------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            //int OgrenciCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------");

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] OgrenciAd = new string[OgrenciCount];
            //double[] OgrenciAvgNot= new double[OgrenciCount];

            //for (int i = 0; i < OgrenciCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
            //    OgrenciAd[i] = Console.ReadLine();

            //    double totalSinavSonuc = 0;

            //    //Her Öğrenci için 3 sınav notu girişi


            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{OgrenciAd[i]} adlı öğrencinin {j + 1}. Sınav notunu giriniz :");
            //        double value = double.Parse(Console.ReadLine());
            //        totalSinavSonuc += value;//notları topluyoruz
            //    }
            //    Console.WriteLine();
            //    OgrenciAvgNot[i] = totalSinavSonuc /3;
            //}

            //// SINAV ORTALAMALARI
            // for (int i = 0;i < OgrenciCount;i++)
            //{
            //    Console.WriteLine("-----------------------------------------------------");
            //    Console.WriteLine($"{OgrenciAd[i]} adlı öğrencinin ortalaması : {OgrenciAvgNot[i]}");

            //    //Öğrencilerin ortalamasını ve geçip kalma durumları
            //    if (OgrenciAvgNot[i] >= 50)
            //    {
            //        Console.WriteLine($"{OgrenciAd[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{OgrenciAd[i]} adlı öğrenci dersten kaldı. ");
            //    }

            //    Console.WriteLine("-----------------------------------------------------") ;
            //}

            #endregion
        }
    }
}
