using System;
using System.Collections.Generic;
using System.Text;

namespace day_10
{

    // C# program to print the total number of Vowels
    // and consonants from a given string
    class GFG
    {

        public static void Main()
        {
            string inputstring;
            int i, len, vowels, consonants;

            inputstring = "novelvista";
            inputstring = "capgemini";
            vowels = 0;
            consonants = 0;
            len = inputstring.Length;

            // Iterating the string from left to right
            for (i = 0; i < len; i++)
            {

                // Check if the character is a vowel
                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U')
                {

                    // Increment the vowels
                    vowels++;
                }

                // Check if the character is a alphabet
                // other than vowels
                else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                         (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
                {

                    // Increment the consonants
                    consonants++;
                }
            }

            // Display the count of vowels and consonant
            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);
        }
    }
}
