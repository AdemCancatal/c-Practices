using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lutfen bir sayi giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            sayi = ((sayi * (sayi + 1)) / 2);

            Console.WriteLine("Girdiginiz sayiya kadfar olan sayilarin toplami :" + sayi);

            Console.ReadLine();


        }
    }
}
