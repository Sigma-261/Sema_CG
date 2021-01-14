using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class users_to_doctors
    {
        public int Id { get; set; }

        public int UsersId { get; set; }

        public int DoctorsId { get; set; }

        public users_to_doctors(int id, int usereid, int doctorsid)
        {
            Id = id;
            UsersId = usereid;
            DoctorsId = doctorsid;
        }
    }
}
