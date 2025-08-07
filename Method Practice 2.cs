using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanicidan alinan sayinin tek mi cift mi oldugunu bulan metod kullanan uygulama yazalim.

            Console.WriteLine("Lutfen bir sayi giriniz :");
            // Kullanicidan bir deger girmesini istedik.
            int sayi = int.Parse(Console.ReadLine());
            // Kullanicinin girdigi degeri integer'a donusturup "sayi" degiskeninin icine atadik.

            TekCift(sayi);
            // Kullanicinin girdigi degeri methodumuza parametre olarak atadik.

            Console.ReadLine();
        } 


        static void TekCift (int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Girdiginiz sayi cifttir.");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi tektir.");
            }
            // Sayinin tek mi cift mi oldugunu kontrol eden if-else yapisi.

        }
    }
}
