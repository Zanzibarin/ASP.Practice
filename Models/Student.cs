using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.FinalProject.Models
{
    public class Student

    {
        public virtual string StudentId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string PaternalName { get; set; }
        public virtual string LastlName { get; set; }
        public virtual string CourcelHead { get; set; }
        public virtual string Grade { get; set; }
    }
}