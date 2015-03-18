using System;
using Inventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class HardwareTest
    {
        [TestMethod]
        public void TestHardwareName()
        {
            Hardware h1 = new Hardware();
            h1.HardwareName = "Razer Naga"; //Set name test
            Assert.AreEqual("Razer Naga", h1.HardwareName); //Get name test
            Assert.IsFalse(h1.HardwareName == null);
        }
        [TestMethod]
        public void TestModel()
        {
            Hardware h1 = new Hardware();
            h1.Model = "3580mx";
            Assert.AreEqual("3580mx", h1.Model);
            Assert.IsFalse(h1.Model == null);
        }
        [TestMethod]
        public void TestLocation()
        {
            Hardware h1 = new Hardware();
            h1.Location = "Airport";
            Assert.AreEqual("Airport", h1.Location);
            Assert.IsFalse(h1.Location == null);
        }
        [TestMethod]
        public void TestDateOfChange()
        {
            DateTime d1 = new DateTime(1997,3,23,5,32,15); //Year,Month,Day,Hour,Minute,Second
            DateTime d2 = new DateTime(1997,3,23,5,32,15);
            
            Assert.IsFalse(d1 == null);
            Assert.AreEqual(d1,d2);
            d1.AddDays(3);
            Assert.AreNotEqual(d1,d2);
        }
        [TestMethod]
        public void TestDateOfPurchase()
        {
            DateTime d1 = new DateTime(1997, 3, 23, 5, 32, 15); //Year,Month,Day,Hour,Minute,Second
            DateTime d2 = new DateTime(1997, 3, 23, 5, 32, 15);

            Assert.IsFalse(d1 == null);
            Assert.AreEqual(d1, d2);
            d1.AddDays(3);
            Assert.AreNotEqual(d1, d2);
        }
        [TestMethod]
        public void TestSerialNumber()
        {
            Hardware h1 = new Hardware();
            h1.SerialNumber = 592874598792487542;
            Assert.AreEqual(592874598792487542, h1.SerialNumber);
            Assert.IsFalse(h1.SerialNumber is string);
            h1.SerialNumber = 33;
            Assert.AreNotEqual(592874598792487542, h1.SerialNumber);
        }

        [TestMethod]
        public void TestOperatingSystem()
        {
            Hardware h1 = new Hardware();
            h1.OperatingSystem = "Windows 10";
            Assert.AreEqual("Windows 10", h1.OperatingSystem);
            h1.OperatingSystem = "Linux Mint 14";
            Assert.AreNotEqual("Windows 10", h1.OperatingSystem);
        }
    }
}
