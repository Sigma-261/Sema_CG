using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Medicines
    {
        public int Id { get; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public float Price { get; set; }

        public Medicines(int id, string name, int rating, float price)
        {
            Id = id;
            Name = name;
            Rating = rating;
            Price = price;
        }
    }
}
