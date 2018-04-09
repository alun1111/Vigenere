namespace Vigenere
{
    public class Caesar
    {
        private CaesarLookup caesarLookup = new CaesarLookup();

        public string Encrypt(string plaintext, int shift)
        {
            char[] input = plaintext.ToCharArray();
            char[] output = new char[input.Length];

            for(int i = 0; i < input.Length; i++){
                output[i] = caesarLookup.Lookup(input[i], shift);
            }

            return new string(output);
        }
    }
}