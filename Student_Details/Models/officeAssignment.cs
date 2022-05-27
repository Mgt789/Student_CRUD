using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Models
{
    public class officeAssignment
    {
        [Key]
        public int officeAssignment_id { get; set; }

        [Required]
        [StringLength(50)]
        public string officeAssignment_name { get; set; }
    }
}
