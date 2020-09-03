using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp.Tests
{
    [TestClass()]
    public class PersonTests
    {
        private Person p1;
        [TestInitialize]
        //Initialisere s1 objekt så der konstant bliver oprettet et nyt hver gang
        public void Init()
        {
            p1 = new Person("mads", "maglehøjen", GenderType.male);
        }

        [TestMethod]
        public void ToString()
        {
            Assert.AreEqual("mads",p1.Name);
        }

        [TestMethod]
        public void GenderTest()
        {
            Assert.AreEqual(GenderType.male, p1.Gender);
        }
    }
}