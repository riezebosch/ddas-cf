using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstDemo.Models
{
    public class Student : Person
    {
        public Student()
        {
            this.StudentGrades = new List<StudentGrade>();
        }
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }

    }
}
