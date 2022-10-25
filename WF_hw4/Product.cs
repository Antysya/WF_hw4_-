using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_hw4
{
    public class Product
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public double Cost { get; set; }

        public Product(){}

        public Product(string name, string country, double cost)
        {
            Name = name;
            Country = country;
            Cost = cost;
        }
        
        public override string ToString()
        {
            return $"Название товара: {Name}, Страна производитель: {Country}, Стоимость: {Cost} ";
        }
    }
}
