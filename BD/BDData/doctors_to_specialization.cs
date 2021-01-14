using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class doctors_to_specialization
    {
        public int Id { get; }

        public int DoctorsId { get; set; }

        public int SpecializationsId { get; set; }

        public doctors_to_specialization(int id, int doctorsid, int specializationsid)
        {
            Id = id;
            DoctorsId = doctorsid;
            SpecializationsId = specializationsid;
        }
    }
}
