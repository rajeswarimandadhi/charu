using System;
using System.Collections.Generic;
using System.Text;

namespace module
{
    using System;
    public class Demo
    {
        public static void Main5()
        {
            string myStr;
            int i, len, vowel_count, cons_count;
            myStr = "novelvista";
            vowel_count = 0;
            cons_count = 0;
            // find length
            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }
            Console.Write("\nVowels in the string: {0}\n", vowel_count);
            Console.Write("\nConstants in the string: {0}\n", cons_count);

        }
    }
}
