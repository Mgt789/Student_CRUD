using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Models
{
    public class courseAssignment
    {
        [Key]
        public int courseAssignment_id { get; set; }

        [Required]
        [StringLength(50)]
        public string courseAssignment_name { get; set; }
    }
}
