using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        //REFERANS TİPLER
        //public int Yap(int sayi)
        //{
        //    sayi = 99;
        //}

        //public void Yap2(Product product)
        //{
        //    product.ProductName = "Kamera";
        //}


        //RETURN İŞLEVİ
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public int Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

    }
}
