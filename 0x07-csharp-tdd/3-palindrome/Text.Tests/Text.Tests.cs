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
        public void TestEmpty()
        {
            Assert.True(Text.Str.IsPalindrome(""));
        }

        [Test]
        public void TestSingleLwr()
        {
            Assert.True(Text.Str.IsPalindrome("s"));
        }

        [Test]
        public void TestSingleUpr()
        {
            Assert.True(Text.Str.IsPalindrome("S"));
        }

        [Test]
        public void TestSingleLongLwr()
        {
            Assert.True(Text.Str.IsPalindrome("sssssssssssssssss"));
        }

        [Test]
        public void TestSingleLongUpr()
        {
            Assert.True(Text.Str.IsPalindrome("SSSSSSSSSSSSSSSSS"));
        }

        [Test]
        public void TestShortLwr()
        {
            Assert.True(Text.Str.IsPalindrome("sos"));
        }

        [Test]
        public void TestShortUpr()
        {
            Assert.True(Text.Str.IsPalindrome("SOS"));
        }

        [Test]
        public void TestShortMix()
        {
            Assert.True(Text.Str.IsPalindrome("SOs"));
        }

        [Test]
        public void TestLongLwr()
        {
            Assert.True(Text.Str.IsPalindrome("tattarrattat"));
        }

        [Test]
        public void TestLongUpr()
        {
            Assert.True(Text.Str.IsPalindrome("TATTARRATTAT"));
        }

        [Test]
        public void TestLongMix()
        {
            Assert.True(Text.Str.IsPalindrome("tAtTArRaTtaT"));
        }

        [Test]
        public void TestShortLwrF()
        {
            Assert.False(Text.Str.IsPalindrome("soo"));
        }

        [Test]
        public void TestShortUprF()
        {
            Assert.False(Text.Str.IsPalindrome("SOO"));
        }

        [Test]
        public void TestShortMixF()
        {
            Assert.False(Text.Str.IsPalindrome("SOo"));
        }

        [Test]
        public void TestLongLwrF()
        {
            Assert.False(Text.Str.IsPalindrome("tattarrattatt"));
        }

        [Test]
        public void TestLongUprF()
        {
            Assert.False(Text.Str.IsPalindrome("TATTARRATTATT"));
        }

        [Test]
        public void TestLongMixF()
        {
            Assert.False(Text.Str.IsPalindrome("tAtTArRaTtaTt"));
        }

        [Test]
        public void TestPunc()
        {
            Assert.True(Text.Str.IsPalindrome("tAt.TA:rRa...Tta,T"));
        }

        [Test]
        public void TestSpace()
        {
            Assert.True(Text.Str.IsPalindrome("tAt TA rRa   Tta T"));
        }

        [Test]
        public void TestAllMix()
        {
            Assert.True(Text.Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }
    }
}