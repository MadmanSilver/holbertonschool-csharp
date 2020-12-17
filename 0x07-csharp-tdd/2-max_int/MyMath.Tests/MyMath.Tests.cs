using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShortSm()
        {
            Assert.AreEqual(4, MyMath.Operations.Max(new List<int> {1, 4, 2, 3}));
        }

        [Test]
        public void TestShortLg()
        {
            Assert.AreEqual(45678, MyMath.Operations.Max(new List<int> {12345, 45678, 23456, 34567}));
        }

        [Test]
        public void TestLongSm()
        {
            Assert.AreEqual(10, MyMath.Operations.Max(new List<int> {1, 10, 2, 3, 4, 5, 6, 7, 8, 9}));
        }

        [Test]
        public void TestLongLg()
        {
            Assert.AreEqual(1011121314, MyMath.Operations.Max(new List<int> {12345, 1011121314, 23456, 34567, 45678, 56789, 678910, 7891011, 89101112, 910111213}));
        }

        [Test]
        public void TestShortSmNeg()
        {
            Assert.AreEqual(-1, MyMath.Operations.Max(new List<int> {-1, -4, -2, -3}));
        }

        [Test]
        public void TestShortLgNeg()
        {
            Assert.AreEqual(-12345, MyMath.Operations.Max(new List<int> {-12345, -45678, -23456, -34567}));
        }

        [Test]
        public void TestLongSmNeg()
        {
            Assert.AreEqual(-1, MyMath.Operations.Max(new List<int> {-1, -10, -2, -3, -4, -5, -6, -7, -8, -9}));
        }

        [Test]
        public void TestLongLgNeg()
        {
            Assert.AreEqual(-12345, MyMath.Operations.Max(new List<int> {-12345, -1011121314, -23456, -34567, -45678, -56789, -678910, -7891011, -89101112, -910111213}));
        }

        [Test]
        public void TestZeroDup()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int> {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}));
        }

        [Test]
        public void TestRight()
        {
            Assert.AreEqual(10, MyMath.Operations.Max(new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}));
        }

        [Test]
        public void TestMix()
        {
            Assert.AreEqual(4, MyMath.Operations.Max(new List<int> {-4, -3, -2, -1, 0, 1, 2, 3, 4}));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int>()));
        }
    }
}