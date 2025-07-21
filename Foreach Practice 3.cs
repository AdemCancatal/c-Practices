using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = { "Ahmet", " Mehmet", "Ayse", "Hasan", "Ahmet" };
            Console.WriteLine("Hangi ismi aramak istiyorsunuz :");
            string isim = Console.ReadLine();

            int sayac = 0;


            foreach (string i in isimler)
            {
                  if (isim == i)
                {
                    sayac++; 
                }

            }
            Console.WriteLine(isim + " isimli kisinin adi bu listede "+ sayac + " kere geciyor.");

        }
    }
}
