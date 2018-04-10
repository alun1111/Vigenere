using System;
using NUnit.Framework;
using Vigenere;

namespace Tests
{
    public class CaesarTests
    {
        private Caesar caesar;

        [SetUp]
        public void Setup()
        {
            this.caesar = new Caesar();
        }

        [TestCase("HELLO", 0, "HELLO")]
        [TestCase("HELLO", 1, "IFMMP")]
        [TestCase("HELLO HELLO", 1, "IFMMPAIFMMP")]
        public void Should_ReturnCorrectString_When_Encrypting(string plaintext, int shift, string expected)
        {
            string result = caesar.Encrypt(plaintext, shift);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}