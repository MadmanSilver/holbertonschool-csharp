using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSingle()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("s"));
        }

        [Test]
        public void TestOne()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("sup"));
        }

        [Test]
        public void TestTwo()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("supBro"));
        }

        [Test]
        public void TestThree()
        {
            Assert.AreEqual(3, Text.Str.CamelCase("supBroYeet"));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(0, Text.Str.CamelCase(""));
        }

        [Test]
        public void TestCaps()
        {
            Assert.AreEqual(12, Text.Str.CamelCase("sSSSSSSSSSSS"));
        }

        [Test]
        public void TestSingleCap()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("S"));
        }
    }
}