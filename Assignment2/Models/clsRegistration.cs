using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class clsRegistration
    {
        public virtual int StudentId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual int Age { get; set; }
        public virtual string Gender { get; set; }
        public virtual string Adress { get; set; }
    }
}