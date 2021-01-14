using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class places_of_pain
    {
        public int Id { get; }

        public string Name { get; set; }

        public places_of_pain(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }


}
