using NUnit.Framework;
using Vigenere;

namespace Tests
{
    public class CaesarLookupTests
    {
        private CaesarLookup caesar;

        [SetUp]
        public void Setup()
        {
            this.caesar = new CaesarLookup();
        }

        [TestCase('A', 0, 'A')]
        [TestCase('A', 1, 'B')]
        [TestCase('B', 0, 'B')]
        [TestCase('&', 0, '?')]
        public void Should_ReturnCorrectChar_When_LookupWithShift(char input, int shift, char expected)
        {
            char result = caesar.Lookup(input, shift);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}