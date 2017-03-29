using System;
using Xunit;

namespace TheGarageLab.Ensures.Test
{
    public class EnsuresTests
    {
        [Fact]
        public void IsNotNullTest()
        {
            var notNull = new Object();
            Ensure.IsNotNull(notNull);
            Ensure.IsNotNull<ArgumentNullException>(notNull);
            Assert.Throws<ArgumentException>(() => { Ensure.IsNotNull(null); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNotNull<ArgumentNullException>(null); });
        }

        [Fact]
        public void IsNullTest()
        {
            var notNull = new Object();
            Ensure.IsNull(null);
            Ensure.IsNull<ArgumentNullException>(null);
            Assert.Throws<ArgumentException>(() => { Ensure.IsNull(notNull); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNull<ArgumentNullException>(notNull); });
        }

        [Fact]
        public void IsTrueTest()
        {
            Ensure.IsTrue(true);
            Ensure.IsTrue<ArgumentNullException>(true);
            Assert.Throws<ArgumentException>(() => { Ensure.IsTrue(false); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsTrue<ArgumentNullException>(false); });
        }

        [Fact]
        public void IsFalseTest()
        {
            Ensure.IsFalse(false);
            Ensure.IsFalse<ArgumentNullException>(false);
            Assert.Throws<ArgumentException>(() => { Ensure.IsFalse(true); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsFalse<ArgumentNullException>(true); });
        }

        [Fact]
        public void IsNullOrEmptyTest()
        {
            string notNullOrEmpty = "NotNullOrEmpty";
            string empty = "";
            string white = "   ";
            Ensure.IsNullOrEmpty(null);
            Ensure.IsNullOrEmpty<ArgumentNullException>(null);
            Ensure.IsNullOrEmpty(empty);
            Ensure.IsNullOrEmpty<ArgumentNullException>(empty);
            Assert.Throws<ArgumentException>(() => { Ensure.IsNullOrEmpty(notNullOrEmpty); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNullOrEmpty<ArgumentNullException>(notNullOrEmpty); });
            Assert.Throws<ArgumentException>(() => { Ensure.IsNullOrEmpty(white); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNullOrEmpty<ArgumentNullException>(white); });
        }

        [Fact]
        public void IsNotNullOrEmptyTest()
        {
            string notNullOrEmpty = "NotNullOrEmpty";
            string empty = "";
            string white = "   ";
            Ensure.IsNotNullOrEmpty(notNullOrEmpty);
            Ensure.IsNotNullOrEmpty<ArgumentNullException>(notNullOrEmpty);
            Assert.Throws<ArgumentException>(() => { Ensure.IsNotNullOrEmpty(empty); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNotNullOrEmpty<ArgumentNullException>(empty); });
            Assert.Throws<ArgumentException>(() => { Ensure.IsNotNullOrEmpty(null); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNotNullOrEmpty<ArgumentNullException>(null); });
        }

        [Fact]
        public void IsNullOrWhiteSpaceTest()
        {
            string notNullOrEmpty = "NotNullOrEmpty";
            string empty = "";
            string white = "   ";
            Ensure.IsNullOrWhiteSpace(null);
            Ensure.IsNullOrWhiteSpace<ArgumentNullException>(null);
            Ensure.IsNullOrWhiteSpace(empty);
            Ensure.IsNullOrWhiteSpace<ArgumentNullException>(empty);
            Ensure.IsNullOrWhiteSpace(white);
            Ensure.IsNullOrWhiteSpace<ArgumentNullException>(white);
            Assert.Throws<ArgumentException>(() => { Ensure.IsNullOrWhiteSpace(notNullOrEmpty); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNullOrWhiteSpace<ArgumentNullException>(notNullOrEmpty); });
        }

        [Fact]
        public void IsNotNullOrWhiteSpaceTest()
        {
            string notNullOrEmpty = "NotNullOrEmpty";
            string empty = "";
            string white = "   ";
            Ensure.IsNotNullOrWhiteSpace(notNullOrEmpty);
            Ensure.IsNotNullOrWhiteSpace<ArgumentNullException>(notNullOrEmpty);
            Assert.Throws<ArgumentException>(() => { Ensure.IsNotNullOrWhiteSpace(null); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNotNullOrWhiteSpace<ArgumentNullException>(null); });
            Assert.Throws<ArgumentException>(() => { Ensure.IsNotNullOrWhiteSpace(empty); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNotNullOrWhiteSpace<ArgumentNullException>(empty); });
            Assert.Throws<ArgumentException>(() => { Ensure.IsNotNullOrWhiteSpace(white); });
            Assert.Throws<ArgumentNullException>(() => { Ensure.IsNotNullOrWhiteSpace<ArgumentNullException>(white); });
        }

    }
}
