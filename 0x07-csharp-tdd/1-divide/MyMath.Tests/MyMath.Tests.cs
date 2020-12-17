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
        public void TestShortSmSm()
        {
            Assert.AreEqual(new[,] {{1, 1}, {1, 1}}, MyMath.Matrix.Divide(new[,] {{2, 2}, {2, 2}}, 2));
        }

        [Test]
        public void TestShortSmLg()
        {
            Assert.AreEqual(new[,] {{0, 0}, {0, 0}}, MyMath.Matrix.Divide(new[,] {{2, 2}, {2, 2}}, 23456));
        }

        [Test]
        public void TestShortLgSm()
        {
            Assert.AreEqual(new[,] {{11728, 11728}, {11728, 11728}}, MyMath.Matrix.Divide(new[,] {{23456, 23456}, {23456, 23456}}, 2));
        }

        [Test]
        public void TestShortLgLg()
        {
            Assert.AreEqual(new[,] {{1, 1}, {1, 1}}, MyMath.Matrix.Divide(new[,] {{23456, 23456}, {23456, 23456}}, 23456));
        }

        [Test]
        public void TestLongSmSm()
        {
            Assert.AreEqual(new[,] {{1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}}, MyMath.Matrix.Divide(new[,] {{2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}}, 2));
        }

        [Test]
        public void TestLongSmLg()
        {
            Assert.AreEqual(new[,] {{0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}}, MyMath.Matrix.Divide(new[,] {{2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}, {2, 2, 2, 2, 2, 2}}, 23456));
        }

        [Test]
        public void TestLongLgSm()
        {
            Assert.AreEqual(new[,] {{11728, 11728, 11728, 11728, 11728, 11728}, {11728, 11728, 11728, 11728, 11728, 11728}, {11728, 11728, 11728, 11728, 11728, 11728}, {11728, 11728, 11728, 11728, 11728, 11728}, {11728, 11728, 11728, 11728, 11728, 11728}, {11728, 11728, 11728, 11728, 11728, 11728}}, MyMath.Matrix.Divide(new[,] {{23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}}, 2));
        }

        [Test]
        public void TestLongLgLg()
        {
            Assert.AreEqual(new[,] {{1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1}}, MyMath.Matrix.Divide(new[,] {{23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}, {23456, 23456, 23456, 23456, 23456, 23456}}, 23456));
        }

        [Test]
        public void TestZero()
        {
            Assert.AreEqual(null, MyMath.Matrix.Divide(new[,] {{1, 1}, {1, 1}}, 0));
        }

        [Test]
        public void TestNull()
        {
            Assert.AreEqual(null, MyMath.Matrix.Divide(null, 2));
        }
    }
}