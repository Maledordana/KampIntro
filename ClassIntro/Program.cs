using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            //kurs1 yaz ve nokta koy
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Kerem Demiroğ";
            kurs2.IzlenmeOrani = 78;


            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Phyton";
            kurs3.Egitmen = "Eren Demiroğ";
            kurs3.IzlenmeOrani = 83;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};
            //new kurs yazdığın için içinde kurs değişlenlerini tutabilirsin, önceden tanımladığın
            //new string değerinde sadece metin tutabilirdin. şimdi artık kurs objesi tutuluyor

            foreach (var kurs in kurslar)
            {
                //Console.WriteLine(kurs.kursAdi);
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
        
    {
        //prop tab tab
        public string Egitmen { get; set; }
        public string kursAdi { get; set; }
        public int IzlenmeOrani { get; set; }
        //type tanımlanmış oldu

    }
}
