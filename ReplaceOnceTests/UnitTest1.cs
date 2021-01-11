using NUnit.Framework;
using ReplaceOnce;

namespace ReplaceOnceTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var target = new ReplaceOneService();

            var input = "Python is an easy to learn powerful programming language It has efficient high-level data structures and a simple but effective approach to objectoriented programming Python elegant syntax and dynamic typing";

            var actual = target.ReplaceOnce(input, "programming Python elegant syntax and dynamic typing");

            var expected = "Python is an easy to learn powerful language It has efficient high-level data structures and a simple but effective approach to objectoriented programming";

            Assert.AreEqual(expected, actual);
        }
    }
}
