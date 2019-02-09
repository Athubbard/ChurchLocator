using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchLocator.Models
{
    public class Preference
    {
        public Church Church { get; set; }
        public User User { get; set; }
        public int ID { get; set; }
    }
}
