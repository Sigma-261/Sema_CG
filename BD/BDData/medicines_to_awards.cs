using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class medicines_to_awards
    {
        public int Number { get; set; }

        public int AwardsId { get; set; }

        public int MedicinesId { get; set; }

        public medicines_to_awards(int number, int awardsid, int medicinesid)
        {
            Number = number;
            AwardsId = awardsid;
            MedicinesId = medicinesid;
        }
    }
}
