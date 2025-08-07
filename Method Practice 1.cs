using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Method_Practice_1
    {

        static void Main(string[] args)
        {

            // Girilen sayinin karesini metod kullanarak alan ve 50'den buyuk olup olmadigini kontrol eden bir uygulama yazalim yazalim.

            Console.WriteLine("Lutfen karesinii almak istediginiz sayiyi giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            // Kullanicidan bir sayi aldik ve o sayiyi once Prase metodu ile integer'a donusturduk sonra "sayi" degiskeninin icine koyduk.

            int kare = KareAl(sayi);
            // Kullanicinin girdigii degeri KareAl metodunun parametresine atadik.
            // KareAl metodundan return ile donen degeri "kare" degiskeninin icine atadik

            if (kare < 50)
            {
                Console.WriteLine("Girdiginiz sayinin karesi " + kare + "'dir ve 50'den kucuktur.");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayinin karesi " + kare + "'dir ve 50'den buyuktur");
            }
            // if-else yapisi ile sayinin buyuklugunu kontrol ettik.
        }

        static int KareAl(int a)
        {
            return (a * a);
        }


    }
}
