using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class Dictonary<J>
    {
        J[] item;
        public Dictonary()
        {
            item = new J[0];
        }
        public void Add(J product)
        {
            J[] tempArray =  item;
            item = new J[item.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                item[i] = tempArray[i];
            }
            item[item.Length-1] = product;
        }
        public int Length 
        {
            get { return item.Length; }
        }
        public J[] GetJ 
        {
            get { return item; }
        }
    }
}
