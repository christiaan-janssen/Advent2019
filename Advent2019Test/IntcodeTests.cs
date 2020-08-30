using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent2019NS;

namespace Advent2019Test
{
    [TestClass]
    public class IntcodeTests
    {
        Intcode comp = new Intcode();

        [TestInitialize]
        public void Setup() { }

        [TestMethod]
        public void Run_Simple_Program_Addition()
        {
            int[] program = { 1, 0, 0, 0, 99 };
            int expected = 2;
            int actual = comp.run(program);

            Assert.AreEqual(expected, actual);

            int[] expectedProgram = { 2, 0, 0, 0, 99 };
            int[] actualProgram = comp.program;
            CollectionAssert.AreEqual(expectedProgram, actualProgram);
        }

        [TestMethod]
        public void Run_Simple_Program_Multiplication()
        {
            int[] program = { 2, 3, 0, 3, 99 };
            int expected = 2;
            int actual = comp.run(program);

            Assert.AreEqual(expected, actual);

            int[] expectedProgram = {2,3,0,6,99};
            int[] actualProgram = comp.program;
            CollectionAssert.AreEqual(expectedProgram, actualProgram);
        }

        [TestMethod]
        public void Run_Simple_Program_One()
        {
            int[] program = { 2, 4, 4, 5, 99, 0 };
            int expected = 2;
            int actual = comp.run(program);

            Assert.AreEqual(expected, actual);

            int[] expectedProgram = { 2, 4, 4, 5, 99, 9801 };
            int[] actualProgram = comp.program;
            CollectionAssert.AreEqual(expectedProgram, actualProgram);
        }

        [TestMethod]
        public void Run_Simple_Program_Two()
        {
            int[] program = { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            int expected = 30;
            int actual = comp.run(program);

            Assert.AreEqual(expected, actual);

            int[] expectedProgram = { 30, 1, 1, 4, 2, 5, 6, 0, 99 };
            int[] actualProgram = comp.program;
            CollectionAssert.AreEqual(expectedProgram, actualProgram);
        }
    }
}
