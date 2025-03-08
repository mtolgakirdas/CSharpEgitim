using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu05KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = -10;
            if (sayi > 0 )//Eğer sayı değişkeninin değeri 0 dan büyükse if bloğu çalışacak
            {
                Console.WriteLine("Sayı Pozitiftir.");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sayı sıfırdır");
            }
            else
            {
                Console.WriteLine("Sayı Negatiftir");
            }
            //ÇIKTI : SAYI NEGATİFTİR OLACAKTIR ÇÜNKÜ SAYI 0 DAN BÜYÜK MÜ HAYIR O ZAMAN O BLOĞU ATLAR SAYI SIFIR Mİ HAYIR ATLA SAYI SIFIFRDAN KÜÇÜKMÜ EVET O ZAMAN YAZDIR



            Console.Write("Kullanıcı Adını Giriniz:");
            string kullaniciAdi = Console.ReadLine();//Conseole.Read() metodu girilen değeri yakalar ve değşkeni yazdırır
            Console.Write("Şifrenizi Giriniz:");
            string sifre = Console.ReadLine();

            string veritabanindakiKullaniciAdi = "admin";
            string veritabanindakisifre = "123456";

            if (kullaniciAdi == veritabanindakiKullaniciAdi && sifre == veritabanindakisifre)
            {
                Console.WriteLine("Giriş Başarılı.");
                
            }
            else
            {
                Console.WriteLine("Kullanıcı adı ve ya şifre hatalı !");
                
            }
            


            Console.Read();
        }
    }
}
