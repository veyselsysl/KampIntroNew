﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediBaseManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı..");
        }
        //İnterfaceleri, birbirinin alternatifi olan kod içerikleri farklı olan durumlar için kullanırız..
    }
}
