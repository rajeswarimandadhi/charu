using System;
using System.Collections.Generic;
using System.Text;

namespace day_10
{
    class GF
    {
        public static void Main2()
        {
            String inputstring;
            int i, len, vowels, constants;
            inputstring = "novelvista";
            inputstring = "capgemini";
            vowels = 0;
            constants = 0;
            len = inputstring.Length;
            for(i= 0;i < len;i++)
            {
            
                if (
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U' )
                {
                    vowels++;
                }
                else if((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||(inputstring[i] >='A' && inputstring[i] <= 'Z'))
                {
                    constants++;
                }
                Console.WriteLine("count of vowel =" + vowels);
                Console.WriteLine("count of constants=" + constants);


            }


        }
    }
}
