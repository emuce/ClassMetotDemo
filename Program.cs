using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri01 = new Musteri();
            musteri01.Id = 0;
            musteri01.Adi = "Rıfat";
            musteri01.Soyadi = "Ilgaz";
            Musteri musteri02 = new Musteri();
            musteri02.Id = 1;
            musteri02.Adi = "Nazım";
            musteri02.Soyadi = "Hikmet";
            Musteri musteri03 = new Musteri();
            musteri03.Id = 2;
            musteri03.Adi = "Ziya";
            musteri03.Soyadi = "Gökalp";
            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri01, musteri02, musteri03 };
            musteriManager.Ekle(musteri01);
            musteriManager.Ekle(musteri02);
            musteriManager.Ekle(musteri03);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri03);

        }
    }
}
