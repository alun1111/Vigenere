namespace Vigenere
{
    public interface ICaesarLookup
    {
        char Lookup(char character, int shift);
    }
}