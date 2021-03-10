using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace systemRes.Models
{
    public class reservation
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
        public string cause { get; set; }


    }
}
