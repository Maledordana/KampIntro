using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //bu 2 satırda program hata verecektir.
            //out of range hatası alırsın
            //bu da ilk tanımladığın anda kaç eleman verdiysen ondan fazlası
            //için sana hata veriyor olur

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //ilkeri burda okur ama 0'ı okuyamaz
            //çünkü her new dediğinde yeni bir array tanımlamış olursun
            //ve bu arrayin 4. elemanı ilker ama diğerleri boş


            //list yokken ampule tıkla generic'i ekle
            List<string> isimler2 = new List<string> { "Engin","Murat",
            "Kerem","Halil"};
            //birinci seçenek bu ikincisi için süslü parantez
            //isimler2.Add("Engin");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
