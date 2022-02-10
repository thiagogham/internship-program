using NUnit.Framework;
using InternshipProgram.Easy;

namespace InternshipProgramTests.Easy
{
    [TestFixture]
    public class EasyTests
    {
        [Test]
        public void FactorialTest()
        {
            Assert.AreEqual(2, EasyProgram.Factorial(2));
            Assert.AreEqual(120, EasyProgram.Factorial(5));
            Assert.AreEqual(6, EasyProgram.Factorial(3));
            Assert.AreEqual(479001600, EasyProgram.Factorial(12));
        }

        [Test]
        public void SortNumsAscendingTests()
        {
            Assert.AreEqual(new int[] { 1, 2, 5, 10, 50 }, EasyProgram.SortNumsAscending(new int[] { 1, 2, 10, 50, 5 }));
            Assert.AreEqual(new int[] { -95, -24, 4, 29, 80, 85 }, EasyProgram.SortNumsAscending(new int[] { 80, 29, 4, -95, -24, 85 }));
            Assert.AreEqual(new int[] { 21, 33, 35, 45, 65, 97, 98 }, EasyProgram.SortNumsAscending(new int[] { 45, 98, 35, 65, 97, 21, 33 }));
            Assert.AreEqual(new int[] { 0 }, EasyProgram.SortNumsAscending(new int[] { 0 }));
        }
    }
}
