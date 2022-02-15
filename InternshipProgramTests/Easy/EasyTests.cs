using NUnit.Framework;
using InternshipProgram.Easy;
using System;

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

        [Test]
        [TestCase("01-01-2021", ExpectedResult = "January")]
        [TestCase("02-01-2021", ExpectedResult = "February")]
        [TestCase("03-01-2021", ExpectedResult = "March")]
        [TestCase("04-01-2021", ExpectedResult = "April")]
        [TestCase("05-01-2021", ExpectedResult = "May")]
        [TestCase("06-01-2021", ExpectedResult = "June")]
        [TestCase("07-01-2021", ExpectedResult = "July")]
        [TestCase("08-01-2021", ExpectedResult = "August")]
        [TestCase("09-01-2021", ExpectedResult = "September")]
        [TestCase("10-01-2021", ExpectedResult = "October")]
        [TestCase("11-01-2021", ExpectedResult = "November")]
        [TestCase("12-01-2021", ExpectedResult = "December")]
        public static string MonthNameTests(DateTime date)
        {
            return EasyProgram.MonthName(date);
        }

        [Test]
        public void RemoveDuplicatesTests()
        {
            object[] haystack_1 = new object[] { "John", "Taylor", "John" };
            object[] haystack_2 = new object[] { "John", "Taylor", "John", "john" };
            object[] haystack_3 = new object[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" };
            object[] haystack_4 = new object[] { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 };
            object[] haystack_5 = new object[] { "#", "#", "%", "&", "#", "$", "&" };
            object[] haystack_6 = new object[] { 3, "Apple", 3, "Orange", "Apple" };

            Assert.AreEqual(new object[] { "John", "Taylor" }, EasyProgram.RemoveDuplicates(haystack_1));
            Assert.AreEqual(new object[] { "John", "Taylor", "john" }, EasyProgram.RemoveDuplicates(haystack_2));
            Assert.AreEqual(new object[] { "javascript", "python", "ruby", "c" }, EasyProgram.RemoveDuplicates(haystack_3));
            Assert.AreEqual(new object[] { 1, 2, 3, 5, 6, 7 }, EasyProgram.RemoveDuplicates(haystack_4));
            Assert.AreEqual(new object[] { "#", "%", "&", "$" }, EasyProgram.RemoveDuplicates(haystack_5));
            Assert.AreEqual(new object[] { 3, "Apple", "Orange" }, EasyProgram.RemoveDuplicates(haystack_6));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }, ExpectedResult = 5)]
        [TestCase(new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 }, ExpectedResult = 10)]
        [TestCase(new int[] { 7, 2, 3, 9, 4, 5, 6, 8, 10 }, ExpectedResult = 1)]
        [TestCase(new int[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 }, ExpectedResult = 7)]
        [TestCase(new int[] { 1, 7, 2, 4, 8, 10, 5, 6, 9 }, ExpectedResult = 3)]
        public static int MissingNumberTests(int[] arr)
        {
            return EasyProgram.MissingNumberTests(arr);
        }

        [Test]
        public void CumulativeSumTests()
        {
            double[] haystack_1 = new double[] { };
            double[] haystack_2 = new double[] { 1 };
            double[] haystack_3 = new double[] { 1, 2, 3 };
            double[] haystack_4 = new double[] { -1, -2, -3 };
            double[] haystack_5 = new double[] { 1, -2, 3 };
            double[] haystack_6 = new double[] { 3, 3, -2, 408, 3, 3, 0, 66, 2, -2, 2, 3, 4, 2, -47, 3, 3, 2 };

            Assert.AreEqual(new double[] { }, EasyProgram.CumulativeSum(haystack_1));
            Assert.AreEqual(new double[] { 1 }, EasyProgram.CumulativeSum(haystack_2));
            Assert.AreEqual(new double[] { 1, 3, 6 }, EasyProgram.CumulativeSum(haystack_3));
            Assert.AreEqual(new double[] { -1, -3, -6 }, EasyProgram.CumulativeSum(haystack_4));
            Assert.AreEqual(new double[] { 1, -1, 2 }, EasyProgram.CumulativeSum(haystack_5));
            Assert.AreEqual(new double[] { 3, 6, 4, 412, 415, 418, 418, 484, 486, 484, 486, 489, 493, 495, 448, 451, 454, 456 }, EasyProgram.CumulativeSum(haystack_6));
        }
    }
}
