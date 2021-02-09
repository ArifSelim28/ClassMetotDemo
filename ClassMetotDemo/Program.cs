using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11321234312;
            musteri1.Adi = "Arif Selim";
            musteri1.Soyadi = "Öztürk";
            musteri1.Yas = 14;
            musteri1.Sehir = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 21243143132;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Öztürk";
            musteri2.Yas = 50;
            musteri2.Sehir = "İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 34312424143;
            musteri3.Adi = "Nuri";
            musteri3.Soyadi = "Öztürk";
            musteri3.Yas = 55;
            musteri3.Sehir = "İstanbul";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 45238487243;
            musteri4.Adi = "Bedirhan";
            musteri4.Soyadi = "Öztürk";
            musteri4.Yas = 18;
            musteri4.Sehir = "İstanbul";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 52345824378;
            musteri5.Adi = "Zeynep";
            musteri5.Soyadi = "Öztürk";
            musteri5.Yas = 75;
            musteri5.Sehir = "Giresun";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);
            Console.WriteLine();

            musteriManager.MusteriListele(musteriler);
            Console.WriteLine();

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);
            musteriManager.MusteriSil(musteri5);

        }
    }
}
