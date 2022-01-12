using System;
using System.IO;
using KataTimeTable;
using NUnit.Framework;

namespace KataTimeTableTest
{
    public class Tests
    {
        [TestCase("Input1.txt", "Output1.txt")]
        [TestCase("Input2.txt", "Output2.txt")]
        [TestCase("Input3.txt", "Output3.txt")]
        [TestCase("Input4.txt", "Output4.txt")]
        [TestCase("Input5.txt", "Output5.txt")]
        [TestCase("Input6.txt", "Output6.txt")]
        [TestCase("Input7.txt", "Output7.txt")]
        public void Should_work(string input, string output)
        {
            var lines = File.ReadAllLines(input);
            var actual = TimeTable.Execute(lines);

            var expected = File.ReadAllText(output);
            
            Assert.AreEqual(expected, actual);
        }
    }
}