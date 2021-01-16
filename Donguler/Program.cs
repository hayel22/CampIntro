using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştime kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "python";

            //aray - dizi

            string[] kurslar = new string[] { "Yazılım geliştime kampı",
           "programlamaya başlangıç için temel kurs","Java","python" };

            for (int i =0; i<kurslar.Length;i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}