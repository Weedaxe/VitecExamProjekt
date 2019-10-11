using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecProjekt.Models
{
    public class User
    {
        public int UserID { get; set; }
        ICollection<Subscription> subscriptions { get; set; }
    }
}
