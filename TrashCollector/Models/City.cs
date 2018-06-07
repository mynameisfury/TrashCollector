using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public string CityName { get; set; }
        public string StateID { get; set; }
        [ForeignKey("State")]
        public virtual State State { get; set; }
    }
}