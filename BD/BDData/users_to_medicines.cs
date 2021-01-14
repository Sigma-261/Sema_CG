using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class users_to_medicines
    {
        public int Id { get; set; }

        public int UsersId { get; set; }

        public int MedicinesId { get; set; }

        public users_to_medicines(int id, int usereid, int medicinesid)
        {
            Id = id;
            UsersId = usereid;
            MedicinesId = medicinesid;
        }
    }
}
