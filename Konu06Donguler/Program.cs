using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu06Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  for döngüsü
            //döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21 

            //For(x;y;z)
            //x:başlangıç değeri
            //y:bitiş
            //z:artış-azalış değeri

            //int i;

            //for ( i = 1; i <= 5; i++)//ekrana 5 defa "CsharpEgitim" yazdırdık.
            //{
            //    Console.WriteLine("CsharpEgitim");
            //}

            //for (int i = 1; i <= 30; i++)//1 den 30 'a kadarolan sayıları yazdırdık i değişkeni ile
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i += 3)//üçer üçer saydırdık.
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Ekrana Adet Giriniz: ");
            //int finishvalue= int.Parse(Console.ReadLine());

            //for(int i = 1; i <= finishvalue; i++)//kullanıcıdan alınan değere göre döngü
            //{
            //    Console.WriteLine("Hello World");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i %5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int toplamDeger = 0;

            //for (int i = 1; i <= 10; i++) 
            //{
            //    toplamDeger += i;
            //}
            //Console.WriteLine(toplamDeger);



            //int toplamDeger = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i %2 == 0)
            //    {
            //        toplamDeger+=i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(toplamDeger);



            //int Count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Count++;
            //    }
            //}
            //Console.WriteLine(Count);



            //int bakteri = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ".Saat soununda: " + bakteri);
            //}

            #endregion

            #region While Döngüsü

            //While(şart)
            //{
            //işlemler
            //}


            //int i =  1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i %3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion

            #region örnek algoritma sorusu

            //Klavyeden girilen 3 basamaklı sayının basamkları toplamını hesaplayan kodu yazınız.

            //123

            Console.Write("Sayıyı Giriniz: ");
            int number=int.Parse(Console.ReadLine());
            int birler, onlar, yuzler;
            int sum;

            birler = number % 10 ;//3
            onlar = (number % 100) / 10;//2
            yuzler = number / 100 ;//1
            

            Console.WriteLine(birler +"-"+onlar+"-"+yuzler);

            sum = birler + onlar + yuzler;

            Console.WriteLine(sum);
            #endregion

            Console.Read();
        }
    }
}
