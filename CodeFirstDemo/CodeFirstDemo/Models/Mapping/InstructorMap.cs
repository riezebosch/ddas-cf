using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CodeFirstDemo.Models.Mapping
{
    public class InstructorMap : EntityTypeConfiguration<Instructor>
    {
        public InstructorMap()
        {
            this.Property(t => t.HireDate).HasColumnName("HireDate");
            
            this.Map(t => t.Requires(m => m.HireDate).HasValue());
        }
    }
}
