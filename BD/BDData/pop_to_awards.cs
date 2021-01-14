using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class pop_to_awards
    {
        public int Number { get; set; }

        public int AwardsId { get; set; }

        public int POPId { get; set; }

        public pop_to_awards(int number, int awardsid, int popid)
        {
            Number = number;
            AwardsId = awardsid;
            POPId = popid;
        }
    }
}
