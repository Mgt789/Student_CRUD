using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Models
{
    public class Student
    {
        [Key]
        public int Stud_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Range(18,30,ErrorMessage ="Age is must between 18 to 30")]
        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Course { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

    }
}
