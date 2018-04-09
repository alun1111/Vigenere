using System;
using NUnit.Framework;
using Vigenere;

namespace Tests
{
    public class VigenereTests
    {
        private VigenereEncoder vigenere;

        [SetUp]
        public void Setup()
        {
            this.vigenere = new VigenereEncoder();
        }

        [TestCase("HELLO", "A", "HELLO")]
        [TestCase("HELLO", "AB", "HFLMO")]
        public void Should_ReturnCorrectString_When_Encrypting(string plaintext, string keyword, string expected)
        {
            string result = this.vigenere.Encrypt(plaintext, keyword);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}