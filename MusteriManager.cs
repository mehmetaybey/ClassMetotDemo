using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : " + musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.Adi);
        }
        
        public  void FaizArttirildi(Musteri musteri)
        {
            Console.WriteLine("Faiz arttırıldı  : " + musteri.Meslek);
        }

        public void FaizDusuruldu(Musteri musteri)
        {
            Console.WriteLine("Faiz düşürüldü : " + musteri.Meslek);
        }
    }
}
