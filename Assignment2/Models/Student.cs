using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Student
    {
        [Key] [Required]
        public virtual int StudentId { get; set; }

        public virtual string StudentName { get; set; }
       
        public virtual string ModuleCode { get; set; }

        

    }
}