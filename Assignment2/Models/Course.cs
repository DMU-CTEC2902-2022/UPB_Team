using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        [Required]
        public virtual string CourseName { get; set; }
        [StringLength(50)]
        public virtual string CourseDescription { get; set; }
     

    } 

    
}