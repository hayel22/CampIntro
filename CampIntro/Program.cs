using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            //Do not repeat yorself = Kendini tekrarlama
            //değer tutucu ,alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı = true;
            double dolarnDun =7.35;
            double dolarBugun = 7.45;

            if (dolarnDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }

            else if (dolarnDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("degişmedi butonu");
            }
            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
        
    }
}
