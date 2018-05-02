using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class ZipCodes
    {
        [Key]
        public int ID { get; set; }
        public int ZipCode { get; set; }
    }
}