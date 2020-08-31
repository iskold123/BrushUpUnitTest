using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher t1;

        [TestInitialize]
        public void Init()
        {
            t1 = new Teacher("Jacob", "maglegårdsvej", 10000, GenderT.Male);
        }

        [TestMethod()]
        public void NameTest()
        {
            t1.Name = "Jacob";
            Assert.AreEqual("Jacob", t1.Name);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => t1.Name = "J");
            Assert.AreEqual("Jacob", t1.Name);
        }

        [TestMethod()]
        public void AddressTest()
        {
            t1.Address = "maglegårdsvej";
            Assert.AreEqual("maglegårdsvej", t1.Address);

            Assert.ThrowsException<ArgumentNullException>(() => t1.Address = null);
            Assert.AreEqual("maglegårdsvej", t1.Address);
        }

        [TestMethod]
        public void SalaryTest()
        {
            t1.Salary = 10000;

            Assert.AreEqual(10000,t1.Salary);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => t1.Salary = -1);
        }

        [TestMethod()]
        public void GenderTest()
        {
            t1.Gender = GenderT.Male;
        }

        //[TestMethod()]
        //public void ToStringTest()
        //{
        //    Assert.Fail();
        //}
    }
}