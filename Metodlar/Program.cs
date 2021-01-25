using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Urun urun1 = new Urun();
            //Class örneği(?) mi oluyor
            //urun tipinde urun1 tanımlamış olduk
            //Bunu tanımlamadan işlem yapamazsın malesef ki

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type, isimlendirme
            //ürün array i oluşturmuş olduk (dizisi)

            foreach (Urun urun in urunler)
            //ilk yazılan urun veri tipidir. var da yapsan olur, var tek tek dolaşırken yakalıyo
            //ikinci yazılan uruno anki döndüğü elemanı gösterir, alyas, takma isim
            //in urunler = her urunler elemanını tek tek gez
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("------Metodlar---------");
            //instance - class örneği oluşturuyoruz şuan
            SepetManager sepetManager = new SepetManager();
            //metodu çağırmış olduk
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //sepetManager.Ekle2("Armut", "Devece", "12");
            //3 tane bilgiyi yazmış olduk buranın içine
        }
    }
}



//DRY - Clean code - Best practice