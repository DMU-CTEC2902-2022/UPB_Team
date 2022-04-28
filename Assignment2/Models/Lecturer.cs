using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Lecturer
    {
        [Key]
        [Required]
        public virtual int LecturertId { get; set; }

        public virtual string LecturerName { get; set; }

        public virtual string ModuleCode { get; set; }



    }
}