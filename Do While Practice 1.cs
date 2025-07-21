using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0; 
            // ekrana yazdiracagimiz sayilari tutacak olan int tipi degisken.

            do // do while dongusu ile 0'dan baslayip cift sayilara artacak olan bir dongu yazdik 
            {
                Console.WriteLine(sayi); // ilk yazilacak sayi 0 oldugu icin ilk once console.writeline komutu ile ekrana sayiyi yazdirdik .
                sayi += 2; // Daha sonra cift sayilarla ilerlenmesi icin degiskenimizi ikiser arttiran komutu yazdik.

            } while (sayi <= 100); // dongunun 100'e geldiginde durmasini kontrol eden dongu kosulumuz.


            Console.ReadLine();

        }
    }
}
