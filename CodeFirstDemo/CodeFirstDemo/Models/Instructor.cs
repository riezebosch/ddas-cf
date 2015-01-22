using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstDemo.Models
{
    public class Instructor : Person
    {
        public Instructor()
        {
            this.Courses = new List<Course>();
        }
        public Nullable<System.DateTime> HireDate { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
