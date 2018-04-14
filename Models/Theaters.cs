using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2_Part2.Models
{
    [Table("Theaters")]
    public class Theaters
    {
        public Theaters()
        {

        }
        [Key]
        public string Theater_id { get; set; }
        [Required]
        public string TheaterName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

    }
}
