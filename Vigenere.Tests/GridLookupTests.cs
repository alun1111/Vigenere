using NUnit.Framework;
using Vigenere;

namespace Tests
{
    public class GridLookupTests
    {
        private GridLookup lookup;

        [SetUp]
        public void Setup()
        {
            this.lookup = new GridLookup();
        }

        [TestCase('A', 'A')]
        [TestCase('B', 'B')]
        public void Should_ReturnSameChar_When_Lookup(char input, char expected)
        {
            char result = lookup.Lookup(input, 0);

            Assert.That(input, Is.EqualTo(result));
        }


        [TestCase('A', 0, 'A')]
        [TestCase('A', 1, 'B')]
        public void Should_ReturnCorrectChar_When_LookupWithIndex(char input, char expected)
        {
            char result = lookup.Lookup(input, 0);

            Assert.That(input, Is.EqualTo(result));
        }
    }
}