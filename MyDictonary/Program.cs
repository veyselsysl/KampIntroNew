using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonary<string> dictonaries = new Dictonary<string>();
            dictonaries.Add("Adidas");
            Console.WriteLine(dictonaries.Length);
            dictonaries.Add("Nike");
            Console.WriteLine(dictonaries.Length);

            foreach (var dictonary in dictonaries.GetJ)
            {
                Console.WriteLine(dictonary);
            }
        }
    }
}
