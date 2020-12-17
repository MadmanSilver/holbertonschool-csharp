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
        public void TestPosSm()
        {
            Assert.AreEqual(2, MyMath.Operations.Add(1, 1));
        }

        [Test]
        public void TestPosLg()
        {
            Assert.AreEqual(66666, MyMath.Operations.Add(12345, 54321));
        }

        [Test]
        public void TestNegSm()
        {
            Assert.AreEqual(-2, MyMath.Operations.Add(-1, -1));
        }

        [Test]
        public void TestNegLg()
        {
            Assert.AreEqual(-66666, MyMath.Operations.Add(-12345, -54321));
        }

        [Test]
        public void TestMixSm()
        {
            Assert.AreEqual(0, MyMath.Operations.Add(-1, 1));
        }

        [Test]
        public void TestMixLg1()
        {
            Assert.AreEqual(41976, MyMath.Operations.Add(-12345, 54321));
        }

        [Test]
        public void TestMixLg2()
        {
            Assert.AreEqual(-41976, MyMath.Operations.Add(12345, -54321));
        }

        [Test]
        public void TestZero()
        {
            Assert.AreEqual(0, MyMath.Operations.Add(0, 0));
        }

        [Test]
        public void TestZeroSm()
        {
            Assert.AreEqual(1, MyMath.Operations.Add(0, 1));
        }

        [Test]
        public void TestZeroLg()
        {
            Assert.AreEqual(54321, MyMath.Operations.Add(0, 54321));
        }
    }
}