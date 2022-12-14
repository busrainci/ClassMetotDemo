// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Isim = "Buğlem";
musteri1.Soyisim = "İnci";
musteri1.bakiye = 100000;
musteri1.Aciklama = "A bankası müşterisi";

Musteri musteri2 = new Musteri();
musteri2.Isim = "Deniz";
musteri2.Soyisim = "Emir";
musteri2.bakiye = 4000;
musteri2.Aciklama = "A bankası müşterisi";

Musteri musteri3 = new Musteri();
musteri3.Isim = "Kartal";
musteri3.Soyisim = "Ulutürk";
musteri3.bakiye = 5000;
musteri3.Aciklama = "A bankası müşterisi";

Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

foreach (Musteri m in musteriler)
{
    Console.WriteLine(m.Isim);
    Console.WriteLine(m.Soyisim);
    Console.WriteLine(m.bakiye);
    Console.WriteLine(m.Aciklama);
    Console.WriteLine("---------------");
}

MusteriManager musteri = new MusteriManager();
musteri.Yukle(musteri1);
musteri.Yukle(musteri2);
musteri.Yukle(musteri3);


