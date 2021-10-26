using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDT1721050486.Models
{
    public class Person
    {
        [Key]
        [StringLength(20)]
        public string PersonID { get; set; }
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}