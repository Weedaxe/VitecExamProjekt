using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitecProjekt.Models
{
    public class Customer
    {
        public int ID { get; set; }

        User Master { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; }

        public Subscription Subscription { get; set; }

        public ICollection<User> Users { get; set; }

        public Customer(string Username, string Password, string FirstName, string LastName, string Email)
        {
            Users = new List<User>();
            Master = new User() { Username = Username, Password = Password, LastName = LastName, FirstName = FirstName, Email = Email};
            Users.Add(Master);
        }
    }
}
