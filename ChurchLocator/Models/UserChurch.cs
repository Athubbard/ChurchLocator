using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchLocator.Models
{
    public class UserChurch
    {
        public int ChurchID { get; set; }
        public Church Church { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
