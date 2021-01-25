using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //sepete ürün ekleme işlemi
        //naming convention
        public void Ekle(Urun urun)
            //parantez içindekilerin ilki tipi, ikincisi isimlendirmesi

        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        //public void Ekle2(string urunAdi, string aciklama, double fiyat)
        //böyle de yazabilirdik anlamına geliyor
        //peki neden böyle yazdık
        //çünkü yeni parametre gelirse stoktaki adet gibi 
        //programda imzaya uymuyor oldun
        //tüm program hata vermiş olacak
        //{
        //    Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        //}



    }
}
