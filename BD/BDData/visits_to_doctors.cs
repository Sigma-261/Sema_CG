using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class visits_to_doctors
    {
        public int Id { get; set; }

        public int UsersId { get; set; }

        public int DoctorsId { get; set; }

        public visits_to_doctors(int id, int usereid, int doctorsid)
        {
            Id = id;
            UsersId = usereid;
            DoctorsId = doctorsid;
        }
    }
}
