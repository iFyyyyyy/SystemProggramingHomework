using NUnit.Framework;
using System;
using Task1Library;

namespace TestProject1
{
    [TestFixture]
    public class LeapYearTests
    {
        [Test]
        public void TestLeapYear()
        {
            // Arrange
            DateTime leapYear = new DateTime(2020, 1, 1);

            // Act
            bool result = DateAndTimeFunctions.isLeapYear(leapYear);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TestNonLeapYear()
        {
            // Arrange
            DateTime nonLeapYear = new DateTime(2021, 1, 1);

            // Act
            bool result = DateAndTimeFunctions.isLeapYear(nonLeapYear);

            // Assert
            Assert.IsFalse(result);
        }
    }
}