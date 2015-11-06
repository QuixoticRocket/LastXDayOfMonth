using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Nov2015Monday()
        {
            var answer = DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Monday, 11, 2015);

            Assert.AreEqual(30, answer);
        }

        [TestMethod]
        public void Nov2015Tuesday()
        {
            var answer = DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Tuesday, 11, 2015);

            Assert.AreEqual(24, answer);
        }
        [TestMethod]
        public void Nov2015Wednesday()
        {
            var answer = DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Wednesday, 11, 2015);

            Assert.AreEqual(25, answer);
        }
        [TestMethod]
        public void Nov2015Thursday()
        {
            var answer = DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Thursday, 11, 2015);

            Assert.AreEqual(26, answer);
        }
        [TestMethod]
        public void Nov2015Friday()
        {
            var answer = DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Friday, 11, 2015);

            Assert.AreEqual(27, answer);
        }
        [TestMethod]
        public void Nov2015Saturday()
        {
            var answer = DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Saturday, 11, 2015);

            Assert.AreEqual(28, answer);
        }
        [TestMethod]
        public void Nov2015Sunday()
        {
            var answer = DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Sunday, 11, 2015);

            Assert.AreEqual(29, answer);
        }
    }
}
