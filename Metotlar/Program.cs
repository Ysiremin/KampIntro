using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = "Elma";
            double diyati1 = 15;
            string aciklama1 = "Amasya Elması";

            string[] meyveler = new string[] { "Elmas", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmas";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 67;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("------------Metotlar--------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "İyi armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 7);

        }
    }
}
