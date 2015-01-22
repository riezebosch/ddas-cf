using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFirstDemo;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void Initialize(TestContext notused)
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
            using (var context = new SchoolContext())
            {
                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            using (var context = new SchoolContext())
            {
                var student = context.People.Add(new Student
                {
                    Name = "Pietje Puk",
                    StudentNumber = "S202060"
                });

                context.SaveChanges();
                Assert.AreNotEqual(0, student.Id);
            }
        }

        [TestMethod]
        public void TestInsertPerson()
        {
            using (var context = new SchoolContext())
            {
                var person = context.People.Add(new Person
                {
                    Name = "Agent Langdraad",
                });

                context.SaveChanges();
                Assert.AreNotEqual(0, person.Id);
            }
        }

        [TestMethod]
        public void LazyLoadingExplained()
        {
            using (var context = new SchoolContext())
            {
                var person = context.People.Add(new Person
                {
                    Name = "Agent Langdraad",
                    Addresses = new List<Address>{
                    new Address {
                        Street = "Hoofdstraat 12",
                        City = "Veenendaal"
                    }},
                    BirthDate = new DateTime(1985,4,2)
                });

                context.SaveChanges();
            }

            using (var context = new SchoolContext())
            {
                context.Database.Log = Console.WriteLine;

                foreach (var person in context.People)
                {
                    Console.WriteLine(person.GetType());

                    foreach (var address in person.Addresses)
                    {
                        Console.WriteLine("{0} {1}", address.Street, address.City);
                    }
                }
            }
        }
    }
}
