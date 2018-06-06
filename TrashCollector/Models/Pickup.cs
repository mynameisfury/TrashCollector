using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Pickup
    {
        [Key]
        public int ID { get; set; }
        public DateTime PickupDate { get; set; }
        public int CustomerID { get; set; }
        public int WorkerID { get; set; }
        public bool Complete { get; set; }

    }
}