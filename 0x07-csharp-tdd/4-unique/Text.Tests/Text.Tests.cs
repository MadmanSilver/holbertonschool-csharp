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
            Assert.AreEqual(0, Text.Str.UniqueChar("s"));
        }

        [Test]
        public void TestShort()
        {
            Assert.AreEqual(1, Text.Str.UniqueChar("sos"));
        }

        [Test]
        public void TestLong()
        {
            Assert.AreEqual(25, Text.Str.UniqueChar("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy"));
        }

        [Test]
        public void TestLongx3()
        {
            Assert.AreEqual(25, Text.Str.UniqueChar("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxy"));
        }

        [Test]
        public void TestShortF()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar("soso"));
        }

        [Test]
        public void TestLongF()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"));
        }

        [Test]
        public void TestLongx3F()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy"));
        }

        [Test]
        public void TestLeft()
        {
            Assert.AreEqual(0, Text.Str.UniqueChar("soo"));
        }

        [Test]
        public void TestRight()
        {
            Assert.AreEqual(2, Text.Str.UniqueChar("oos"));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(""));
        }
    }
}