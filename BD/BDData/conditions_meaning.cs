using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class conditions_meaning
    {
        public int Id { get; }

        public string Name { get; set; }

        public int Ex_Con_MeanId { get; set; }

        public conditions_meaning(int id, string name, int ex_con_meanId)
        {
            Id = id;
            Name = name;
            Ex_Con_MeanId = ex_con_meanId;
        }
    }
}
