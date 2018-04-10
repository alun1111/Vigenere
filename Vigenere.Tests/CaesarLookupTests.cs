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
        [TestCase(' ', 0, ' ')]
        [TestCase(' ', 1, 'A')]
        [TestCase('D', -4, ' ')]
        public void Should_ReturnCorrectChar_When_LookupWithShift(char input, int shift, char expected)
        {
            char result = caesar.Lookup(input, shift);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase('A', 0)]
        [TestCase(' ', 26)]
        public void Should_ReturnCorrectIndex_When_CharLookup(char input, int expected)
        {
            int result = caesar.GetIndex(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}