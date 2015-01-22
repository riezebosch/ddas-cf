using System;
using System.Collections.Generic;

namespace CodeFirstDemo.Models
{
    public partial class Person
    {
        public Person()
        {
        }

        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
