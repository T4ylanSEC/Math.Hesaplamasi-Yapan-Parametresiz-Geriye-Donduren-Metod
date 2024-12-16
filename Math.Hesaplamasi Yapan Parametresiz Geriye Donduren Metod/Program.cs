using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Hesaplamasi_Yapan_Parametresiz_Geriye_Donduren_Metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Üçgenin Taban Uzunluğunu Giriniz: ");
            double taban = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçgenin Yüksekliğini Giriniz: ");
            double yukseklik = Convert.ToDouble(Console.ReadLine());

            double alan = UcgenAlaniHesapla(taban, yukseklik);

            Console.WriteLine("Üçgenin Alanı: " + alan);

            Console.ReadKey();
        }

        static double UcgenAlaniHesapla(double taban, double yukseklik)
        {
            return (taban * yukseklik) / 2;
        }

    }
}