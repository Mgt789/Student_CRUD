using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Models
{
    public class Course
    {
        [Key]
        public int Course_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Course_Name { get; set; }

        [Required]
        public int Course_fee { get; set; }

    }
}
