using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Module
    {
        public virtual int CourseId { get; set; }
        [Key] [Required]
        public virtual int ModuleId { get; set; }

        public virtual string ModuleName { get; set; }
        
        public virtual string ModuleDescription { get; set; }
       
        public virtual string ModuleCode { get; set; }

        

    }
}