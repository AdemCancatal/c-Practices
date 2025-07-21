using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bilgisayar rastgele bir sayi tutacak ve onu tahmin etmeye calisacaksiniz ve yalnizca 3 hakkiniz var...");
            Console.ReadLine();
            Random rnd = new Random();
            int randomsayi = rnd.Next();



            int SecilenSayi;

            for (int i = 3; i > 0; i--)
            {

                Console.WriteLine("Lutfen tahmin ettiginiz sayiyi giriniz :");
                SecilenSayi =Convert.ToInt32(Console.ReadLine());

                if (SecilenSayi == randomsayi)
                {
                    Console.WriteLine("Tebrikler dogru bildiniz.");
                }
                else
                {
                    Console.WriteLine("Yanlis bildiniz.");
                }
            }
            Console.WriteLine("Tahmin hakkinniz bitti, dogru cevap " + randomsayi + " idi.");

            Console.ReadLine();




        }
    }
}
