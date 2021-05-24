using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
   public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"{Username} - {Password}";
        }
    }
}
