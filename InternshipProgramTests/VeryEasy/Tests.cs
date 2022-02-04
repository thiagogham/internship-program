using NUnit.Framework;
using InternshipProgram;

namespace InternshipProgramTests.VeryEasy
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FixedTest()
        {
            Assert.IsTrue(Program.ReturnTrue());
        }

        [Test]
        public void SunTest()
        {
            Assert.AreEqual(5, Program.Sum(2, 3));
            Assert.AreEqual(10, Program.Sum(7, 3));
            Assert.AreEqual(-9, Program.Sum(-3, -6));
        }

        [Test]
        public void ConverMinutesToSecondsTest()
        {
            Assert.AreEqual(60, Program.ConverMinutesToSeconds(1));
            Assert.AreEqual(360, Program.ConverMinutesToSeconds(6));
            Assert.AreEqual(240, Program.ConverMinutesToSeconds(4));
        }
    }
}
