using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı: "+musteri.Name + "\n Müşteri ID: "+ musteri.ID);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname);
            }

        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" "+musteri.Surname + " elemanı silindi!");
        }
    }
}
