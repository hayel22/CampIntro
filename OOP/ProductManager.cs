using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductManager
    {
        //encapsulation
        //product değeinde değer ver
        public void Add(Product product)//101
        {
            Console.WriteLine(product.ProductName+"Eklendi");

        }
         public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }

        
    }
}
