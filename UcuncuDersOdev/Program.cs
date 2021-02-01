using System;

namespace UcuncuDersOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.M_Id = 123;
                musteri1.M_Adi = "Veysel";
                musteri1.M_Soyadi = "SOYSAL";
            }
            Musteri musteri2 = new Musteri();
            {
                musteri2.M_Id = 234;
                musteri2.M_Adi = "Uysal";
                musteri2.M_Soyadi = "SOSYAL";
            }
            Musteri musteri3 = new Musteri();
            {
                musteri3.M_Id = 567;
                musteri3.M_Adi = "John";
                musteri3.M_Soyadi = "UYSAL";
            }
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.M_Liste(musteri);
            }

            musteriManager.M_Sil(musteri2);
        }
    }
}
