using System;
using System.Collections.Generic;
using System.Text;

namespace UcuncuDersOdev
{
    class MusteriManager
    {
        public void M_Ekle(Musteri musteri)
        {
            
        }
        public void M_Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri : " + musteri.M_Adi +" "+musteri.M_Soyadi);
        }
        public void M_Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.M_Adi + " " + musteri.M_Soyadi + " isimli müşteri silinecek ? Evet/Hayır");
            string onay;
            onay = Console.ReadLine();
            if (onay == "evet")
            {
                
                Console.WriteLine(musteri.M_Adi +" "+ musteri.M_Soyadi+" isimli müşteri silinmiştir.." );
            }
            else if (onay == "hayır")
            {
                Console.WriteLine(musteri.M_Adi + " " + musteri.M_Soyadi + " isimli müşteri silme işlem iptal");
            }
            else
            {
                Console.WriteLine("Seçim Yapılamadı Sayfayı terkediniz");
            }
            Console.ReadKey();
        }
    }
}
