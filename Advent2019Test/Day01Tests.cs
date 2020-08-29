using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent2019NS;

namespace Advent2019Test
{
    [TestClass]
    public class Day01Tests
    {
        Day01 day01;

        [TestInitialize]
        public void Setup()
        {
            day01 = new Day01();
        }

        [TestMethod]
        public void Calculate_Fuel_For_Mass_Of_12()
        {
            int expected = 2;
            int actual = day01.calculateMass(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_Fuel_For_Mass_Of_14()
        {
            int expected = 2;
            int actual = day01.calculateMass(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_Fuel_For_Mass_Of_1969()
        {
            int expected = 654;
            int actual = day01.calculateMass(1969);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_Fuel_For_Mass_Of_100756()
        {
            int expected = 33583;
            int actual = day01.calculateMass(100756);

            Assert.AreEqual(expected, actual);
        }
    }
}
