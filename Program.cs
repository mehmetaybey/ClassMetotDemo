using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Gokhan";
            musteri1.Soyadi = "Yeşilyurt";
            musteri1.DogumTarihi = "1989";
            musteri1.Meslek = "Tornacı";
            musteri1.Faiz = 1.40;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Aybey";
            musteri2.DogumTarihi = "1989";
            musteri2.Meslek = "işsiz";
            musteri2.Faiz = 3.20;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Aşkın";
            musteri3.Soyadi = "Küçükdeniz";
            musteri3.DogumTarihi = "1992";
            musteri3.Meslek = "planlama";
            musteri3.Faiz = 1.21;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2,musteri3};
            foreach (Musteri musteri in musteriler) 
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.DogumTarihi);
                Console.WriteLine(musteri.Meslek);
                Console.WriteLine(musteri.Faiz);
                
            }

            Console.WriteLine("-----MusteriManager-----");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.FaizArttirildi(musteri2);
            musteriManager.FaizDusuruldu(musteri3);
            musteriManager.Sil(musteri2);

        }
    }
}
