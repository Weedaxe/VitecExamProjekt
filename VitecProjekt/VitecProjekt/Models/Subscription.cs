using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecProjekt.Models
{
    public class Subscription
    {
        public int SubID { get; set; }
        public Package package { get; set; }
        //public virtual ICollection<string> Options { get; set; }

    }
}
