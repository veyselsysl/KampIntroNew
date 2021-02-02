using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "veysel", "murat", "kerem", "halil" };

            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);
            //isimler[4] = "ilker";
            //console.writeline(isimler[4]);

            List<string> isimler2 = new List<string>();
            isimler2.Add("Veysel");
            isimler2.Add("2");
            isimler2.Add("3");
            isimler2.Add("4");
            isimler2.Add("5");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Ali");
            isimler2.Add("Veli");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[1]);
        }
    }
}
