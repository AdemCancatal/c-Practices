using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Odev_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayi giriniz");   
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sayac = 0;


            for (int i = 2;  i <= sayi; i++)
            {
                if (sayi/i == 0)
                {
                    sayac++;
                }
            }

            if (sayac == 2)
            {
                Console.WriteLine(sayi + " asal sayidir.");
            }
            else if (sayac > 2) 
            {
                Console.WriteLine(sayi + " asal degildir.");
            }


            Console.ReadLine();

        }
    }
}
