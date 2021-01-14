using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class doctors
    {
        public int Id { get; }

        public string Name { get; set; }

        public int Rating { get; set; }
        public string Telephone_Number { get; set; }

        public doctors(int id, string name, int rating, string telephone_number)
        {
            Id = id;
            Name = name;
            Rating = rating;
            Telephone_Number = telephone_number;
        }
    }
}
