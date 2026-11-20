using System.Diagnostics.Contracts;

namespace PoliInf.ExercisesArrays
{
    public class StringCount
    {
        int[] characterCount = new int[127];
        int countSmallLetters = 0;
        int countCapitalLetters = 0;
        int countDigits = 0;
        int countWhiteSpaces = 0;

        public StringCount(string text)
        {
            fillCountTableWithZeros();
            countAll(text);
            updateCounters();
        }



        void fillCountTableWithZeros()
        {
            for(int i = 0; i < characterCount.Length; i++)
            {
                characterCount[i] = 0;
            }
        }

       

        void countAll(string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                characterCount[character]++;
            }
        }
        void updateCounters(){

            countCapitalLetters = 0;
            for(int i = 65; i < 91; i++)  //A-Z
            {
                countCapitalLetters++;
            }
            countSmallLetters = 0;
            for(int i = 97; i < 123; i++)  //a-z
            {
                countSmallLetters++;
            }
            countDigits = 0;
            for(int i = 48; i < 58; i++)  //0-9
            {
                countDigits++;
            }
            countWhiteSpaces = characterCount[9] + characterCount[10] + characterCount[32]; // tab /n space

        }
        public int getCounterLetters()
        {
            return countCapitalLetters + countSmallLetters;
        }

        public int getCounterDigits()
        {
            return countDigits;
        }

        public int getCounterWhiteSpaces()
        {
            return countWhiteSpaces;
        }



    }
}