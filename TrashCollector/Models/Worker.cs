using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Worker
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public int AddressID { get; set; }
        [ForeignKey("Address")]
        public virtual Address Address { get; set; }


    }
}