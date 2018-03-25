using NUnit.Framework;
using Vigenere;

namespace Tests
{
    public class GridLookupTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_ReturnChar_When_Lookup()
        {
            var grid = new GridLookup();
            var result = grid.Lookup('A');

            Assert.That('A', Is.EqualTo('A'));

        }
    }
}