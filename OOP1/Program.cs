using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            //ilk ürünü tanımlamış olduk
            product1.Id = 1;
            product1.CategoryId = 2;
            //2 katogorisi mobilya olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //ikinci oluşturma yolu
            Product product2 = new Product {Id = 2, CategoryId=5, 
                UnitInStock=5, ProductName="Kalem", UnitPrice=35};

            //PascalCase  //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);

            //REFENRANS TİPLER
            //int sayi = 100;
            //productManager.Yap(sayi);
            //Console.WriteLine(sayi);

            //productManager.Yap2(product1);
            //Console.WriteLine(product1.ProductName);

            //RETURN İŞLEVİ
            //productManager.Topla2(3, 6);

            //bak operasyon sonucunu tutabilmiş olduk ve farklı işlem yapabildik de
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);

        }
    }
}
