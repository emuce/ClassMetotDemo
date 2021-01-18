using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) {
            Console.WriteLine("\n{0} {1} isimli müşteri {2} id numarasıyla sisteme eklenmiştir.",musteri.Adi.ToUpper(),musteri.Soyadi.ToUpper(),musteri.Id);
        }
        public bool Sil(Musteri musteri) {
            if (musteri.Id>=0)
            {
                Console.WriteLine("\n{0} {1} isimli müşteri sistemden silinmiştir.", musteri.Adi.ToUpper(), musteri.Soyadi.ToUpper());
                return true;
            }
            else
            {
                Console.WriteLine("\nböyle bir müşterimiz bulunmamaktadır!!!");
                return false;
            }
        }
        public void Listele(Musteri[] musteriler) {
            if (musteriler.Length!=0)
            {
                Console.WriteLine("\n-----Müşreti Listesi-----");
                Console.WriteLine("ID\tAdı\tSoyadı\n");
                foreach (var musteri in musteriler)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", musteri.Id, musteri.Adi.ToUpper(), musteri.Soyadi.ToUpper());
                }
            }
            else
                Console.WriteLine("\nMüşteri listesi boş!!!");
        }
    }
}
