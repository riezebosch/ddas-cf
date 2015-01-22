using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CodeFirstDemo
{
    public class SchoolContext : DbContext
    {
        public IDbSet<Person> People { get; set; }
    }
}
