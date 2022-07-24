using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari
{
    class Program
    {
        static Random rastgele = new Random();
        static void Main(string[] args)
        {
            int tahmin, sayi = rastgele.Next(100);

            while (true)
            {
                Console.WriteLine("Bir Sayi Giriniz.");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin>sayi)
                {
                    Console.WriteLine("Daha Küçük Bir Sayi Giriniz");
                }
                else if (tahmin<sayi)
                {
                    Console.WriteLine("Daha Büyük Bir Sayi Giriniz.");
                }
                else
                {
                    Console.WriteLine("Tebrikler Bildiniz.");
                }
                Console.ReadKey();
            }
        }
    }
}
