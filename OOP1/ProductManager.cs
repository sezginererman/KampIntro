using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        //void ne demek?
        //işlem bittiğinde ne olduğunu bilmeme gerek yoksa void kullanabilirsin
        //ama sana yapılan işlem sonucu sana lazımsa /return kullanman lazım.

        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "eklendi.");   
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

    }
}
