﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        public string StreetAddressLine1 { get; set; }
        public string StrettAddressLine2 { get; set; }

        
        public int CityID { get; set; }
        [ForeignKey("CityID")]
        public virtual City City { get; set; }

        public int StateID { get; set; }
        [ForeignKey("StateID")]
        public virtual State State { get; set; }

        public int ZipCode { get; set; }
    }
}