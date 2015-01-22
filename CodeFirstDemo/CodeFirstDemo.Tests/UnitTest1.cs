using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFirstDemo;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using CodeFirstDemo.Models;

namespace CodeFirstDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTeacherMapping()
        {
            using (var context = new SchoolContext())
            {
                var kim = context.People.Find(1);
                Assert.IsInstanceOfType(kim, typeof(Instructor));
            }
        }

        [TestMethod]
        public void TestStudentMapping()
        {
            using (var context = new SchoolContext())
            {
                var peggy = context.People.Find(3);
                Assert.IsInstanceOfType(peggy, typeof(Student));
            }
        }
    }
}
