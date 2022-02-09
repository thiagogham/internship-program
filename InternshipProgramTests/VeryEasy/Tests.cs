using NUnit.Framework;
using InternshipProgram.VeryEasy;

namespace InternshipProgramTests.VeryEasy
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FixedTest()
        {
            Assert.IsTrue(VeryEasyProgram.ReturnTrue());
        }

        [Test]
        public void SunTest()
        {
            Assert.AreEqual(5, VeryEasyProgram.Sum(2, 3));
            Assert.AreEqual(10, VeryEasyProgram.Sum(7, 3));
            Assert.AreEqual(-9, VeryEasyProgram.Sum(-3, -6));
        }

        [Test]
        public void ConverMinutesToSecondsTest()
        {
            Assert.AreEqual(60, VeryEasyProgram.ConverMinutesToSeconds(1));
            Assert.AreEqual(360, VeryEasyProgram.ConverMinutesToSeconds(6));
            Assert.AreEqual(240, VeryEasyProgram.ConverMinutesToSeconds(4));
        }

        [Test]
        public void DivisibleByFiveTest()
        {
            Assert.AreEqual(false, VeryEasyProgram.DivisibleByFive(7));
            Assert.AreEqual(true, VeryEasyProgram.DivisibleByFive(5));
            Assert.AreEqual(true, VeryEasyProgram.DivisibleByFive(15));
            Assert.AreEqual(false, VeryEasyProgram.DivisibleByFive(33));
        }

        [Test]
        public void CalculateTest()
        {
            Assert.AreEqual(-76, VeryEasyProgram.Calculate(24, 100, "-"));
            Assert.AreEqual(-50, VeryEasyProgram.Calculate(-20, -30, "+"));
            Assert.AreEqual(114, VeryEasyProgram.Calculate(38, 3, "*"));
            Assert.AreEqual(4, VeryEasyProgram.Calculate(49, 5, "%"));
            Assert.AreEqual(300, VeryEasyProgram.Calculate(1500, 5, "/"));
        }

        [Test]
        public void ReverseTest()
        {
            Assert.AreEqual(new int[] { 4, 3, 2, 1 }, VeryEasyProgram.Reverse(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(new int[] { }, VeryEasyProgram.Reverse(new int[] { }));
            Assert.AreEqual(new int[] { -1, -1, -1 }, VeryEasyProgram.Reverse(new int[] { -1, -1, -1 }));
            Assert.AreEqual(new int[] { 4, 3, 2, 9, 9 }, VeryEasyProgram.Reverse(new int[] { 9, 9, 2, 3, 4 }));
        }

        [Test]
        public void FirstLastCharacterTest()
        {
            Assert.AreEqual("fa", VeryEasyProgram.FirstLastCharacter("forza"));
            Assert.AreEqual("et", VeryEasyProgram.FirstLastCharacter("edabit"));
            Assert.AreEqual("as", VeryEasyProgram.FirstLastCharacter("always"));
        }
    }
}
