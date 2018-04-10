using System;
using System.Collections.Generic;

namespace Vigenere
{
    public class CaesarLookup
    {
        private char[] alphabet = new char[]{
            'A','B','C','D','E','F',
            'G','H','I','J','K','L',
            'M','N','O','P','Q','R',
            'S','T','U','V','W','X',
            'Y','Z',' '
        };

        public char Lookup(char character, int shift)
        {
            int index = GetIndex(character);

            if(index >= 0){
                if(shift < 0)
                {
                    index = (alphabet.Length + index + shift) % alphabet.Length;
                }
                else
                {
                    index = (index + shift) % alphabet.Length;
                }

                return alphabet[index];
            }

            return '?';
        }

        public int GetIndex(char character)
        {
            int index = -1;
            for(int i = 0; i < alphabet.Length; i++)
            {
                if(character.Equals(alphabet[i])){
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}