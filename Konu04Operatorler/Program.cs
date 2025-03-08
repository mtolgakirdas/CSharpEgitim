﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu04Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ** Operatörler
            Console.WriteLine("1-) Aritmetik Operatörler( +, -, *, /, ½, ++, --,)");

            int a = 50;
            int b = 20;
            int c = 30;

            int sonuc = a + b;
            int sonuc1 = a - b;
            int sonuc2 = a * b;
            float sonuc3 =(float)a / (float)b;//casting(Dönüşüm) örneği
            int sonuc4 =a % b;
            c--;
            int sonuc5 = c;
            a++ ;
            int sonuc6 = a;

            Console.WriteLine("a + b = " + sonuc);
            Console.WriteLine("a - b = " + sonuc1);
            Console.WriteLine("a * b = " + sonuc2);
            Console.WriteLine("a / b = " + sonuc3);
            Console.WriteLine("a % b = " + sonuc4);
            Console.WriteLine("c -- = " + sonuc5);
            Console.WriteLine("a ++ = \n" + sonuc6);




            Console.WriteLine("2 -) Atama Operatörleri(=,+=,-=,*=,/=,%=)");
            Console.WriteLine(a += b);
            Console.WriteLine(a =a+ b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);
            Console.WriteLine(a /= b);
            Console.WriteLine(a %= b);




            Console.WriteLine("3-) ilişkisel Operatörleri(==,!=,<,>,<=,>=,?:)");

            Console.WriteLine(a == b);//a , b ye eşit mi
            Console.WriteLine(a != b);//a , b ye eşit değil mi
            Console.WriteLine(a > b);//a , b den büyük mü
            Console.WriteLine(a < b);//a , b den küçük mü
            Console.WriteLine(a <= b);//a , b den küçük veya eşit mi
            Console.WriteLine(a >= b);//a , b den büyük veya eşit mi

            string sonuc7 = (a == b) ? "a b ye eşit" : "a, b ye eşit değil\n";
            Console.WriteLine(sonuc7);

            Console.WriteLine("4-) Mantıksal Operatörler (%% ,||,!)");

            //&& (and - ve)
            //true && true = true
            //true && false = false

            Console.WriteLine((a > b) && (a > c));//a b den büyükse ve a c den büyükse

            // || (or - veya)
            Console.WriteLine((a > b) && (a > c));//a b den büyükse veya a c den büyükse

            // ! (not - değil)
            bool sonuc8 = !(a > b);
            Console.WriteLine("Sonuç : "+ sonuc8);
            Console.Read();
        }
    }
}
