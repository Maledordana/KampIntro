using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            //değişkenlerle bu kurs sayılarını tanımlamak yerine diziler kullanılır
            //array = dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "programlamaya başlangıç için temel kurs",
                "Java", "Phyton"};

            //for döngüsü
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //foreach döngüsü, foreach sadece dizilere uygulanır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
