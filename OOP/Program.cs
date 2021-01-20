using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,
                UnitStock=5,ProductName="Kalem",UnitPrice= 35};

            //sayısallar değer tip
            //ref out keywordleri
            //int double bool decimal...değer tip
            //dizler class abstractclass interface referans tip
            //PascalCase   //camelCase
            //case senstıve küçük büyük harf önenmi isimlendirme
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



        }
    }
}
