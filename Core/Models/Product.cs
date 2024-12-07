using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public string ISBN { get; set; }

        public Product(string name, double price, string isbn)
        {
            Name = name;
            Price = price;
            ISBN = isbn;
        }

    }
}
