using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();           //BU ŞEKİLDE YAZMAK DA UYGUNDUR.
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();              //BU ŞEKİLDE YAZMAK DA UYGUNDUR.
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);
            basvuruManager.BasvuruYap(tasitKrediManager,  databaseLoggerService);
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);


            //*** INTERFACELER DE CLASSLAR GİBİ INHARETANCE EDİLEBİLİR... *** 

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
