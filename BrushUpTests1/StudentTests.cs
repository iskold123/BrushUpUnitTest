using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student s1;

        [TestInitialize]
        //Initialisere s1 objekt så der konstant bliver oprettet et nyt hver gang
        public void Init()
        {
            s1 = new Student ("mads", "Maglehøjen", 3);
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("mads", s1.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException> (() => s1.Name = "M");
            s1.Name = "kurt";
        }

        [TestMethod()]
        public void AddressTest()
        {
            s1.Address = "Maglehøjen";
            Assert.AreEqual("Maglehøjen", s1.Address);
            Assert.ThrowsException<ArgumentNullException>(() => s1.Address = null);
        }

        [TestMethod()]
        public void SemesterTest()
        {
            s1.Semester = 1;
            Assert.AreEqual(1, s1.Semester);

            s1.Semester = 8;
            Assert.AreEqual(8, s1.Semester);

            Assert.ThrowsException<ArgumentException>(() => s1.Semester = 0);
            Assert.ThrowsException<ArgumentException>(() => s1.Semester = 9);

        }
    }
}