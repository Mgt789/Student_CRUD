using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Models
{
    public class Enrolment
    {
        [Key]
        public int Enrolment_id { get; set; }

        public DateTime Date{ get; set; }
    }
}
