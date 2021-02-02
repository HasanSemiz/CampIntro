using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hasan Semiz";
            kurs1.IzlenmeOrani = "36";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = "64";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = "73";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            
            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.KursAdi + ":" + Kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }
    }
}
