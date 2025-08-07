using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen iki sayidan hangisinin buyuk oldugunu bulan bir uygulama yazalim

            Console.WriteLine("Lutfen birinci sayiyi giriniz :");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen ikinci sayiyi giriniz :");
            int sayi2 = int.Parse(Console.ReadLine());
            // Kullanicidan iki deger girmesini istedik.
            // Kullanicidan girilen degerleri "sayi1" ve "sayi2" degiskenlerine atadik

            BuyukKucuk(sayi1,sayi2);
            // Kullanicidan girilen degerleri BuyukKucuk metodumuzun icine atadik.


            Console.ReadLine();
        }

        static void BuyukKucuk ( int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Ilk sayi ikincisinden buyuktur.");
            }
            else if (sayi1 < sayi2) 
            {
                Console.WriteLine("Ikinci sayi birinci sayidan buyuktur.");
            }
            else 
            {
                Console.WriteLine(" Girdiginiz sayilar esittir.");
            }
        }
    }
}
