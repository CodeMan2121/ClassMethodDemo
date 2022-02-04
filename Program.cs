using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Name = "Cebrail";
            musteri1.Surname = "Meşe";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Name = "Mikail";
            musteri2.Surname = "Aslan";


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);
            musteriManager.Silme(musteri2);
        }

        
    }
}
