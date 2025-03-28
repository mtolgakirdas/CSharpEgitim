using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu09Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region void Metotlar

            //()
            //Geriye değer döndürmeyen Metotlar
            //Customer --> Listele,ekle,sil,güncelle
            //void

            //void MusteriList()
            //{
            //    Console.WriteLine("Tolga Kırdaş");
            //    Console.WriteLine("Mustafa Yıldız");
            //    Console.WriteLine("Mustafa Çorlu");
            //    Console.WriteLine("Enes Dede");
            //}
            //MusteriList();




            //void toplam()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //toplam();








            #endregion


            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void YazdırMethod(string MusteriAd)
            //{
            //    Console.WriteLine(MusteriAd );
            //}

            //YazdırMethod("mehmet  yıldırım");

            //void MusteriKart(string name ,string surname)
            //{
            //    Console.WriteLine("Müşteri : " +name+" " +surname);

            //}

            //MusteriKart("Mehmet", "Yıldırım");
            //MusteriKart("Ayşegül", "Can");

            //Console.Read();
            #endregion


            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void toplam(int sayi1 , int sayi2, int sayi3)
            //{

            //    int sonuc = sayi1 + sayi2 + sayi3;
            //    Console.WriteLine(sonuc);
            //}

            //toplam(4, 6, 7);
            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string MusteriAd()
            //{
            //    return "Mustafa Yıldız";
            //}

            //MusteriAd();



            //string OgrenciKart()
            //{
            //    string name = "Ali";
            //    string surname = "Koç";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(OgrenciKart());
            #endregion



            #region Geriye Değer Döndüren string Parametreli Metotlar 

            //string UlkeKart(string UlkeName, string Baskent, string BayrakRenk)
            //{
            //    string kartInfo ="Ülke : "+ UlkeName + " - Başkent: " +  Baskent + " - Bayrak Rengi :" + BayrakRenk;
            //    return kartInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz :");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz : ");
            //z = Console.ReadLine();


            //Console.WriteLine(UlkeKart(x, y, z));

            //Console.WriteLine(UlkeKart("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion


            #region Geriye Değer Döndüren Int Parametreli Metotlar 

            //int toplam (int sayi1 , int sayi2)
            //{
            //    int sonuc =  sayi1 + sayi2;
            //    return sonuc;

            //}

            //Console.WriteLine(toplam(45, 98));
            //Console.WriteLine(toplam(56, 98));
            //Console.WriteLine(toplam(25, 96));
            //Console.WriteLine(toplam(35, 64));


            #endregion


            #region Örnek Uygulama

            //string SinavSonuc (string ogrenci , int sinav1 ,int sinav2,int sinav3)
            //{
            //    int sonuc = (sinav1 + sinav2 + sinav3) /3;
            //    if (sonuc >=50)
            //    {
            //        return ogrenci + "isimli Öğrenci sınavı geçti . " + "Ortalama : " + sonuc;

            //    }
            //    else
            //    {
            //        return ogrenci + "isimli Öğrenci sınavı geçemedi . " + "Ortalama : " + sonuc;
            //    }
                
            //}
            //Console.WriteLine(SinavSonuc("Ali ",25,45,67));
            //Console.WriteLine(SinavSonuc("Ayşe ",65,15,23));


            #endregion


            Console.Read();
            
        }




    }
}
