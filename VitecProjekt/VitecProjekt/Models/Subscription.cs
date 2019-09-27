using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VitecProjekt.Models
{
    public enum SubscriptionType : byte
    {
        basic,
        silver,
        gold
    }
    public class Subscription
    {
        SubscriptionType Type { get; set; }

        decimal price { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public decimal LoyaltyDiscount { get; set; }

        public int DeviceLimit { get; set; }
    }
}
