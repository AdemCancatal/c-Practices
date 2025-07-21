using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Birazdan bilgisayar bir 0 ile 100 arasinda bir sayi tutacak ve onu tahmin etmeye calisacaksiniz...");
            Console.ReadLine();

            Random rnd = new Random();   
            int random = rnd.Next(0,100);

            Console.WriteLine("Bilgisayar sayisini tuttu...");

            int tahmin; 
            do
            {
                Console.WriteLine("Tahmininiz :");
                tahmin =Convert.ToInt32(Console.ReadLine());

                if (tahmin == random)
                {
                    Console.WriteLine("Tebrikler dogru bildiniz...");
                }
                else if (tahmin < random)
                {
                    Console.WriteLine("Daha buyuk bir tahmin yapiniz.");
                }
                else if (tahmin > random)
                {
                    Console.WriteLine("Daha kucuk bir tayhmin yapiniz.");
                }

            } while (tahmin != random);


            Console.ReadLine(); 


        }
    }
}
