using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class external_conditions_meaning
    {
        public int Id { get; }

        public int Numerical_Value { get; set; }

        public string Character_Value { get; set; }

        public int UserId { get; set; }

        public external_conditions_meaning(int id, int numerical_value, string character_value, int userid)
        {
            Id = id;
            Numerical_Value = numerical_value;
            Character_Value = character_value;
            UserId = userid;
        }
    }
}
