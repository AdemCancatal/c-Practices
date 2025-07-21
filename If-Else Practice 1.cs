using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Birazdan ders notlarinizi gireceksiniz..");
            Console.ReadLine();

            Console.WriteLine("Lutfen Matematik notunuzu giriniz :");
            int Matematik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lutfen Fizik notunuzu giriniz :");
            int Fizik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lutfen Turkce notunuzu giriniz :");
            int Turkce = Convert.ToInt32(Console.ReadLine());

            int ortalama = (Matematik + Fizik + Turkce) / 3;

            if (ortalama >= 85)
            {
                Console.WriteLine("Takdir belgesi aldiniz...");
            }
            else if ((ortalama >= 70) && (ortalama <= 84))
            {
                Console.WriteLine("Tesekkur belgesi aldiniz...");
            }
            else if ((ortalama >= 50) && (ortalama <= 69))
            {
                Console.WriteLine("Duz gectiniz...");
            }
            else
            {
                Console.WriteLine("Kaldiniz");
            }


                Console.WriteLine("");

        }
    }
}
