using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Models
{
    public class Instructor
    {
        [Key]
        public int instructor_id { get; set; }

        [Required]
        [StringLength(50)]
        public string instructor_name { get; set; }
    }
}
