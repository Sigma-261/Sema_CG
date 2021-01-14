using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class roles
    {
        public int Id { get; }

        public string Name { get; set; }


        public roles(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
