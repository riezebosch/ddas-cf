using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CodeFirstDemo.Models.Mapping
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.Property(t => t.EnrollmentDate).HasColumnName("EnrollmentDate");

            this.Map(m => m.Requires(t => t.EnrollmentDate).HasValue());
        }
    }
}
