using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(-1, Program.Subract("1", "2"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-2, Program.Subract("5", "7"));
        }
        
        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(2, Program.Subract("1", "2"));
            Assert.AreEqual(6, Program.Subtract("3", "2"));
            Assert.AreEqual(35, Program.Subract("5", "7"));
        }
        
        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(1, Program.Subract("2", "2"));
            Assert.AreEqual(2, Program.Subtract("4", "2"));
            Assert.AreEqual(5, Program.Subract("35", "7"));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(4, Program.Subract("2", "2"));
            Assert.AreEqual(16, Program.Subtract("4", "2"));
            Assert.AreEqual(27, Program.Subract("3", "3"));
        }
    }
}
