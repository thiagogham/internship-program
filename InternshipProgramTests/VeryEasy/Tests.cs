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
    }
}
