using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lutfen bir sayi giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            int i = 0;
            int f = 0;

            do
            {
                f = (i - 1) + (i - 2);
                Console.WriteLine(f);

                i++;
                f = 0;
                sayac++; 
            } while (sayac != sayi);


            Console.ReadLine();


        }
    }
}
