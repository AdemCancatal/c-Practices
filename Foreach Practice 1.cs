using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class ForeachPractice_1
    {
        static void Main(string[] args)
        {

            string[] hayvanlar = { "Kedi", "Balik", "Kopek", "Aslan" };

            foreach (string s in hayvanlar)
            {
                Console.WriteLine("Hayvanlar " + s);
            }

            // ilk once "hayvan" ifadesini tutan bir string deger olusturdum ve bunu dizinin her bir elemaninin basina yazdirmaya calistim ama ise yaramadi.
            // Console.Writeline(); komutunu kullanarak her bir degerin basina "hayvan" ifadesini teker teker yazdirdim ve ekrana ciktisini yazdirdim.


        }
    }
}
