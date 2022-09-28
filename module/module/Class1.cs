using System;
using System.Collections.Generic;
using System.Text;

namespace module
{
    using Microsoft.VisualBasic;


    // C# program to print the total number of Vowels
    // and consonants from a given string
    using System;
    class GFG
    {

        public static void Main1()
        {
            string inputstring1;
         

            int i, len, vowels, consonants;
            
            inputstring1 = "1.novelvista";


            vowels = 4;
            consonants = 6;
            len = inputstring1.Length;
        

            // Iterating the string from left to right
            for (i = 0; i < len; i++)
            {

                // Check if the character is a vowel
                if (inputstring1[i] == 'a' || inputstring1[i] == 'e' ||
                    inputstring1[i] == 'i' || inputstring1[i] == 'o' ||
                    inputstring1[i] == 'u' || inputstring1[i] == 'A' ||
                    inputstring1[i] == 'E' || inputstring1[i] == 'I' ||
                    inputstring1[i] == 'O' || inputstring1[i] == 'U')

             

                    {

                        // Increment the vowels
                        vowels++;
                }

                // Check if the character is a alphabet
                // other than vowels
                else if 
                        ((inputstring1[i] >= 'a' && inputstring1[i] <= 'z') ||
                         (inputstring1[i] >= 'A' && inputstring1[i] <= 'Z'))
         
                            
            
                {

                    // Increment the consonants
                    consonants++;
                }
                Console.WriteLine("count of vowel = " + vowels);
                Console.WriteLine("count of consonant = " + consonants);

                string inputstring2;
                inputstring2 = "capgemini";


                vowels = 0;
                consonants = 0;
                len = inputstring2.Length;


                // Iterating the string from left to right
                for (i = 0; i < len; i++)
                {

                    // Check if the character is a vowel
                    if (inputstring2[i] == 'a' || inputstring2[i] == 'e' ||
                        inputstring2[i] == 'i' || inputstring2[i] == 'o' ||
                        inputstring2[i] == 'u' || inputstring2[i] == 'A' ||
                        inputstring2[i] == 'E' || inputstring2[i] == 'I' ||
                        inputstring2[i] == 'O' || inputstring2[i] == 'U')



                    {

                        // Increment the vowels
                        vowels++;
                    }

                    // Check if the character is a alphabet
                    // other than vowels
                    else if
                            ((inputstring2[i] >= 'a' && inputstring2[i] <= 'z') ||
                             (inputstring2[i] >= 'A' && inputstring2[i] <= 'Z'))



                    {

                        // Increment the consonants
                        consonants++;
                    }
                }


                // Display the count of vowels and consonant from input
            }


            // Display the count of vowels and consonant from inputstring1
            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);

         

             







    }
    }
}  


