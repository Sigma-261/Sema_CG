using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class doctor_to_awards
    {
        public int Number { get; set; }

        public int AwardsId { get; set; }

        public int DoctorsId { get; set; }

        public doctor_to_awards(int number, int awardsid, int doctorsid)
        {
            Number = number;
            AwardsId = awardsid;
            DoctorsId = doctorsid;
        }
    }
}
