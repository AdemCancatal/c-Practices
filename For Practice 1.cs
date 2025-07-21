using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] sayilar = new int [5,5];
            int sayi1 = 1;
            int sayi2 = 0;
            int sayi3 = 9;
            
            for (int i = 0; i < 5;  i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        sayilar [i,j] = sayi1;
                        sayi1++;
                    }

                    else if (i < j)
                    {
                        sayilar[i,j] = sayi2;
                    }

                   else 
                    {
                        sayilar[i,j] = sayi3;
                        sayi3--;
                    }

                  
                }
            }


            for (int i = 0;i < 5;i++)
            {
                for (int j = 0;j < 5;j++)
                {
                    Console.Write(sayilar[i,j] + "\t");
                }
                 Console.WriteLine();
            }

            Console.ReadLine ();

        }
    }
}
