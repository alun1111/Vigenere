
namespace Vigenere
{
    public class VigenereEncoder
    {
        private CaesarLookup lookup = new CaesarLookup();
        
        public string Encrypt(string plaintext, string keyword)
        {
            char[] input = plaintext.ToCharArray();
            char[] inputKeyword = keyword.ToCharArray();
            char[] output = new char[input.Length];

            for(int i = 0; i < input.Length; i++){
                var shift = lookup.GetIndex(keyword[i % keyword.Length]);
                output[i] = lookup.Lookup(input[i], shift);
            }

            return new string(output);
        }
    }
}