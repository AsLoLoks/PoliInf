using System.Diagnostics.Contracts;

namespace PoliInf.ExercisesArrays
{
    public class StringMethods
    {
        int[] characterCount = new int[127];
        int countSmallLetters = 0;
        int countCapitalLetters = 0;
        int countDigits = 0;
        int countWhiteSpaces = 0;
        string censoredCapitalLetters = "";
        int mostImportantBitValue = -1;

        public StringMethods(string text)
        {
            // a
            fillCountTableWithZeros();
            countAll(text);
            updateCounters();
            // b
            censorCapitalLetter(text);
            //c
            findMostImportantBitValue(text);
        }
        
        public string GetCensoredCapitalText()
        {
            return censoredCapitalLetters;
        }

        
        public int GetMostImportantBitValue()
        {
            return mostImportantBitValue;
        }

        void findMostImportantBitValue(string bits)
        {
            bool isProblem = false;
            for (int i = 0; i < bits.Length; i++)
            {
                if(bits[i] != '1' && bits[i] != '0')
                {
                    isProblem = true;
                    break;
                }
            }
            // c) Wczytaj 8-bitową liczbę binarną (np. 00101100) i wypisz wagę najbardziej znaczącej jedynki (tu: 32).
            //     – Wskazówka: pierwsza jedynka od lewej na pozycji i ma wagę 2^(7 − i). Sprawdź, czy wczytano dokładnie 8 znaków 0 lub 1.
            if( bits.Length == 8 && isProblem == false)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (bits[i] == '1')
                    {
                        // wynikk = 2^ (7-1)
                        mostImportantBitValue = 2^(7-i);
                    }
                }
            }
            else
            {
                mostImportantBitValue = -1;
            }
        }

        void censorCapitalLetter(string text)
        {
            for ( int i = 0; i < text.Length; i++)
            {
                if( text[i] >= 65 && text[i] < 91)
                {
                    censoredCapitalLetters += "*";
                }
                else
                {
                    censoredCapitalLetters += text[i];
                }
            }
        }

        void fillCountTableWithZeros()
        {
            for(int i = 0; i < characterCount.Length; i++)
            {
                characterCount[i] = 0;
            }
        }

        //  countCapitalLetters = 0;
        //     for(int i = 65; i < 91; i++)  //A-Z
        //     {
        //         countCapitalLetters += characterCount[i];
        //     }

       

        void countAll(string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                if(character > 127) continue;
                characterCount[character]++;
            }
        }
        void updateCounters(){

            countCapitalLetters = 0;
            for(int i = 65; i < 91; i++)  //A-Z
            {
                countCapitalLetters += characterCount[i];
            }
            countSmallLetters = 0;
            for(int i = 97; i < 123; i++)  //a-z
            {
                countSmallLetters += characterCount[i];
            }
            countDigits = 0;
            for(int i = 48; i < 58; i++)  //0-9
            {
                countDigits += characterCount[i];
            }
            countWhiteSpaces = characterCount[9] + characterCount[10] + characterCount[32]; // tab /n space

        }
        public int GetCounterLetters()
        {
            return countCapitalLetters + countSmallLetters;
        }

        public int GetCounterDigits()
        {
            return countDigits;
        }

        public int GetCounterWhiteSpaces()
        {
            return countWhiteSpaces;
        }
    }
}