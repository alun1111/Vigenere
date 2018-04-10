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
        [TestCase("hello", "AB", "?????")]
        [TestCase("HELLO HELLO", "AB", "HFLMOAHFLMO")]
        [TestCase("A MORE INTERESTING MESSAGE", "LEMON", "LDYBDPDUAFPVQFFTRSNZPWDOTP")]
        public void Should_ReturnCorrectString_When_Encrypting(string plaintext, string keyword, string expected)
        {
            string result = this.vigenere.Encrypt(plaintext, keyword);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("HELLO", "A", "HELLO")]
        [TestCase("HFLMO", "AB", "HELLO")]
        [TestCase("?????", "AB", "?????")]
        [TestCase("HFLMOAHFLMO", "AB", "HELLO HELLO")]
        [TestCase("LDYBDPDUAFPVQFFTRSNZPWDOTP", "LEMON", "A MORE INTERESTING MESSAGE")]
        public void Should_ReturnCorrectString_When_Decrypting(string ciphertext, string keyword, string expected)
        {
            string result = this.vigenere.Decrypt(ciphertext, keyword);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}