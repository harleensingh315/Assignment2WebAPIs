using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2_Part2.Models
{
    [Table("Screens")]
    public class Screens
    {
        public Screens()
        {

        }
        [Required]
        public int Theater_id { get; set; }
        [Key]
        public  int Screen_id { get; set; }
        [Required]
        public int No_of_Seats { get; set; }
        public string Current_Movie { get; set; }
        public string ThreeD { get; set; }
    }
   

}
