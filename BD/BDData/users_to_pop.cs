using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class users_to_pop
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        public int UsersId { get; set; }

        public int PlaceId { get; set; }

        public users_to_pop(int id, int degree, int usereid, int placeId)
        {
            Id = id;
            Degree = degree;
            UsersId = usereid;
            PlaceId = placeId;
        }
    }
}
