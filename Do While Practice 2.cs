using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Odev_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "admin123";
            string sifre; 
            do
            {
                Console.WriteLine("Lutfen sifrenizi giriniz :");
                sifre = Console.ReadLine();

                if (sifre == password)
                {
                    Console.WriteLine("Tebrikler basarili giris yaptiniz.");
                }
                else
                {
                    Console.WriteLine("Yanlis sifre girdiniz, lutfen tekrar deneyiniz...");
                }

            } while (sifre != password);

            Console.ReadLine();

        }
    }
}
