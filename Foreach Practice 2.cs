using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen bir bir string deger giriniz :");
            string deger = Console.ReadLine();

            char[] charList = deger.ToCharArray();

            foreach (char c in charList)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();

        }
    }
}
