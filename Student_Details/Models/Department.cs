using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Models
{
    public class Department
    {
        [Key]
        public int Department_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Department_Name { get; set; }
    }
}
