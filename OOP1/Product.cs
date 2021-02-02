using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //CRUD operasyonları
        //C|reat
        //R|ead
        //U|pdate
        //D|elete
        //Bunları gerçekleştirebilmek için farklı classlar gerekir.
    }
}
