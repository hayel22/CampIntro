using System;

namespace DegerVeReferanstipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int decimal float double bool= değer tip
            //array clss interface= referans tip
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = = new int[] { 100, 200, 300 };
            sayilar2[0] = 999;
        }
    }
}
