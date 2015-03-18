using System;
using System.Linq;
using Inventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestFirstName()
        {
            Employee e1 = new Employee();
            e1.FirstName = "John"; //Sets name
            Assert.AreEqual("John", e1.FirstName); //Making sure it's not a wrong name
            Assert.IsFalse(e1.FirstName.Any(char.IsDigit)); //Checks if name contains a number
            Assert.IsFalse(e1.FirstName == null); //Makes sure it's not null
        }

        [TestMethod]
        public void TestLastName()
        {
            Employee e1 = new Employee();
            e1.LastName = "McClane";
            Assert.AreEqual("McClane", e1.LastName);
            Assert.IsFalse(e1.LastName.Any(char.IsDigit));
            Assert.IsFalse(e1.LastName == null);
        }

        [TestMethod]
        public void TestInitials()
        {
            Employee e1 = new Employee();
            e1.Initials = "JMC";
            Assert.AreEqual("JMC", e1.Initials);
            Assert.IsFalse(e1.Initials == null);
        }
    }
}
